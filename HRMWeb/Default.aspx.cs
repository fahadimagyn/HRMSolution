using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text;

namespace HRMWeb
{
    public partial class _Default : System.Web.UI.Page
    {  SqlConnection scon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {  
            if (!IsPostBack)
            {  
                if (Session["user"] != null)
                {
                    set_company(Session["user"].ToString());
                    set_userDetail();
                    set_label();
                    menu();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            } 
       }
        protected void set_company(String user)
        {
            SqlCommand scomd = new SqlCommand("Company_ByUserName", scon);
            scomd.CommandType = CommandType.StoredProcedure;
            scomd.Parameters.Add("@userName", SqlDbType.VarChar).Value = Session["user"];
            SqlDataAdapter sda = new SqlDataAdapter(scomd);
            DataTable dt = new DataTable();
            scon.Open();
            sda.Fill(dt);
            Session["companyID"] = Convert.ToInt32(dt.Rows[0][0].ToString());
            Session["companyName"]= dt.Rows[0][1].ToString();
            scon.Close();
        }
        protected void set_label()
        { 
             companyName.Text=Session["companyName"].ToString();
             user.Text= Session["user"].ToString();
             desg.Text = ViewState["designation"].ToString();
        }
        protected void set_userDetail()
        {
            if (Session["companyID"] != null && Session["user"] != null)
            {
                SqlCommand scomd = new SqlCommand("Employee_GetByUserNameCompanyID", scon);
                scomd.CommandType = CommandType.StoredProcedure;
                scomd.Parameters.Add("@userName", SqlDbType.VarChar).Value = Session["user"];
                scomd.Parameters.Add("@companyID", SqlDbType.Int).Value = Convert.ToInt32(Session["companyID"].ToString());
                SqlDataAdapter sda = new SqlDataAdapter(scomd);
                DataTable dt = new DataTable();
                scon.Open();
                sda.Fill(dt);
                scon.Close();
                Session["empID"] = dt.Rows[0][0];
                ViewState["userName"] = dt.Rows[0][3];
                scomd = new SqlCommand("Employee_Designation", scon);
                scomd.CommandType = CommandType.StoredProcedure;
                scomd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(Session["empID"].ToString());
                sda = new SqlDataAdapter(scomd);
                dt = new DataTable();
                scon.Open();
                sda.Fill(dt);
                scon.Close();
                ViewState["designation"] = dt.Rows[0][0];
            }
            
        }
        protected void menu()
        {
            DataTable menuData = new DataTable();
            DataSet ds = new DataSet();
            DataView view = null;
            SqlCommand cmd = new SqlCommand("generateMenu", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empID", SqlDbType.Int).Value = Session["empID"];
            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            menuData= ds.Tables[0];
            scon.Close();
            try
            {
                view = new DataView(menuData);
                view.RowFilter = "parentId IS NULL";
                foreach (DataRowView row in view)
                {

                    MenuItem newMenuItem = new MenuItem(row["applicationName"].ToString(), row["applicationID"].ToString());
                    mymenu.Items.Add(newMenuItem);

                    AddChildMenuItems(menuData, newMenuItem);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                view = null;
            }
        }
        private void AddChildMenuItems(DataTable menuData, MenuItem parentMenuItem)
        {
            DataView view = null;
            try
            {  
                view = new DataView(menuData);
                view.RowFilter = "ParentID=" + parentMenuItem.Value;
                foreach (DataRowView row in view)
                {
                    MenuItem newMenuItem = new MenuItem(row["applicationName"].ToString(), row["applicationID"].ToString());
                    newMenuItem.NavigateUrl = row["applicationPath"].ToString();
                    parentMenuItem.ChildItems.Add(newMenuItem);
                   // Response.Write(row["applicationName"].ToString());
                    AddChildMenuItems(menuData, newMenuItem);
                }
            }
            catch (Exception ex)
            {
                //Show the error massage here
            }
            finally
            {
                view = null;
            }
        }

        protected void mymenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
    
}

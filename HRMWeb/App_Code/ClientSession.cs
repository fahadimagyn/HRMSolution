using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Data;

namespace HRMWeb.App_Code
{
    public class ClientSession
    {
        private static string _storeID = "storeID";
        private static string _loginCompany = "loginCompany";
        private static string _landingCompany = "landingCompany";
        private static string _landingURL = "landingURL";
        private static string _reportLandingURL = "reportLandingURL";
        private static string _employeeInformation = "EmployeeInformation";
        private static string _employee = "Employee";
        private static string _userName = "UserName";
        private static string _employeeID = "EmployeeID";
        private static string _store = "Store";
        private static string _Date = "_Date";
        private static string _CompanyID = "CompanyID";
        private static string _logID = "_logID";
        private static string _employeeRole = "_employeeRole";
        private static string _SessionDataSet = "_SessionDataSet";
        private static string _CurrentRoleByEmpID = "CurrentRoleByEmpID";
        private static string _EmpRoleByEmpID = "EmpRoleByEmpID";

        
        public static Int32 logID
        {
            get
            {
                if (HttpContext.Current.Session[_logID] == null)
                    return 0;
                else
                    return Convert.ToInt32(HttpContext.Current.Session[_logID]);
            }
            set { HttpContext.Current.Session[_logID] = value; }
        }
        public static DataSet SessionDataSet
        {
            get
            {
                if (HttpContext.Current.Session[_SessionDataSet] == null)
                    return new DataSet();
                else
                    return (DataSet)(HttpContext.Current.Session[_SessionDataSet]);
            }
            set { HttpContext.Current.Session[_SessionDataSet] = value; }
        }

        public static Int32 storeID
        {
            get
            {
                if (HttpContext.Current.Session[_storeID] == null)
                    return 0;
                else
                    return Convert.ToInt32(HttpContext.Current.Session[_storeID]);
            }
            set { HttpContext.Current.Session[_storeID] = value; }
        }

        public static Int32 CompanyID
        {
            get
            {
                if (HttpContext.Current.Session[_CompanyID] == null)
                    return 0;
                else
                    return Convert.ToInt32(HttpContext.Current.Session[_CompanyID]);
            }
            set { HttpContext.Current.Session[_CompanyID] = value; }
        }

        public static String LandingURL
        {
            get
            {
                if (HttpContext.Current.Session[_landingURL] == null)
                    return null;
                else
                    return HttpContext.Current.Session[_landingURL].ToString();
            }
            set { HttpContext.Current.Session[_landingURL] = value; }
        }

        public static String ReportLandingURL
        {
            get
            {
                if (HttpContext.Current.Session[_reportLandingURL] == null)
                    return "0";
                else
                    return HttpContext.Current.Session[_reportLandingURL].ToString();
            }
            set { HttpContext.Current.Session[_reportLandingURL] = value; }
        }

        public static String UserName
        {
            get
            {
                if (HttpContext.Current.Session[_userName] == null)
                    return null;
                else
                    return HttpContext.Current.Session[_userName].ToString();
            }
            set { HttpContext.Current.Session[_userName] = value; }
        }

        public static Int32 EmployeeID
        {
            get
            {
                if (HttpContext.Current.Session[_employeeID] == null)
                    return 0;
                else
                    return Convert.ToInt32(HttpContext.Current.Session[_employeeID]);
            }
            set { HttpContext.Current.Session[_employeeID] = value; }
        }
     
        public static employeeinformation EmployeeInformation
        {
            get
            {
                if (!String.IsNullOrEmpty(UserName))
                {
                    if (HttpContext.Current.Session[_employeeInformation] == null)
                    {
                        SqlParameterCollection collection = GetParameterCollectionConstructor();
                        collection.AddWithValue("@UserName", UserName);

                        EmployeeInformation empInfo = AccountHandler.Get_EmployeeInformationByUserName(collection);
                        HttpContext.Current.Session[_employeeInformation] = empInfo;

                        return HttpContext.Current.Session[_employeeInformation] as EmployeeInformation;
                    }
                    else
                        return HttpContext.Current.Session[_employeeInformation] as EmployeeInformation;
                }
                else
                {
                    HttpContext.Current.Session[_employeeInformation] = null;
                    return HttpContext.Current.Session[_employeeInformation] as EmployeeInformation;
                }
            }
            set { HttpContext.Current.Session[_employeeInformation] = value; }
        }

        public static string ConnectionString
        {
            get
            {
                string conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                if (conn == null || conn == String.Empty)
                {
                    throw new Exception("Connection string is empty.  Check Web.config");
                }
                return conn;
            }
        }


    }
}
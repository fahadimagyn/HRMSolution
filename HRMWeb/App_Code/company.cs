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
    public class company
    {
        private Int32 _companyID;
        public Int32 companyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private String _companyName;
        public String companyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private String _companyAddress;
        public String companyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }


        private String _cssURL;
        public String cssURL
        {
            get { return _cssURL; }
            set { _cssURL = value; }
        }

        private String _landingURL;
        public String landingURL
        {
            get { return _landingURL; }
            set { _landingURL = value; }
        }



        private String _reportsPortalURL;
        public String reportsPortalURL
        {
            get { return _reportsPortalURL; }
            set { _reportsPortalURL = value; }
        }


        private String _companyLogo;
        public String companyLogo
        {
            get { return _companyLogo; }
            set { _companyLogo = value; }
        }



        private String _companyGUID;
        public String companyGUID
        {
            get { return _companyGUID; }
            set { _companyGUID = value; }
        }


        private String _connectionStringReportingKey;
        public String connectionStringReportingKey
        {
            get { return _connectionStringReportingKey; }
            set { _connectionStringReportingKey = value; }
        }

        private String _reportCssUrl;
        public String reportCssURL
        {
            get { return _reportCssUrl; }
            set { _reportCssUrl = value; }
        }

        private String _companyKey;
        public String companyKey
        {
            get { return _companyKey; }
            set { _companyKey = value; }
        }
         public company()
        {
            _companyID = 0;
            _companyName = String.Empty;
            _companyAddress = String.Empty;
            _landingURL = String.Empty;
            _reportsPortalURL = String.Empty;
            _companyLogo = String.Empty;
            _cssURL = string.Empty;
           _companyKey = _connectionStringReportingKey = _companyGUID = "";
            _reportCssUrl = string.Empty;

        }
        public company(Int32 companyID, String companyName, String companyAddress, String ladingURL, String reportsPortalURL, String companyLogo, String companyGUID, String connectionStringReportingKey, String reportCssURL,String companyKey)
        {
            _companyID = companyID;
            _companyName = companyName;
            _companyAddress = companyAddress;
            _landingURL = ladingURL;
            _reportsPortalURL = reportsPortalURL;
            _companyLogo = companyLogo;
            _cssURL = cssURL;
            _companyGUID = companyGUID;
            _connectionStringReportingKey = connectionStringReportingKey;
            _reportCssUrl = reportCssURL;
            _companyKey = companyKey;
        }

        public static company get_company(int id)
        {
            company obj = null;
            SqlConnection scon = new SqlConnection(ClientSession.ConnectionString);
            SqlCommand scmd = new SqlCommand("Company_Selectby_ID", scon);
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.Parameters.Add("@orig_companyID", SqlDbType.Int).Value =id;
            DataTable dt = new DataTable();
            scon.Open();
            sda.Fill(dt);
            scon.Close();
            foreach (DataRow row in dt.Rows)
            {
                if (row["companyID"] != null)
                {
                    obj._companyID = (Int32)row["companyID"];
                }
                if (row["companyName"] != null)
                {
                    obj.companyName = (String)row["companyName"];
                }
                if (row["companyAddress"] != null)
                {
                    obj.companyAddress =(String) row["companyAddress"];
                }
                if (row["landingURL"] != null)
                {
                    obj.landingURL = (String)row["landingURL"];
                }
                if (row["reportsPortalURL"] != null)
                {
                    obj.reportsPortalURL =(String) row["reportsPortalURL"];
                }
                if (row["companyLogo"] != null)
                {
                    obj.companyLogo = (String)row["companyLogo"];
                }
                if (row["cssURL"] != null)
                {
                    obj.cssURL = (String)row["cssURL:"];
                }
                if (row["companyKey"] != null)
                {
                    obj.companyKey = (String)row["companyKey"];
                }
                if (row["connectionStringReportingKey"] != null)
                {
                    obj.connectionStringReportingKey = (String)row["connectionStringReportingKey"];
                }
                
            }

            return obj;
        }

    }
}
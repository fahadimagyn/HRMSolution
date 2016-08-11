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
     
    public class employeeinformation
    {  
        private Int32 _employeeID;
        public Int32 employeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        private String _userName;
        public String userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private String _employeeTitle;
        public String employeeTitle
        {
            get { return _employeeTitle; }
            set { _employeeTitle = value; }
        }

        private String _firstName;
        public String firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _middleName;
        public String middleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        private String _lastName;
        public String lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private String _employeeEmail;
        public String employeeEmail
        {
            get { return _employeeEmail; }
            set { _employeeEmail = value; }
        }

        private String _cellularNo;
        public String cellularNo
        {
            get { return _cellularNo; }
            set { _cellularNo = value; }
        }

        private String _smsNumber;
        public String smsNumber
        {
            get { return _smsNumber; }
            set { _smsNumber = value; }
        }

        private String _employeeGender;
        public String employeeGender
        {
            get { return _employeeGender; }
            set { _employeeGender = value; }
        }

        private DateTime _dateOfBirth;
        public DateTime dateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private DateTime _dateofJoin;
        public DateTime dateofJoin
        {
            get { return _dateofJoin; }
            set { _dateofJoin = value; }
        }

        private DateTime _payrollEffactiveDate;
        public DateTime payrollEffactiveDate
        {
            get { return _payrollEffactiveDate; }
            set { _payrollEffactiveDate = value; }
        }

        private String _nationalID;
        public String nationalID
        {
            get { return _nationalID; }
            set { _nationalID = value; }
        }

        private String _createdBy;
        public String createdBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        private Boolean _isActive;
        public Boolean isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private String _addressLine1;
        public String addressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }

        private String _addressLine2;
        public String addressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }

        private Int32 _cityID;
        public Int32 cityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        private Int32 _stateID;
        public Int32 stateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }

        private Int32 _countryID;
        public Int32 countryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        private String _zipCode;
        public String zipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        private String _homePhone;
        public String homePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        private Int32 _yearOfExperience;
        public Int32 yearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }

        private String _lastQualification;
        public String lastQualification
        {
            get { return _lastQualification; }
            set { _lastQualification = value; }
        }

        private Decimal _employeeSalary;
        public Decimal employeeSalary
        {
            get { return _employeeSalary; }
            set { _employeeSalary = value; }
        }

        private Decimal _employeeHourly;
        public Decimal employeeHourly
        {
            get { return _employeeHourly; }
            set { _employeeHourly = value; }
        }

        private Int32 _employeeCommission;
        public Int32 employeeCommission
        {
            get { return _employeeCommission; }
            set { _employeeCommission = value; }
        }

        private String _commissionType;
        public String commissionType
        {
            get { return _commissionType; }
            set { _commissionType = value; }
        }

        private Int32 _overTimeHours;
        public Int32 overTimeHours
        {
            get { return _overTimeHours; }
            set { _overTimeHours = value; }
        }

        private String _overTimeType;
        public String overTimeType
        {
            get { return _overTimeType; }
            set { _overTimeType = value; }
        }

        private Decimal _overTimeRate;
        public Decimal overTimeRate
        {
            get { return _overTimeRate; }
            set { _overTimeRate = value; }
        }

        private Boolean _IPSec;
        public Boolean IPSec
        {
            get { return _IPSec; }
            set { _IPSec = value; }
        }

        private Boolean _fixedStore;
        public Boolean fixedStore
        {
            get { return _fixedStore; }
            set { _fixedStore = value; }
        }

        private Int32 _companyID;
        public Int32 companyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private Int32 _storeID;
        public Int32 storeID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }

        private Int32 _designationID;
        public Int32 designationID
        {
            get { return _designationID; }
            set { _designationID = value; }
        }

        private Int32 _departmentID;
        public Int32 departmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; }
        }

        private Decimal _flatRate;
        public Decimal flatRate
        {
            get { return _flatRate; }
            set { _flatRate = value; }
        }

        private String _bankRoutingNo;
        public String bankRoutingNo
        {
            get { return _bankRoutingNo; }
            set { _bankRoutingNo = value; }
        }

        private String _bankAccNo;
        public String bankAccNo
        {
            get { return _bankAccNo; }
            set { _bankAccNo = value; }
        }

        private DateTime _appointDate;
        public DateTime appointDate
        {
            get { return _appointDate; }
            set { _appointDate = value; }
        }

        private DateTime _terminationDate;
        public DateTime terminationDate
        {
            get { return _terminationDate; }
            set { _terminationDate = value; }
        }

        private Int32 _trainingPeriod;
        public Int32 trainingPeriod
        {
            get { return _trainingPeriod; }
            set { _trainingPeriod = value; }
        }

        private String _status;
        public String status
        {
            get { return _status; }
            set { _status = value; }
        }

        private Int32 _agencyID;
        public Int32 agencyID
        {
            get { return _agencyID; }
            set { _agencyID = value; }
        }

        private Int32 _empTypeID;
        public Int32 empTypeID
        {
            get { return _empTypeID; }
            set { _empTypeID = value; }
        }

        private Int32 _payrollCompID;
        public Int32 payrollCompID
        {
            get { return _payrollCompID; }
            set { _payrollCompID = value; }
        }

        private Boolean _is1099;
        public Boolean is1099
        {
            get { return _is1099; }
            set { _is1099 = value; }
        }

        private String _LogComments;
        public String LogComments
        {
            get { return _LogComments; }
            set { _LogComments = value; }
        }

        private Decimal _TotalAdjustments;
        public Decimal TotalAdjustments
        {
            get { return _TotalAdjustments; }
            set { _TotalAdjustments = value; }
        }

        private Boolean _isVirtualEmployee;
        public Boolean isVirtualEmployee
        {
            get { return _isVirtualEmployee; }
            set { _isVirtualEmployee = value; }
        }
        private DateTime _lastUpdated;
        public DateTime lastUpdated
        {
            get { return _lastUpdated; }
            set { _lastUpdated = value; }
        }
        private int _updatedBy;
        public Int32 updatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        private String _pseudoName;
        public String pseudoName
        {
            get { return _pseudoName; }
            set { _pseudoName = value; }
        }


        private Boolean _HideStaffing;
        public Boolean HideStaffing
        {
            get { return _HideStaffing; }
            set { _HideStaffing = value; }
        }

        private String _MaskName;
        public String MaskName
        {
            get { return _MaskName; }
            set { _MaskName = value; }
        }
         public employeeinformation()
        {
            _employeeID = 0;
            _userName = String.Empty;
            _employeeTitle = String.Empty;
            _firstName = String.Empty;
            _middleName = String.Empty;
            _lastName = String.Empty;
            _employeeEmail = String.Empty;
            _cellularNo = String.Empty;
            _smsNumber = String.Empty;
            _employeeGender = String.Empty;
            _dateOfBirth = DateTime.MinValue;
            _dateofJoin = DateTime.MinValue;
            _nationalID = String.Empty;
            _isActive = false;
            _addressLine1 = String.Empty;
            _addressLine2 = String.Empty;
            _cityID = 0;
            _stateID = 0;
            _countryID = 0;
            _zipCode = String.Empty;
            _homePhone = String.Empty;
            _yearOfExperience = 0;
            _lastQualification = String.Empty;
            _employeeSalary = 0M;
            _employeeHourly = 0M;
            _employeeCommission = 0;
            _commissionType = String.Empty;
            _overTimeHours = 0;
            _overTimeType = String.Empty;
            _overTimeRate = 0M;
            _IPSec = false;
            _fixedStore = false;
            _companyID = 0;
            _storeID = 0;
            _designationID = 0;
            _departmentID = 0;
            _flatRate = 0M;
            _bankRoutingNo = String.Empty;
            _bankAccNo = String.Empty;
            _appointDate = DateTime.MinValue;
            _terminationDate = DateTime.MinValue;
            _trainingPeriod = 0;
            _status = String.Empty;
            _agencyID = 0;
            _empTypeID = 0;
            _LogComments = string.Empty;
            _TotalAdjustments = 0;
            _payrollEffactiveDate = DateTime.MinValue;
            _createdBy = string.Empty;
            _isVirtualEmployee = false;
            _lastUpdated = DateTime.MinValue;
            _updatedBy = 0;
            _pseudoName = String.Empty;
            _HideStaffing = false;
            _MaskName = string.Empty;

        }
         public employeeinformation(Int32 employeeID, String userName, String employeeTitle, String firstName, String middleName, String lastName, String employeeEmail, String cellularNo, String smsNumber, String employeeGender, DateTime dateOfBirth, DateTime dateofJoin, String nationalID, Boolean isActive, String addressLine1, String addressLine2, Int32 cityID, Int32 stateID, Int32 countryID, String zipCode, String homePhone, Int32 yearOfExperience, String lastQualification, Decimal employeeSalary, Decimal employeeHourly, Int32 employeeCommission, String commissionType, Int32 overTimeHours, String overTimeType, Decimal overTimeRate, Boolean IPSec, Boolean fixedStore, Int32 companyID, Int32 departmentID, Decimal flatRate, String bankRoutingNo, String bankAccNo, DateTime appointDate, DateTime terminationDate, Int32 trainingPeriod, String status, Int32 agencyID, Int32 empTID, DateTime PayEffDate, String crtBy, Boolean isVirtualEmployee, DateTime lastupdated, int updatedby, String pseudoName, Boolean HideStaffing) //Int32 storeID, Int32 designationID,
        {
            _employeeID = employeeID;
            _userName = userName;
            _employeeTitle = employeeTitle;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _employeeEmail = employeeEmail;
            _cellularNo = cellularNo;
            _smsNumber = smsNumber;
            _employeeGender = employeeGender;
            _dateOfBirth = dateOfBirth;
            _dateofJoin = dateofJoin;
            _nationalID = nationalID;
            _isActive = isActive;
            _addressLine1 = addressLine1;
            _addressLine2 = addressLine2;
            _cityID = cityID;
            _stateID = stateID;
            _countryID = countryID;
            _zipCode = zipCode;
            _homePhone = homePhone;
            _yearOfExperience = yearOfExperience;
            _lastQualification = lastQualification;
            _employeeSalary = employeeSalary;
            _employeeHourly = employeeHourly;
            _employeeCommission = employeeCommission;
            _commissionType = commissionType;
            _overTimeHours = overTimeHours;
            _overTimeType = overTimeType;
            _overTimeRate = overTimeRate;
            _IPSec = IPSec;
            _fixedStore = fixedStore;
            _companyID = companyID;
            _storeID = storeID;
            _designationID = designationID;
            _departmentID = departmentID;
            _flatRate = flatRate;
            _bankRoutingNo = bankRoutingNo;
            _bankAccNo = bankAccNo;
            _appointDate = appointDate;
            _terminationDate = terminationDate;
            _trainingPeriod = trainingPeriod;
            _status = status;
            _agencyID = agencyID;
            _empTypeID = empTID;
            _TotalAdjustments = 0;
            _payrollEffactiveDate = PayEffDate;
            _createdBy = crtBy;
            _isVirtualEmployee = isVirtualEmployee;
            _lastUpdated = lastupdated;
            _updatedBy = updatedby;
            _pseudoName = pseudoName;
            _HideStaffing = HideStaffing;
        }
         
        public static employeeinformation set_empinfo(string user)
        {
            employeeinformation obj = null;
            SqlConnection scon = new SqlConnection(ClientSession.ConnectionString);
            SqlCommand scmd = new SqlCommand("EmployeeInformation_byUserName",scon);
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user;
            DataTable dt = new DataTable();
            scon.Open();
            sda.Fill(dt);
            scon.Close();
            foreach (DataRow row in dt.Rows)
            {
                if (row["employeeID"] != null)
                {
                    obj.employeeID=(Int32)row["employeeID"];
                }

                if (row["userName"] != null)
                {
                    obj.userName=row["userName"].ToString();
                }
                if (row["employeeTitle"] != null)
                {
                    obj.employeeTitle=row["employeeTitle"].ToString();
                }
                if (row["firstName"] != null)
                {
                    obj.firstName=row["firstName"].ToString();
                }
                if (row["middleName"] != null)
                {
                    obj.middleName=row["middleName"].ToString();
                }
                if (row["lastName"] != null)
                {
                    obj.lastName=row["lastName"].ToString();
                }
                if (row["employeeEmail"] != null)
                {
                    obj.employeeEmail=row["employeeEmail"].ToString();
                }
                if (row["cellularNo"] != null)
                {
                    obj.cellularNo=row["cellularNo"].ToString();
                }
                if (row["smsNumber"] != null)
                {
                    obj.smsNumber=row["smsNumber"].ToString();
                }
                if (row["employeeGender"] != null)
                {
                    obj.employeeGender=(row["employeeGender"].ToString());
                }
                if (row["dateOfBirth"] != null)
                {
                    obj.dateOfBirth=(DateTime)(row["dateOfBirth"]);
                }
                if (row["dateofJoin"] != null)
                {
                    obj.dateOfBirth = (DateTime)(row["dateofJoin"]);
                }
                if (row["nationalID"] != null)
                {
                    obj.nationalID=(row["nationalID"]).ToString();
                }
                if (row["isActive"] != null)
                {
                    obj.isActive=(Boolean)(row["isActive"]);
                }
                if (row["addressLine1"] != null)
                {
                    obj.addressLine1=(row["addressLine1"]).ToString();
                }
                if (row["addressLine2"] != null)
                {
                    obj.addressLine1=(row["addressLine2"]).ToString();
                }
                if (row["cityID"] != null)
                {
                    obj.cityID=(Int32)(row["cityID"]);
                }
                if (row["stateID"] != null)
                {
                    obj.stateID=(Int32)(row["stateID"]);
                }
                if (row["countryID"] != null)
                {
                    obj.countryID=(Int32)(row["countryID"]);
                }
                if (row["zipCode"] != null)
                {
                   obj.zipCode =(row["zipCode"]).ToString();
                }
                if (row["homePhone"] != null)
                {
                    obj.homePhone=(String)(row["homePhone"]);
                }
                if (row["yearOfExperience"] != null)
                {
                    obj.yearOfExperience=(Int32)(row["yearOfExperience"]);
                }
                if (row["lastQualification"] != null)
                {
                    obj.lastQualification=(row["lastQualification"]).ToString();
                }
                if (row["employeeSalary"] != null)
                {
                    obj.employeeSalary=(Decimal)(row["employeeSalary"]);
                }
                if (row["employeeHourly"] != null)
                {
                    obj.employeeHourly=(Decimal)(row["employeeHourly"]);
                }
                if (row["employeeCommission"] != null)
                {
                    obj.employeeCommission=(Int32)(row["employeeCommission"]);
                }
                if (row["commissionType"] != null)
                {
                    obj.commissionType=(String)(row["commissionType"]);
                }
                if (row["overTimeHours"] != null)
                {
                   obj.overTimeHours=(Int32)(row["overTimeHours"]);
                }
                if (row["overTimeType"] != null)
                {
                    obj.overTimeType=(String)(row["overTimeType"]);
                }
                if (row["overTimeRate"] != null)
                {
                    obj.overTimeRate=(Decimal)(row["overTimeRate"]);
                }
                if (row["IPSec"] != null)
                {
                    obj.IPSec=(Boolean)(row["IPSec"]);
                }
                if (row["fixedStore"] != null)
                {
                    obj.fixedStore=(Boolean)(row["fixedStore"]);
                }
                if (row["companyID"] != null)
                {
                    obj.countryID=(Int32)(row["companyID"]);
                }
                if (row["storeID"] != null)
                {
                    obj.storeID=(Int32)(row["storeID"]);
                }
                if (row["designationID"] != null)
                {
                   obj.designationID=(Int32)(row["designationID"]);
                }
                if (row["departmentID"] != null)
                {
                    obj.departmentID=(Int32)(row["departmentID"]);
                }
            }
            
            return obj;
        }
    }
}
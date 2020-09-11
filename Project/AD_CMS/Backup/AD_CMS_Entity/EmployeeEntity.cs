using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_CMS_Entity
{
    public class EmployeeEntity
    {
        public int empid;
        public string profile;
        public string emp_firstName;
        public string emp_middleName;
        public string emp_lastName;
        public string father_firstName;
        public string father_middleName;
        public string father_lastName;
        public string mother_firstName;
        public string mother_middleName;
        public string mother_lastName;
        public DateTime joinDate;
        public string isTeaching;
        public string currentAddress;
        public string permanentAddress;
        public int? pincode;
        public int cityid;
        public int stateid;
        public int countryid;
        public string gender;
        public int castid;
        public DateTime dob;
        public string birthplace;
        public Int64 empmobileNo;
        public string email;
        public Int64? telephone;
        public Int64 perentsNo;
        public string degree;
        public string lastEmployeeAt;
        public int? YearOfExperience;
        public string remark;

        /*-----------BankDetails-------------*/
        public int bankID;
        public Int64 accountNo;
        public string IFSCCode;
        public string BranchName;

        /*-----------IdentityProof---------------------*/
        public bool aadharCard;
        public bool panCard;
        public bool experienceCertificate;
        public bool degreeCertificate;

        public int salary;
        public DateTime paymentdate;
        public string month;
    }
}

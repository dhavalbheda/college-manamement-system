using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_CMS_Entity
{
    public class StudentEntity
    {
        public int grno;
        public DateTime AdmissionDate;
        public string ProfilePhoto;

        public string candidate_FirstName;
        public string candidate_LastName;
        public string candidate_MiddleName;
        public string gender;

        public int CastId;
        public int CountryId;
        public int StateId;
        public int CityId;

        public string CurrentAddress;
        public string PermanentAddress;
        public int? Pincode;

        public string BirthPlace;
        public DateTime DOB;

        public Int64 MobileNo;
        public Int64? TelephoneNo;
        public string Email;

        public int CourseId;
        public string Coursenm;
        public int AdmissionSem;
        public int CurrentSem;

        public int Discount;
        public int Fees;
        public string Remark;

        public char CurrentStatus;
        public int LeavingYear;


        ///-----------------------Parents-------------------------///
        public string father_FirstName;
        public string father_MiddleName;
        public string father_LastName;

        public string mother_FirstName;
        public string mother_MiddleName;
        public string mother_LastName;

        public string ParentsOccupation;
        public string OfficeAddress;
        
        public Int64 ContactNo;


        ///---------------------School-------------------///
        public string SchoolName;
        public string SchoolStream;
        public int LastYear;
        public int LastYear_Percentage;

        /// --------------------College--------------------////

        public bool checkCollege;
        public string CollegeName;
        public string CollegeStream;
        public int CollegeYear;
        public int LastSem;
        public int LastSem_Percentage;


        ///--------------------Document Details------------------///
        public bool marksheet_12;
        public bool lc_12;

        public bool previous_marksheet;
        public bool NOC;
        public bool TC;
    }
}

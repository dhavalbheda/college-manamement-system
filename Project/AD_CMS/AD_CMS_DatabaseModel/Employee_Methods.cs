using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AD_CMS;
using AD_CMS_Entity;

namespace AD_CMS_DatabaseModel
{
    public class Employee_Methods
    {
        public static DataTable loadBankName()
        {
            DataTable dt=new DataTable("BankName");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM BankName",conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static int insertEmployee(EmployeeEntity ey)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("insertEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empID",ey.empid); 
                    cmd.Parameters.AddWithValue("@profile", ey.profile);
                    cmd.Parameters.AddWithValue("@name", ey.emp_firstName+" "+ey.emp_middleName+" "+ey.emp_lastName);
                    cmd.Parameters.AddWithValue("@fathername", ey.father_firstName+" "+ey.father_middleName+" "+ey.father_lastName);
                    cmd.Parameters.AddWithValue("@mothername", ey.mother_firstName+" "+ey.mother_middleName+" "+ey.mother_lastName);
                    cmd.Parameters.AddWithValue("@joindate", ey.joinDate); 
                    cmd.Parameters.AddWithValue("@isteaching", ey.isTeaching);
                    cmd.Parameters.AddWithValue("@currentAddress", ey.currentAddress);
                    cmd.Parameters.AddWithValue("@permanentAddress", ey.permanentAddress);
                    cmd.Parameters.AddWithValue("@pincode", ey.pincode);
                    cmd.Parameters.AddWithValue("@cityid", ey.cityid);
                    cmd.Parameters.AddWithValue("@stateid", ey.stateid);
                    cmd.Parameters.AddWithValue("@countryid", ey.countryid);
                    cmd.Parameters.AddWithValue("@gender", ey.gender);
                    cmd.Parameters.AddWithValue("@castid", ey.castid);
                    cmd.Parameters.AddWithValue("@dob", ey.dob);
                    cmd.Parameters.AddWithValue("@birthplace", ey.birthplace);
                    cmd.Parameters.AddWithValue("@empmno", ey.empmobileNo);
                    cmd.Parameters.AddWithValue("@email", ey.email);
                    cmd.Parameters.AddWithValue("@telephone", ey.telephone);
                    cmd.Parameters.AddWithValue("@parentsmno", ey.perentsNo);
                    cmd.Parameters.AddWithValue("@degree", ey.degree);
                    cmd.Parameters.AddWithValue("@lastEmployeeAt", ey.lastEmployeeAt);
                    cmd.Parameters.AddWithValue("@yearofExpirience", ey.YearOfExperience);
                    cmd.Parameters.AddWithValue("@remark", ey.remark);
                    /*----------------Employee Bank Details------------*/
                    cmd.Parameters.AddWithValue("@bankid", ey.bankID);
                    cmd.Parameters.AddWithValue("@accountNo", ey.accountNo);
                    cmd.Parameters.AddWithValue("@branchName", ey.BranchName);
                    cmd.Parameters.AddWithValue("@IFSCCode", ey.IFSCCode);
                    /*----------------Employee IdentityProof Details------------*/
                    cmd.Parameters.AddWithValue("@aadharcard", ey.aadharCard);
                    cmd.Parameters.AddWithValue("@pancard", ey.panCard);
                    cmd.Parameters.AddWithValue("@experiencecertificate", ey.experienceCertificate);
                    cmd.Parameters.AddWithValue("@degreecertificate", ey.degreeCertificate);


                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable loadEmployee()
        {
            DataTable dt = new DataTable("Employee");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT  EMPID,E_NAME AS EmpoyeeName,E_Gender as Gender,E_IsTeaching As Designation,
                             (SELECT        CityNm
                               FROM            City
                               WHERE        (CityId = Employee.E_CityId)) AS City, E_Empmobileno AS MobileNo,E_Profile as 'Profile'
                             FROM  Employee", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static DataTable loadEmployeeDetails_Form(int empid)
        {
            DataTable dt = new DataTable("Employee");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadEmployeeForm", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", empid);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static int updateEmployee(EmployeeEntity ey)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("updateEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empID", ey.empid);
                    cmd.Parameters.AddWithValue("@profile", ey.profile);
                    cmd.Parameters.AddWithValue("@name", ey.emp_firstName + " " + ey.emp_middleName + " " + ey.emp_lastName);
                    cmd.Parameters.AddWithValue("@fathername", ey.father_firstName + " " + ey.father_middleName + " " + ey.father_lastName);
                    cmd.Parameters.AddWithValue("@mothername", ey.mother_firstName + " " + ey.mother_middleName + " " + ey.mother_lastName);
                    cmd.Parameters.AddWithValue("@joindate", ey.joinDate);
                    cmd.Parameters.AddWithValue("@isteaching", ey.isTeaching);
                    cmd.Parameters.AddWithValue("@currentAddress", ey.currentAddress);
                    cmd.Parameters.AddWithValue("@permanentAddress", ey.permanentAddress);
                    cmd.Parameters.AddWithValue("@pincode", ey.pincode);
                    cmd.Parameters.AddWithValue("@cityid", ey.cityid);
                    cmd.Parameters.AddWithValue("@stateid", ey.stateid);
                    cmd.Parameters.AddWithValue("@countryid", ey.countryid);
                    cmd.Parameters.AddWithValue("@gender", ey.gender);
                    cmd.Parameters.AddWithValue("@castid", ey.castid);
                    cmd.Parameters.AddWithValue("@dob", ey.dob);
                    cmd.Parameters.AddWithValue("@birthplace", ey.birthplace);
                    cmd.Parameters.AddWithValue("@empmno", ey.empmobileNo);
                    cmd.Parameters.AddWithValue("@email", ey.email);
                    cmd.Parameters.AddWithValue("@telephone", ey.telephone);
                    cmd.Parameters.AddWithValue("@parentsmno", ey.perentsNo);
                    cmd.Parameters.AddWithValue("@degree", ey.degree);
                    cmd.Parameters.AddWithValue("@lastEmployeeAt", ey.lastEmployeeAt);
                    cmd.Parameters.AddWithValue("@yearofExpirience", ey.YearOfExperience);
                    cmd.Parameters.AddWithValue("@remark", ey.remark);
                    /*----------------Employee Bank Details------------*/
                    cmd.Parameters.AddWithValue("@bankid", ey.bankID);
                    cmd.Parameters.AddWithValue("@accountNo", ey.accountNo);
                    cmd.Parameters.AddWithValue("@branchName", ey.BranchName);
                    cmd.Parameters.AddWithValue("@IFSCCode", ey.IFSCCode);
                    /*----------------Employee IdentityProof Details------------*/
                    cmd.Parameters.AddWithValue("@aadharcard", ey.aadharCard);
                    cmd.Parameters.AddWithValue("@pancard", ey.panCard);
                    cmd.Parameters.AddWithValue("@experiencecertificate", ey.experienceCertificate);
                    cmd.Parameters.AddWithValue("@degreecertificate", ey.degreeCertificate);


                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int loadEmpID()
        {
            int EMPID;
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("load_EMPID", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        EMPID = (int)dr[0];
                        EMPID++;
                    }
                }
            }
            return EMPID;
        }

        public static int deleteEmployee(int empid)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cnd = new SqlCommand("delete_employee", conn))
                {
                    cnd.CommandType = CommandType.StoredProcedure;
                    cnd.Parameters.AddWithValue("@empid", empid);
                    conn.Open();

                    return cnd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable loadEmp_salary(string str)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                string qry = @"SELECT Empid as 'Employee Id', 
                            (
                                select E_name from Employee
                                where EmpID=e.Empid
                            ) as 'Employee Name',
                            (
                                select E_IsTeaching from Employee 
                                where EmpId=e.Empid
                            ) as 'Employee Type',
                            CASE e.E_Salary 
                                WHEN 0 THEN 'Not Set' 
                                ELSE (
                                        SELECT CAST(E_Salary AS varchar) 
                                        FROM Employee_set_salary 
                                        WHERE e.Empid = Empid
                                     )
                                END AS 'Salary'";
                if (str.Equals("paysal",StringComparison.OrdinalIgnoreCase))
                {
                    qry += ",(select E_JoinDate from Employee where EmpId=e.Empid) as 'Join Date'";
                }
                qry += " FROM Employee_set_salary AS e";

                if(str.Equals("paysal",StringComparison.OrdinalIgnoreCase))
                {
                    qry+= " where e.E_Salary!= 0";
                }
                
                using (SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }


        public static int UpdateEmployee_salary(EmployeeEntity e)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Employee_set_salary set E_Salary=@sal where Empid=@id";
                    cmd.Parameters.AddWithValue("@sal", e.salary);
                    cmd.Parameters.AddWithValue("@id", e.empid);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public static DataTable paySal_dgv()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadEmp_Sal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static int paySalary(EmployeeEntity ee)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("PaySalary", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ee.empid);
                    cmd.Parameters.AddWithValue("@month", ee.month);
                    cmd.Parameters.AddWithValue("@dt", ee.paymentdate);
                    conn.Open();

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable viewsalary()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("salaryGridView", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

    }
}

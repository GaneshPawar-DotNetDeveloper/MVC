using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudMVC.Models
{
    public class sqlhelper
    {
        public List<student> StudentDetail()
        {
            List<student> student = new List<student>();
            string cs = "server=DESKTOP-KVGH71D;database=ADONETB15;integrated security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand com = new SqlCommand("usp_showStudentData", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader read = com.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    student s = new student();
                    s.RollNumber = (int)read["RollNumber"];
                    s.Name = read["Name"].ToString();
                    s.Email = read["Email"].ToString();
                    s.DOB = (DateTime)read["DOB"];

                    student.Add(s);
                }
            }
            con.Close();
            return student;

        }

        public bool StudentInsert(student student)
        {
            try
            {
                string cs = "server=DESKTOP-KVGH71D;database=ADONETB15;integrated security=true";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand com = new SqlCommand("usp_InsertStudent", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", student.Name);
                com.Parameters.AddWithValue("@Email", student.Email);
                com.Parameters.AddWithValue("@DOB", student.DOB);
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool DeleteRecord(student s)
        {
            try
            {
                string cs = "server=DESKTOP-KVGH71D;database=ADONETB15;integrated security=true";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand com = new SqlCommand("usp_DeleteData", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RollNumber", s.RollNumber);
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool GetRollNumber(student s, out int StudentRollNumber)
        {
            try
            {
                string cs = "server=DESKTOP-KVGH71D;database=ADONETB15;integrated security=true";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand com = new SqlCommand("usp_GetRollNumber", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", s.Name);
                com.Parameters.AddWithValue("@Email", s.Email);
                com.Parameters.AddWithValue("@DOB", s.DOB);
                SqlParameter RollNumber = new SqlParameter();
                RollNumber.ParameterName = "@RollNumber";
                RollNumber.SqlDbType = System.Data.SqlDbType.Int;
                RollNumber.Direction = System.Data.ParameterDirection.Output;
                com.Parameters.Add(RollNumber);
                com.ExecuteNonQuery();
                con.Close();
                StudentRollNumber = (int)RollNumber.Value;
                return true;
            }
            catch (Exception)
            {
                StudentRollNumber = 0;
                return false;
            }

        }
    }
}
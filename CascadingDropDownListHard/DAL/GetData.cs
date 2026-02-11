using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAL
{
    public class GetData
    {
        public DataTable GetCountry()
        {

            using (SqlConnection con = new SqlConnection(GetConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spReadCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
        }
        public DataTable GetState(int CountyId)
        {
            using (SqlConnection con = new SqlConnection(GetConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spReadState", con);
                cmd.Parameters.AddWithValue("@CountryId", CountyId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable(); 
                dt.Load(rdr);
                return dt;
            }
        }
        public DataTable GetCity(int StateId)
        {
            using (SqlConnection con = new SqlConnection(GetConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spReadCity", con);
                cmd.Parameters.AddWithValue("@StateID", StateId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
        }
    }
}

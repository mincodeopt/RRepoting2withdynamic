using RDLCDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace RDLCDemo.DAL
{
    public class DALPosts
    {
        //public List<PostDetail> GetPostList(DateTime? From, DateTime? To, string name, int? GenderId)
        //{
        //    ////for alert purpose  
        //    //if (From > To)
        //    //{
        //    //    TempData["SelectOption"] = 1;
        //    //}
        //    ////for alert purpose  
        //    List<PostDetail> userlist = new List<PostDetail>();
        //    DataSet ds = new DataSet();
        //    string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("spPostsFilter2", con)) //stored procedure name  
        //        {
        //            con.Open();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            //cmd.Parameters.AddWithValue("@status", "GET"); //Parameters for filter records  
        //            cmd.Parameters.AddWithValue("@name", name);
        //            cmd.Parameters.AddWithValue("@Fromdate", From);
        //            cmd.Parameters.AddWithValue("@Todate", To);
        //            cmd.Parameters.AddWithValue("@GenderId", GenderId);

        //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //            sda.Fill(ds);
        //        }
        //        con.Close();
        //    }
        //    return userlist; 
        //}
        public List<PostDetail> GetPostList(string from, string to, string name, int? genderId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("spPostsFilter2", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fromdate", SqlDbType.DateTime).Value = from; //"2000-5-10"
            cmd.Parameters.AddWithValue("@Todate", SqlDbType.DateTime).Value =  to; //"2001-5-10"
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = name;//"re"
            cmd.Parameters.AddWithValue("@GenderId", SqlDbType.Int).Value = genderId;//1

            //cmd.Parameters.Add("@Fromdate", SqlDbType.DateTime);
            //cmd.Parameters.Add("@Todate", SqlDbType.DateTime);
            //cmd.Parameters["@Fromdate"].Value = Convert.ToDateTime(from);
            //cmd.Parameters["@Todate"].Value = Convert.ToDateTime(to);
            //cmd.Parameters.AddWithValue("@Name", name);
            //cmd.Parameters.AddWithValue("@GenderId", genderId);
            var reader = cmd.ExecuteReader();
            List<PostDetail> allPosts = new List<PostDetail>();
            while (reader.Read())
            {
                allPosts.Add(new PostDetail()
                {
                    PostName = reader["PostName"].ToString(),
                    catName = reader["catName"].ToString(),
                    vch_GenderName = reader["vch_GenderName"].ToString(),
                    fromdt = Convert.ToDateTime(reader["fromdt"])

                });
            }

            return allPosts;

        }
    }
}
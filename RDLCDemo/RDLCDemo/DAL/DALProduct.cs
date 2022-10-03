using RDLCDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RDLCDemo.DAL
{
    public class DALProduct
    {
        public DALProduct()
        {

        }
        public List<ProductDTO> GetAllProducts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand("spGetAlltblProducts", conn);
            var reader = command.ExecuteReader(System.Data.CommandBehavior.Default);
            List<ProductDTO> allProducts = new List<ProductDTO>();
            while (reader.Read())
            {
                allProducts.Add(new ProductDTO()
                {
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"])
                });
            }

            return allProducts;
        }
        public List<ProductDTO> GetProductsByFilter(string name, decimal price)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM tblProducts WHERE Name = @Name and Price = @Price", conn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            var reader = command.ExecuteReader(System.Data.CommandBehavior.Default);
            List<ProductDTO> allProducts = new List<ProductDTO>();
            while (reader.Read())
            {
                allProducts.Add(new ProductDTO()
                {
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"])
                });
            }

            return allProducts;
        }
        //public List<ProductDTO> GetProductsByName2(string name)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblProducts WHERE Name = @Name OR @Name = ''"))
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                cmd.Parameters.AddWithValue("@Name", name);
        //                using (ProductsDs dsProducts = new ProductsDs())
        //                {
        //                    sda.Fill(dsProducts, "DataTable1");
        //                    return dsProducts;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
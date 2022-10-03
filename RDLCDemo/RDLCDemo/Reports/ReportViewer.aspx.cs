using Microsoft.Reporting.WebForms;
using RDLCDemo.DAL;
using RDLCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDLCDemo.Reports
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var lstData = new List<ProductDTO>();
                var productsDAL = new DALProduct();

                lstData = productsDAL.GetAllProducts();
                var datasource = new ReportDataSource("DataSet1", lstData);
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("ProductsReport.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);

            }

        }

        private void BindRDLCReport()
        {
            var lstData = new List<ProductDTO>();
            var productsDAL = new DALProduct();
            var name = this.DropDownList1.SelectedItem.Value;
            var price = decimal.Parse(this.Price.Text);
            lstData = productsDAL.GetProductsByFilter(name,price);

            var datasource = new ReportDataSource("DataSet1", lstData);
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("ProductsReport.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }

        protected void Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindRDLCReport();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "")
            {
                Label1.Text = "Please Select a City";
            }
            else
                this.BindRDLCReport();
            //Label1.Text = "Your Choice is: " + DropDownList1.SelectedValue;
        }

        protected void posts_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
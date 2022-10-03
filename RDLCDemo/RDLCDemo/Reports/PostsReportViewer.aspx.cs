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
    public partial class PostsReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindRDLCReport();

            }

        }

        private void BindRDLCReport()
        {
            var lstData = new List<PostDetail>();
            var postDal = new DALPosts();

            var fromDate = from_date.Text;
            var toDate = to_date.Text;
            var postname = post_name.Text;
            var genderId = int.Parse(genderDropDown.SelectedItem.Value);
            lstData = postDal.GetPostList(fromDate, toDate,postname,genderId);

            var datasource = new ReportDataSource("DataSet12", lstData);
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("PostsReport.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            //ReportViewer1.RefreshReport();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void posts_Button_Click(object sender, EventArgs e)
        {
            if (genderDropDown.SelectedValue == "")
            {
                Label1.Text = "Please Select Gender";
            }
            else
                this.BindRDLCReport();
              
        }
    }
}
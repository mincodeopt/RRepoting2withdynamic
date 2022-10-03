<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostsReportViewer.aspx.cs" Inherits="RDLCDemo.Reports.PostsReportViewer" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
              <p>Select a Brand of Your Choice</p>  
            <div> 
                <asp:Label ID="fromdate" runat="server">From Date</asp:Label>  
                    <asp:TextBox ID="from_date" runat="server" placeholder="From" type="date"></asp:TextBox> 
                <asp:Label ID="todate" runat="server">To Date</asp:Label>  
                    <asp:TextBox ID="to_date" runat="server" placeholder="To" type="date"></asp:TextBox>
                <asp:Label ID="postname" runat="server">Name</asp:Label>  
                    <asp:TextBox ID="post_name" runat="server" ToolTip="Enter price"></asp:TextBox>  
                <asp:Label ID="gender" runat="server">Gender</asp:Label>  
                <asp:DropDownList ID="genderDropDown" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >  
                    <asp:ListItem Value="">Please Select</asp:ListItem>  
                    <asp:ListItem Text="male" Value="1">Male</asp:ListItem>  
                    <asp:ListItem Text="female" Value="2">Female</asp:ListItem>  
                    <asp:ListItem Text="transgender" Value="3">Transgender</asp:ListItem>  
                </asp:DropDownList>  

                <asp:Button ID="postsButton" runat="server" OnClick="posts_Button_Click" Text="Submit" />  
            </div>  

            <br />  
            <br />  
            <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>  
        </div>
        <div>
            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="600px">
                <LocalReport ReportPath="Reports\PostsReport.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>

        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="RDLCDemo.Reports.ReportViewer" %>

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
                <asp:Label ID="label2" runat="server">Name</asp:Label>  
                <asp:DropDownList ID="DropDownList1" runat="server" >  
                <asp:ListItem Value="">Please Select</asp:ListItem>  
                <asp:ListItem Text="samsung" Value="samsung">samsung</asp:ListItem>  
                <asp:ListItem Text="walton" Value="walton">walton</asp:ListItem>  
                <asp:ListItem Text="LG" Value="LG"></asp:ListItem>  
                </asp:DropDownList>  
                <asp:Label ID="labelId" runat="server">Price</asp:Label>  
                <asp:TextBox ID="Price" runat="server" ToolTip="Enter price"></asp:TextBox>  
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
            </div>  

            <br />  
            <br />  
            <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>  
        </div>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" Height="600px" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="100%">
                <LocalReport ReportPath="Reports\ProductsReport.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>

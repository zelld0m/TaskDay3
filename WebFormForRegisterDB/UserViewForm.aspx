<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewForm.aspx.cs" Inherits="WebFormForRegisterDB.UserViewForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

       <link href="css/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>User View</h1>

        </div>
    </div>
      
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    <div>
    
    </div>
        <asp:Button ID="Btn_MainMenu" runat="server" OnClick="Btn_MainMenu_Click" Text="Main Menu" Width="187px" />
    </form>
</body>
</html>

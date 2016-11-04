<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebFormForRegisterDB._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 488px;
        }
        .auto-style3 {
            width: 488px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>Main MENU</h1>

        </div>
    </div>
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">USERNAME</td>
                <td class="auto-style4">PASSWORD</td>
            </tr>
            <tr>
                <td class="auto-style2">
    
                    <asp:TextBox ID="tb_UserName" runat="server"></asp:TextBox>
    
                </td>
                <td>
                    <asp:TextBox ID="Tb_Password" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
    
        <asp:Button ID="Btn_Admin" runat="server" OnClick="Btn_ViewALL_Click" Text="Login" style="width: 55px" />
    
                </td>
                <td>
                    <asp:Button ID="Btn_UserView" runat="server" OnClick="Btn_UserOnly" Text="View" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

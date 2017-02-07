<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteForm2.aspx.cs" Inherits="WebFormForRegisterDB.DeleteForm2" %>

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
            width: 396px;
        }
        .auto-style8 {
            width: 298px;
        }
        .auto-style11 {
            width: 261px;
        }
        .auto-style12 {
            width: 72px;
        }
        .auto-style13 {
            width: 331px;
        }
        .auto-style14 {
            margin-left: 477px;
        }
        .auto-style15 {
            margin-left: 302px;
        }
        .auto-style17 {
            width: 290px;
        }
        .auto-style18 {
            width: 302px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>DELETE FORM</h1>

        </div>
    </div>

    
    </div>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Button ID="Btn_AdminForm" runat="server" OnClick="Btn_AdminForm_Click" Text="Admin Form" CssClass="auto-style14" Width="113px" />
                </td>
                <td>
                    <asp:Button ID="Btn_Logout" runat="server" OnClick="Btn_Logout_Click" Text="Logout" />
                </td>
            </tr>
            </table>
    
        <p>
            <table class="nav-justified">
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style15" Width="373px">
            </asp:GridView>
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">INPUT ID TO DELETE ENTRY</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Tb_Delete" runat="server" Width="284px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Btn_Delete" runat="server" OnClick="Btn_Delete_Click" Text="Delete" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

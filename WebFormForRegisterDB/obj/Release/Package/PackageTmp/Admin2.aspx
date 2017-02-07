<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin2.aspx.cs" Inherits="WebFormForRegisterDB.Admin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

       <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style12 {
            width: 346px;
        }
        .auto-style10 {
            width: 399px;
        }
        .auto-style11 {
            width: 313px;
        }
        .auto-style13 {
            width: 673px;
        }
        .auto-style8 {
            width: 689px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style16 {
            height: 30px;
        }
        .auto-style17 {
            width: 285px;
        }
        .auto-style18 {
            width: 186px;
        }
        .auto-style19 {
            width: 293px;
        }
        .auto-style20 {
            width: 178px;
        }
        .auto-style21 {
            margin-left: 104;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>AuthorityLevel:
            <asp:Label ID="_lblAccessLvl" runat="server" Text="Label"></asp:Label>
            </h1>
        </div>
    </div>
    
    </div>
    <div>
    
        &nbsp;<table class="auto-style1">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                        <asp:Button ID="Btn_Logout" runat="server" OnClick="Btn_Menu_Click" Style="height: 26px" Text="Logout" />
                    </td>
            </tr>
            <tr>
                <td colspan="7">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <table class="nav-justified">
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style18">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="187px">
        </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;
        <br />
        <p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style19">
                        <asp:Button ID="Btn_ToRegister" runat="server" OnClick="Btn_ToRegister_Click" Text=" Register Form" Width="217px" />
                    </td>
                    <td class="auto-style20">
                        <asp:Button ID="Btn_UpdateForm" runat="server" CssClass="auto-style14" OnClick="Btn_UpdateForm_Click" Text="Update Form" Width="140px" />
                    </td>
                    <td>
                        <asp:Button ID="Btn_DeleteForm" runat="server" OnClick="Btn_DeleteForm_Click" Text="Delete Form" Width="188px" CssClass="auto-style21" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16" colspan="3">
                        &nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateForm.aspx.cs" Inherits="WebFormForRegisterDB.UpdateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

       <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style9 {
            width: 129px;
        }
        .auto-style3 {
            width: 238px;
        }
        .auto-style10 {
            height: 23px;
            width: 129px;
        }
        .auto-style4 {
            height: 23px;
            width: 238px;
        }
        .auto-style11 {
            width: 202px;
        }
        .auto-style14 {
            width: 720px;
        }
        .auto-style15 {
            width: 653px;
        }
        .auto-style17 {
            width: 1116px;
        }
        .auto-style18 {
            width: 840px;
        }
        .auto-style19 {
            width: 786px;
        }
        .auto-style20 {
            width: 202px;
            height: 22px;
        }
        .auto-style21 {
            height: 22px;
        }
        .auto-style22 {
            margin-left: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>Update Form</h1>

        </div>
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style18" rowspan="7">&nbsp;</td>
                <td class="auto-style17" rowspan="7">&nbsp;</td>
                <td class="auto-style19" rowspan="7">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="auto-style22">
        </asp:GridView>
    
                </td>
                <td class="auto-style14" rowspan="7">&nbsp;</td>
                <td class="auto-style15" rowspan="7">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Button ID="Btn_Back" runat="server" OnClick="Btn_Back_Click" Text="Admin Form" Width="94px" />
                </td>
                <td>
                    <asp:Button ID="Btn_Menu" runat="server" OnClick="Btn_Menu_Click" Text="LogOut" />
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                </td>
                <td class="auto-style21">
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">INPUT ID TO UPDATE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Tb_IDtoUpdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">LastName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Tb_LastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">FirstName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Tb_Fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">UserName</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Tb_UserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Tb_Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Tb_Address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">City</td>
                <td class="auto-style4">
                    <asp:TextBox ID="Tb_City" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Authority</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Admin"></asp:ListItem>
                        <asp:ListItem Value="User"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

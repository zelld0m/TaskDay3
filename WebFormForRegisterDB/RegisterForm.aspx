<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="WebFormForRegisterDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 82%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 238px;
        }
        .auto-style4 {
            height: 23px;
            width: 238px;
        }
        .auto-style5 {
            margin-left: 120px;
        }
        .auto-style7 {
            width: 541px;
            margin-left: 120px;
        }
        .auto-style8 {
            width: 89%;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 644px;
            margin-left: 120px;
        }
        .auto-style12 {
            width: 159px;
        }
        .auto-style14 {
            width: 108px;
        }
        .auto-style18 {
            width: 147px;
        }
        .auto-style19 {
            height: 20px;
        }
        .auto-style20 {
            width: 386px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class =" container-fluid">
        <div class ="jumbotron" style="border:1px solid #888 ; box-shadow: 0px 2px 5px #ccc;">
            <h1>Registration</h1>

        </div>
    </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="auto-style9">
            <tr>
                <td class="auto-style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style18" rowspan="2">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Btn_AdminForm" runat="server" OnClick="Button1_Click1" Text="Admin_Form" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Log out" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style20">
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">LastName</td>
                <td>
                    <asp:TextBox ID="Tb_Lname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">FirstName</td>
                <td>
                    <asp:TextBox ID="Tb_FName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">UserName</td>
                <td>
                    <asp:TextBox ID="Tb_UserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td>
                    <asp:TextBox ID="Tb_Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Address</td>
                <td>
                    <asp:TextBox ID="Tb_Address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><table class="auto-style9">
                    <tr>
                        <td>Authority Name<table class="nav-justified">
                            <tr>
                                <td class="auto-style19">Access Level</td>
                            </tr>
                            <tr>
                                <td class="auto-style19"></td>
                            </tr>
                            </table>
                        </td>
                    </tr>
                    </table>
                </td>
                <td class="auto-style2">
                    <table class="nav-justified">
                        <tr>
                            <td>
                                <asp:TextBox ID="Tb_AuthorityName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="129px">
                                    <asp:ListItem Value="1"></asp:ListItem>
                                    <asp:ListItem Value="2"></asp:ListItem>
                                    <asp:ListItem Value="3"></asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem Selected="True" Value="5"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style9">
                        <tr>
                            <td class="auto-style14">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table class="auto-style8">
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btn_Register" runat="server" Text="SAVE" OnClick="Button1_Click" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

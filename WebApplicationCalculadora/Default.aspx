<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationCalculadora.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0">
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="TextBoxExpresionAritmetica" Text="" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonAbrirParentesis"  runat="server" Text="(" OnClick="ButtonAbrirParentesis_Click"/>
                </td>
                <td>
                    <asp:Button ID="ButtonCerrarParentesis" runat="server" Text=")" OnClick="ButtonCerrarParentesis_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonPorcentaje" runat="server" Text="%" OnClick="ButtonPorcentaje_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonBorrar" runat="server" Text="Delete" OnClick="ButtonBorrar_Click" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" Text="7" OnClick="Button7_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="ButtonDividir" runat="server" Text="/" OnClick="ButtonDividir_Click" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="ButtonMultiplicar" runat="server" Text="*" OnClick="ButtonMultiplicar_Click" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="ButtonRestar" runat="server" Text="-" OnClick="ButtonRestar_Click" />
                </td>
            </tr>
              <tr>
                <td>
                    <asp:Button ID="Button0" runat="server" Text="0" OnClick="Button0_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="ButtonPunto" runat="server" Text="." OnClick="ButtonPunto_Click" BackColor="#FFD9C6" />
                </td>
                <td>
                    <asp:Button ID="ButtonIgual" runat="server" Text="=" OnClick="ButtonIgual_Click" BackColor="#3399FF" />
                </td>
                <td>
                    <asp:Button ID="ButtonSumar" runat="server" Text="+" OnClick="ButtonSumar_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

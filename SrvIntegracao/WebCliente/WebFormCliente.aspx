<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCliente.aspx.cs" Inherits="WebCliente.WebFormCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelCPF" runat="server" Text="CPF:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCPF" runat="server" MaxLength="11" Width="179px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelNome" runat="server" Text="Nome:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxNome" runat="server" MaxLength="50" Width="342px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelTelefoneResidencial" runat="server" 
            Text="Telefone Residencial:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxTelefoneResidencial" runat="server" MaxLength="10" 
            Width="173px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelEndereco" runat="server" Text="Endereço:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxEndereco" runat="server" MaxLength="50" Width="338px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelDataNascimento" runat="server" Text="Data de Nascimento:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxDataNascimento" runat="server" MaxLength="10"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelNumeroCelular" runat="server" Text="Número do Celular:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxNumeroCelular" runat="server" MaxLength="10"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelMensagem" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonPesquisar" runat="server" onclick="ButtonPesquisar_Click" 
            Text="Pesquisar" />
        <asp:Button ID="ButtonAtualizar" runat="server" onclick="ButtonAtualizar_Click" 
            Text="Atualizar Registro" />
    
    </div>
    </form>
</body>
</html>

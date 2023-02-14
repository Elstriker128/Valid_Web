<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forma1.aspx.cs" Inherits="ValidWeb.Forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Tournament attendee registration:
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <p>
            Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is essential" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Surname: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Surname is essential" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            School&#39;s name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="School's name is essential" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Age:<asp:DropDownList ID="DropDownList1" runat="server"> </asp:DropDownList>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Age is essential" ForeColor="Red" MaximumValue="25" MinimumValue="14" Type="Integer">*</asp:RangeValidator>
        </p>
        <p>
            Programming language:<asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="title" DataValueField="title" ></asp:CheckBoxList>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/kalbos.xml"></asp:XmlDataSource>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Register!" OnClick="Button1_Click" />
        <br />
        <br /> 
        <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" GridLines="Both">
        </asp:Table>
        <br />
        Participant count:
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Delete registrations!" OnClick="Button2_Click" CausesValidation="false"/>
        </p>
    </form>
</body>
</html>

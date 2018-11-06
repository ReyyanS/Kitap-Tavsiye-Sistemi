<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KitapDetay.aspx.cs" Inherits="KitapTavsiyeSistemi1.KitapDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            color: #FF9900;
        }
        .auto-style6 {
            width: 100%;
            margin-bottom: 0px;
        }
    .auto-style7 {
        font-size: large;
        color: #EA8C00;
    }
    .auto-style8 {
        color: #669900;
    }
    .auto-style9 {
        font-size: large;
        color: #990099;
    }
        .auto-style10 {
            font-size: medium;
        }
        .auto-style11 {
            font-size: medium;
            color: #990099;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="Label" style="font-size: xx-large; color: #669900;"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" />
    </p>
    <p>
        <span class="auto-style4"><span class="auto-style5">Yazar</span> </span>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelYazar" runat="server" style="font-size: x-large; color: #000000" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;Yayınevi&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelYayinevi" runat="server" style="font-size: large; color: #000000" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="LabelTanitim" runat="server" style="color: #000000" Text="Label"></asp:Label>
    </p>
    <p>
        Puan&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Puan") %>' style="font-weight: 700; color: #FF0000; font-size: x-large;"></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </p>
    <p class="auto-style7">
        Incelemeler</p>
    <p>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td style="border-bottom-style: groove; border-bottom-width: thin; border-bottom-color: #CC3300">
                            <asp:Label ID="LabelInceleme" runat="server" style="color: #000000" Text='<%# Eval("Incelemeler") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>
    <p>
        Alıntılar</p>
    <p style="width: 186px">
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" style="color: #000000">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p class="auto-style8">
        <strong>___________________________________________________________________________</strong></p>
    <p class="auto-style9">
        <strong>Puan Ver </strong></p>
<p>
        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#EBF4E3">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonPuan" runat="server" Text="Puan Ver" OnClick="ButtonPuan_Click" />
</p>
<p>
        ___________________________________________________________________________</p>
<p class="auto-style9">
        <strong>İnceleme Yaz</strong></p>
<p class="auto-style9">
        <asp:TextBox ID="TextBoxInceleme" runat="server" Height="121px" TextMode="MultiLine" Width="259px" BackColor="#EBF4E3" ForeColor="Black"></asp:TextBox>
    
&nbsp;
        <asp:Button ID="ButtonInceleme" runat="server" Text="Ekle" OnClick="ButtonInceleme_Click" />
</p>
<p class="auto-style9">
        ___________________________________________________________________</p>
<p class="auto-style9">
        <strong>Alıntı Yap</strong></p>
    <p class="auto-style9">
        &nbsp;<span class="auto-style10">Sayfa No:</span>
        <asp:TextBox ID="TextBoxSayfa" runat="server" BackColor="#EBF4E3" ForeColor="Black" Width="44px"></asp:TextBox>
    </p>
    <p class="auto-style11">
        Cümle:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxCumle" runat="server" BackColor="#EBF4E3" ForeColor="Black" Height="66px" TextMode="MultiLine" Width="194px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Ekle" OnClick="Button1_Click" />
    </p>
<p class="auto-style9">
        &nbsp;</p>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.IEnumerable<MvcSampleApp1.Models.Kontakt>>" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Kontaktliste
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kontakte</h2>
	<table>
	<tr>
	<th>Name</th>
	<th>Ort</th>
	</tr>
	<% foreach (var kontakt in Model)
{
  %>
	<tr>
	<td><%=kontakt.Name %></td>
	<td><%=kontakt.Ort %></td>
	</tr>
  <%
} %>
	</table>
</asp:Content>

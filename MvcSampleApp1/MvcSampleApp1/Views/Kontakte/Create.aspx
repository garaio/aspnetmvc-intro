<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcSampleApp1.Models.Kontakt>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="HeadContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
<% using(Html.BeginForm()) { %>
<table>
<tr>
<th><%=Html.LabelFor(m => m.Name) %></th>
<td><%=Html.EditorFor(m => m.Name)%> <%=Html.ValidationMessageFor(m => m.Name)%></td>
</tr>
<tr>
<th><%=Html.LabelFor(m => m.Vorname) %></th>
<td><%=Html.EditorFor(m => m.Vorname) %> <%=Html.ValidationMessageFor(m => m.Vorname) %></td>
</tr>
<tr>
<th><%=Html.LabelFor(m => m.Strasse) %></th>
<td><%=Html.EditorFor(m => m.Strasse) %> <%=Html.ValidationMessageFor(m => m.Strasse) %></td>
</tr>
<tr>
<th><%=Html.LabelFor(m => m.PLZ) %></th>
<td><%=Html.EditorFor(m => m.PLZ) %> <%=Html.ValidationMessageFor(m => m.PLZ) %></td>
</tr>
<tr>
<th><%=Html.LabelFor(m => m.Ort) %></th>
<td><%=Html.EditorFor(m => m.Ort) %> <%=Html.ValidationMessageFor(m => m.Ort) %></td>
</tr>
<tr>
<th><%=Html.LabelFor(m => m.Land) %></th>
<td><%=Html.EditorFor(m => m.Land) %> <%=Html.ValidationMessageFor(m => m.Land) %></td>
</tr>
</table>
<input type="submit" value="Speichern" />
<% } %>
</asp:Content>

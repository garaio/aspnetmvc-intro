<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcSampleApp1.Models.Kontakt>" %>
<table>
<tr>
<th>Name:</th>
<td><%=Model.Name %></td>
</tr>
<tr>
<th>Vorname:</th>
<td><%=Model.Vorname%></td>
</tr>
<tr>
<th>Adresse:</th>
<td><%=Model.Strasse%></td>
</tr>
<tr>
<th>PLZ:</th>
<td><%=Model.PLZ %></td>
</tr>
<tr>
<th>Ort:</th>
<td><%=Model.Ort %></td>
</tr>
<tr>
<th>Land:</th>
<td><%=Model.Land %></td>
</tr>
</table>

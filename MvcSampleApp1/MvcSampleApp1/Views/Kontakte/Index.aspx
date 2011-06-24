<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.IEnumerable<MvcSampleApp1.Models.Kontakt>>" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Kontaktliste
</asp:Content>

<asp:Content ID="aboutHead" ContentPlaceHolderID="HeadContent" runat="server">
	<link rel="Stylesheet" href="../../Scripts/fancybox/jquery.fancybox-1.3.4.css" />
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
	<script src="../../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
	<script src="../../Scripts/fancybox/jquery.fancybox-1.3.4.js" type="text/javascript"></script>

    <h2>Kontakte</h2>
	<table>
	<tr>
	<th>Name</th>
	<th>Ort</th>
	<th>Aktionen</th>
	</tr>
	<%
		int index = 0;
		foreach (var kontakt in Model)
		{
			  %>
				<tr>
				<td><%=kontakt.Name %></td>
				<td><%=kontakt.Ort %></td>
				<td><%=Html.ActionLink("Details", "Details", new { id = index}, new { @class = "ajaxPopupLink"}) %></td>
				</tr>
			  <%
			index++;
		} %>
	</table>

	<script type="text/javascript">
		$(document).ready(function () {
			$(".ajaxPopupLink").fancybox();
		});
	</script>
</asp:Content>

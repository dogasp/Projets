<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendrier.aspx.cs" Inherits="Site_classe.Calendrier" %>
<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calendrier</title>
    <link rel="icon" type="image/png" href="icone.png" />
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="z-index: 1; left: 100%; top: 0; position: absolute; height: 100%; width: 456%">

        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="#333333" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="100%" 
            NextPrevFormat="FullMonth" ondayrender="Calendar1_DayRender" Width="100%">

            <SelectedDayStyle BackColor="#CCCCCC" ForeColor="White" />
            <TodayDayStyle BackColor="#20B2CC" />
            <OtherMonthDayStyle ForeColor="#D7D7D7" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" VerticalAlign="Bottom" />

            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="2px" 
                Font-Bold="True" Font-Size="12pt" ForeColor="black" />
        </asp:Calendar>
    
    </div>
    </form>

    <nav>
            <ul>
                <li><a href="Index.aspx">Principal</a></li>
                <li><a href="Minuteur.aspx">Timer</a></li>
                <li><a href="Devoirs.aspx">Devoirs</a></li>
                <li><a class="active" href="Calendrier.aspx">Calendrier</a></li>
                <li><a href="Liens.aspx">Liens</a></li>
                <li><a href="Mails.aspx">Mails</a></li>
                <li><a href="About.aspx">A propos</a></li>
            </ul>
    </nav>

    <footer>
        <p>Site codé et designé par Dorian</p>
    </footer>

    <header>
        <p>Site de la classe TS2</p>
        <img alt="" src="ts2.png" style="height: 100%; width: 18%;" /></header>
    </body>
</html>

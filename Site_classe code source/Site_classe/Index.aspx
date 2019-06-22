<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site_classe.WebForm1" %>
<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Principale</title>
    <link rel="icon" type="image/png" href="icone.png" />
    <link rel="stylesheet" href="./style.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="heure" runat="server" ForeColor="White" style="z-index: 2; left: 483%; top: -10%; position: absolute; height: 3%; width: 58%; margin-right: 0px" Text=""></asp:Label>
    </form>

        <p style="width: 45%; position: absolute; top: 30%; height: 26%; text-align: left; z-index: 1; left: 34%; font-size: 150%; text-align: justify; margin-bottom: 0px; margin-top: 0px;">
          Sur ce site vous trouverez des informations utiles a propos
          des différents mails des professeurs, de l'administration et des délégués.
            <br />
            <br />
            Vous trouverez des dates importantes comme les bacs blancs
          ou les dates d'anniversaire. 
            <br />
            <br />
            Il y a aussi un timer afin
          de faire un décompte avant les prochaines vacances. 
            <br />
            <br />
            Et le plus important, les devoirs à faire pour la semaine car le système d&#39;école directe ne fonctionne pas très bien.</p>

    <nav>
            <ul>
                <li><a class="active" href="Index.aspx">Principal</a></li>
                <li><a href="Minuteur.aspx">Timer</a></li>
                <li><a href="Devoirs.aspx">Devoirs</a></li>
                <li><a href="Calendrier.aspx">Calendrier</a></li>
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

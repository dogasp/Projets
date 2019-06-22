<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Site_classe.about" %>
<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>A Propos</title>
    <link rel="icon" type="image/png" href="icone.png" />
    <link rel="stylesheet" href="style.css" />
</head>

<body>

    <form id="form1" runat="server">

    </form>
        <p style="width: 39%; position: absolute; top: 15%; height: 18%; text-align: left; z-index: 1; left: 25%; font-size: larger; text-align: justify; margin-bottom: 0px;">
            Merci de me rapporter tout les problèmes rencontrés lors de l'utilisation du site<br/><br/>
            codeur: Dorian GASPAR (06.52.57.19.95)<br/><br/>
            aide graphisme: Yann LACROIX<br/>
            <br />
            <br />
            Version du site: V1.6</p>

        <p style="width: 22%; z-index: 1; left: 25%; top: 45%; position: absolute; height: 3%; margin-bottom: 0px; font-size: larger">

            Rejoindre le discord: <a style="text-decoration: none; color: #20B2CC; " href="https://discord.gg/HTyYPnt">https://discord.gg/HTyYPnt</a> </p>

    <nav>
            <ul>
                <li><a href="Index.aspx">Principal</a></li>
                <li><a href="Minuteur.aspx">Timer</a></li>
                <li><a href="Devoirs.aspx">Devoirs</a></li>
                <li><a href="Calendrier.aspx">Calendrier</a></li>
                <li><a href="Liens.aspx">Liens</a></li>
                <li><a href="Mails.aspx">Mails</a></li>
                <li><a class="active" href="About.aspx">A propos</a></li>
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
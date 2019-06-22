<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Devoirs.aspx.cs" Inherits="Site_classe.Devoirs" %>
<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Devoirs</title>
    <link rel="icon" type="image/png" href="icone.png" />
    <link rel="stylesheet" href="style.css" />
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 90%; height: 100%; z-index: 1; left: 457%; top: 0%; position: absolute; padding:0 0 0 10px; border-left-style: solid; border-left-color: inherit; border-left-width: 2px;">
        <br />
        Ajouter des devoirs:<br />
        <br />
        Saisir la date:&nbsp;&nbsp;&nbsp;
        <input type="date" id="date" name="trip"  min="2018-09-01" max="2019-07-03" style="font-size: 100%; width: 80%;"/>
        <br />
        <asp:Label ID="errdate" runat="server" style="color:red;"></asp:Label>
        <br />
        <br />
        Sélectionner la matière:&nbsp;&nbsp;&nbsp;<br />
        <select name="matière" size="2" style="height: 23%; font-size: 100%; width: 80%;"><option>Mathématiques</option> <option>Physique</option> <option>SVT</option> <option>Philosophie</option> <option>Histoire-Géographie</option> <option>Allemand LV1</option>
            <option>Allemand LV2</option> <option>Anglais LV1</option> <option>Anglais LV2</option> <option>Espagnol LV2</option> <option>Espagnol LV3</option> <option>Latin</option> <option>ISN</option> <option>sp PC</option>
            </select>
        <br />
        <asp:Label ID="errmat" runat="server" style="color:red;"></asp:Label>
        <br />
        <br />
        Entrez les devoirs pour cette matière:<br />
        <textarea id="textdevoir" cols="20" name="S1" style="font-size: 100%; height: 17%"></textarea><br />
        <asp:Label ID="ertext" runat="server" style="color:red;"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ajouter" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="affdevoirs" runat="server" style="z-index: 1; left: 127%; top: 4%; position: absolute; height: 56%; width: 184%"></asp:Label>
    </form>

    <nav>
            <ul>
                <li><a href="Index.aspx">Principal</a></li>
                <li><a href="Minuteur.aspx">Timer</a></li>
                <li><a class="active" href="Devoirs.aspx">Devoirs</a></li>
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

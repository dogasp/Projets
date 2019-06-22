<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Minuteur.aspx.cs" Inherits="Site_classe.Minuteur" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Minuteur</title>
    <link rel="icon" type="image/png" href="icone.png" />
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 295%; height: 52%; position: absolute; top: 13%; left: 145%; z-index: 2; margin-top: 0; font-size: 110%;">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" ontick="T_Tick" Interval="900">
            </asp:Timer>
        <asp:Chart ID="Chart1" runat="server" style="position: absolute; z-index: 1; left: 629px; top: 24px; height: 410px; width: 459px; margin-top: 0px;" BorderlineColor="Black" BorderlineWidth="2">
            <series>
                <asp:Series Name="Series1" ChartType="Doughnut">
                    <Points>
                        <asp:DataPoint AxisLabel="Maths" YValues="100" />
                    </Points>
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>

            <asp:Label ID="EndLesson" runat="server" style="z-index: 1; left: 167px; top: 140px; position: absolute; height: 22px; width: 332px;">Pas de cours</asp:Label>
            <asp:Label ID="EndDay" runat="server" style="z-index: 1; left: 168px; top: 231px; position: absolute"></asp:Label>
            <asp:Label ID="EndingSchool" runat="server" style="z-index: 1; left: 33px; top: 380px; position: absolute" Text="Ending School"></asp:Label>
            <asp:Label ID="LabelDate" runat="server" style="z-index: 1; left: 135px; top: 35px; position: absolute; height: 22px; width: 466px" Text="Label"></asp:Label>

        </div>
    </form>

    <nav>
            <ul>
                <li><a href="Index.aspx">Principal</a></li>
                <li><a class="active" href="Minuteur.aspx">Timer</a></li>
                <li><a href="Devoirs.aspx">Devoirs</a></li>
                <li><a href="Calendrier.aspx">Calendrier</a></li>
                <li><a href="Liens.aspx">Liens</a></li>
                <li><a href="Mails.aspx">Mails</a></li>
                <li><a href="About.aspx">A propos</a></li>
            </ul>
        </nav>
        

        <div style="width: 31%; position: absolute; top: 15%; height: 2%; text-align: left; z-index: 1; left: 25%; font-size: larger">
            Sur cette page se trouve quelques statistiques sur la fin de l&#39;année</div>
        

    <footer>
        <p>Site codé et designé par Dorian</p>
    </footer>

    <header>
        <p>Site de la classe TS2</p>
        <img alt="" src="ts2.png" style="height: 100%; width: 18%;" /></header>
    </body>
</html>

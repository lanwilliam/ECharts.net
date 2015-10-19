<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="wwb.ECharts.Demo.WebForm3" %>

<%@ Register Assembly="wwb.ECharts" Namespace="wwb.ECharts" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/echarts-all.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:EChartsCtrl ID="EChartsCtrl1" runat="server"></cc1:EChartsCtrl>
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PortfilioNonDematShareReportViewer.aspx.cs" Inherits="UI_ReportViewer_NegativeBalanceCheckReportViewer" Title="Portfolio Non Demat Shares"%>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <CR:CrystalReportViewer ID="CR_PortFolioNonDemateShare"  Height="50px" runat="server" AutoDataBind="true" />
    </div>
    </form>
</body>
</html>
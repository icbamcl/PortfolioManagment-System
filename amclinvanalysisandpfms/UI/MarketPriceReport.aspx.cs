﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class UI_BalancechekReport : System.Web.UI.Page
{
    DropDownList dropDownListObj = new DropDownList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Session.RemoveAll();
            Response.Redirect("../Default.aspx");
        }

    }

    protected void showButton_Click(object sender, EventArgs e)
    {
        DateTime date1 = DateTime.ParseExact(RIssuefromTextBox.Text, "dd/MM/yyyy", null);
        DateTime date2 = DateTime.ParseExact(RIssueToTextBox.Text, "dd/MM/yyyy", null);


        string p1date = Convert.ToDateTime(date1).ToString("dd-MMM-yyyy");
        string p2date = Convert.ToDateTime(date2).ToString("dd-MMM-yyyy");

        Session["Fromdate"] = p1date;
        Session["Todate"] = p2date;
       
        StringBuilder sb = new StringBuilder();

        // ClientScript.RegisterStartupScript(this.GetType(), "ReceivablePayableDSEandCSESeparateReportVeiwer", "window.open('ReportViewer/ReceivablePayableDSEandCSESeparateReportVeiwer.aspx')", true);
        Response.Redirect("ReportViewer/MarketpriceReportVeiwer.aspx");
    }

  
}
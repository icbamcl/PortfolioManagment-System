using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class UI_PortfolioWithNonListedSecurities : System.Web.UI.Page
{
    CommonGateway commonGatewayObj = new CommonGateway();
    DropDownList dropDownListObj = new DropDownList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Session.RemoveAll();
            Response.Redirect("../Default.aspx");
        }
        DataTable dtHowlaDateDropDownList = dropDownListObj.BalanceDateDropDownList();
        DataTable dtFundNameDropDownList = dropDownListObj.FundNameDropDownList();
        if (!IsPostBack)
        {
            fundNameDropDownList.DataSource = dtFundNameDropDownList;
            fundNameDropDownList.DataTextField = "F_NAME";
            fundNameDropDownList.DataValueField = "F_CD";
            fundNameDropDownList.DataBind();
        }

    }

    protected void showButton_Click(object sender, EventArgs e)
    {
       


        string Fromdate = Convert.ToDateTime(RIssuefromTextBox.Text).ToString("dd-MMM-yyyy");
        string Todate = Convert.ToDateTime(RIssueToTextBox.Text).ToString("dd-MMM-yyyy");

        Session["fundCode"] = fundNameDropDownList.SelectedValue.ToString();
        Session["Fromdate"] = Fromdate;
        Session["Todate"] = Todate;

        string fundCode = (string)Session["fundCode"];

        DataTable dtnonlistedDetailsSource = new DataTable();
        StringBuilder sbMst = new StringBuilder();
        StringBuilder sbfilter = new StringBuilder();
        sbfilter.Append(" ");
        sbMst.Append("SELECT * FROM  NON_LISTED_SECURITIES WHERE ");
        sbMst.Append(" (F_CD = " + fundCode + ") AND(INV_DATE = (SELECT     MAX(INV_DATE) AS EXPR1 FROM ");
        sbMst.Append("NON_LISTED_SECURITIES NON_LISTED_SECURITIES_1 WHERE(F_CD = " + fundCode + ")))  ");

        //sbMst.Append(sbfilter.ToString());
        dtnonlistedDetailsSource = commonGatewayObj.Select(sbMst.ToString());

        
        //DateTime dtPREV_MAX_INV_DATE = Convert.ToDateTime(dtnonlistedDetailsSource.Rows[0]["PREV_MAX_INV_DATE"]);
        //string PREV_MAX_INV_DATE = Convert.ToDateTime(dtnonlistedDetailsSource.Rows[0]["PREV_MAX_INV_DATE"]).ToString("dd-MMM-yyyy");
        //DateTime dtFromdate = Convert.ToDateTime(RIssuefromTextBox.Text);
        //DateTime dtTodate = Convert.ToDateTime(RIssueToTextBox.Text);

        //if (dtFromdate  >= dtPREV_MAX_INV_DATE)
        //{

            Response.Redirect("ReportViewer/NonListedSecuritiesDetailsReportViewer.aspx?Fromdate=" + Fromdate + "&Todate=" + Todate + "");
        //}
        //else
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "alert('From date must be greater than or equal to "  + PREV_MAX_INV_DATE + "');", true);
        //}



        //   ClientScript.RegisterStartupScript(this.GetType(), "PortfolioSummaryReportViewer", "window.open('ReportViewer/PortfolioWithNonListedReportViewer.aspx')", true);
      
    }
}

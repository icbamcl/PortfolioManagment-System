using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;

public partial class UI_ReportViewer_PortfolioWithNonListedReportViewer : System.Web.UI.Page
{
    CommonGateway commonGatewayObj = new CommonGateway();
    Pf1s1DAO pf1Obj = new Pf1s1DAO();
    private ReportDocument rdoc = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder sbFilter = new StringBuilder();
        string fundCode = "";
        string Fromdate = "";
        string Todate = "";


        if (Session["UserID"] == null)
        {
            Session.RemoveAll();
            Response.Redirect("../../Default.aspx");
        }
        else
        {
            fundCode = (string)Session["fundCode"];

           Fromdate= (string)Session["Fromdate"];
            Todate = (string)Session["Todate"];
            //  balDate = (string)Session["balDate"];
        }

        DataTable dtnonlistedDetailsSource = new DataTable();
        StringBuilder sbMst = new StringBuilder();
        StringBuilder sbfilter = new StringBuilder();
        sbfilter.Append(" ");
        sbMst.Append("SELECT * FROM  NON_LISTED_SECURITIES WHERE ");
        sbMst.Append(" (F_CD = " + fundCode + ") AND(INV_DATE = (SELECT     MAX(INV_DATE) AS EXPR1 FROM ");
        sbMst.Append("NON_LISTED_SECURITIES NON_LISTED_SECURITIES_1 WHERE(F_CD = " + fundCode + ")))  ");


        //sbMst.Append(sbfilter.ToString());
        dtnonlistedDetailsSource = commonGatewayObj.Select(sbMst.ToString());

        DataTable dtNonlistedSecrities = new DataTable();
        sbMst = new StringBuilder();
        sbMst.Append("select  c.F_CD,c.comp_cd,c.COMP_NM,c.SECT_MAJ_CD,c.amount,c.rate,c.no_shares,c.inv_date,c.entry_by,c.entry_date,c.cat_id,d.CAT_NM  ");
        sbMst.Append("from (select a.F_CD,a.comp_cd,B.COMP_NM,B.SECT_MAJ_CD,a.amount,a.rate,a.no_shares,a.inv_date,a.entry_by,a.entry_date,a.cat_id from ");
        sbMst.Append("(select * from NON_LISTED_SECURITIES_DETAILS  where f_cd='" + fundCode + "' and INV_DATE ");
        sbMst.Append("between  '" + Convert.ToDateTime(Fromdate).ToString("dd-MMM-yyyy") + "' and '" + Convert.ToDateTime(Todate).ToString("dd-MMM-yyyy") + "')   ");
        sbMst.Append("  a inner join COMP_NONLISTED b on a.comp_cd=b.comp_cd) c inner join NONLISTED_CATEGORY d on c.cat_id=D.CAT_ID  order by INV_DATE desc ");
        dtNonlistedSecrities = commonGatewayObj.Select(sbMst.ToString());

        DataTable dtFundName = new DataTable();
        sbMst = new StringBuilder();
        sbMst.Append("SELECT     * from Fund ");
        sbMst.Append("WHERE     F_CD = " + fundCode + " ");
        dtFundName = commonGatewayObj.Select(sbMst.ToString());

        string FundName = "";
        if (dtFundName.Rows.Count > 0)
        {
            FundName = dtFundName.Rows[0]["F_NAME"].ToString();
        }

        if (dtNonlistedSecrities.Rows.Count > 0)
        {

            dtNonlistedSecrities.TableName = "PortfolioWithNonListedReport";
          //  dtNonlistedSecrities.WriteXmlSchema(@"D:\IAMCL_10-7-17\amclpmfs\amclpmfs\UI\ReportViewer\Report\crtNonListedDetailsReport.xsd");
            //ReportDocument rdoc = new ReportDocument();
            string Path = "";
            Path = Server.MapPath("Report/crtNonListedReport.rpt");
            rdoc.Load(Path);
            rdoc.SetDataSource(dtNonlistedSecrities);
            CRV_PfolioWithNonListed.ReportSource = rdoc;
            CRV_PfolioWithNonListed.DisplayToolbar = true;
            CRV_PfolioWithNonListed.HasExportButton = true;
            CRV_PfolioWithNonListed.HasPrintButton = true;
            rdoc.SetParameterValue("FUndName", FundName);

            rdoc = ReportFactory.GetReport(rdoc.GetType());
        }
        else
        {
            Response.Write("No Data Found");
        }
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        CRV_PfolioWithNonListed.Dispose();
        CRV_PfolioWithNonListed = null;
        rdoc.Close();
        rdoc.Dispose();
        rdoc = null;
        GC.Collect();
    }
}

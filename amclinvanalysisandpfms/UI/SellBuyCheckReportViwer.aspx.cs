CListenSocket::CListenSocket(0x009b18f8, 0x0040f304) - entering.
[03/22/2018-14:07:35:751][0000068c] CListenSocket::CListenSocket(0x009b18f8, 0x0040f304) - exiting.
[03/22/2018-14:07:35:767][0000068c] [Debug] m_pListen->Create OK.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::StartListening() - exiting.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::CHttpSvrDoc() - entering.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::StartListening() - entering.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::StopListening() - entering.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::StopListening() - exiting.
[03/22/2018-14:07:35:767][0000068c] CListenSocket::CListenSocket(0x009b69c0, 0x0040f304) - entering.
[03/22/2018-14:07:35:767][0000068c] CListenSocket::CListenSocket(0x009b69c0, 0x0040f304) - exiting.
[03/22/2018-14:07:35:767][0000068c] [Debug] m_pListen->Create OK.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::StartListening() - exiting.
[03/22/2018-14:07:35:767][0000068c] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/22/2018-14:07:35:767][0000066c] service_main() - worker thread initialization success
[03/22/2018-14:07:41:898][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:07:41:898][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:08:00:883][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:08:00:914][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:09:30:505][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:09:30:505][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:15:17:855][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:16:12:081][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:16:12:112][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:16:12:112][0000068c] workerThread() - wait returned due to pending message
[03/22/2018-14:16:12:206][0000068c] workerThread() - wait returned due to pending message
                                                                                                                                                                                                                                                                                                                                                            re vch_dt between '" + Fromdate + "' and '" + Todate + "' and c.comp_cd=t.comp_cd and f.f_cd=t.f_cd order by t.F_CD,t.VCH_DT DESC");
            sbMst.Append(sbfilter.ToString());
            dtReprtSource = commonGatewayObj.Select(sbMst.ToString());
            dtReprtSource.TableName = "SellBuyCheckReport";
            dtReprtSource.WriteXmlSchema(@"D:\IAMCL_10-7-17\amclpmfs\amclpmfs\UI\ReportViewer\Report\CR_SellBuyCheckReport.xsd");
            if (dtReprtSource.Rows.Count > 0)
            {

                string Path = Server.MapPath("Report/CR_SellBuyCheckReport.rpt");
                rdoc.Load(Path);
                rdoc.SetDataSource(dtReprtSource);
                CR_SellBuyCheckReport.ReportSource = rdoc;
                CR_SellBuyCheckReport.DisplayToolbar = true;
                CR_SellBuyCheckReport.HasExportButton = true;
                CR_SellBuyCheckReport.HasPrintButton = true;
                rdoc.SetParameterValue("Fromdate", Fromdate);
                rdoc.SetParameterValue("Todate", Todate);
                rdoc = ReportFactory.GetReport(rdoc.GetType());

            }
            else
            {
                Response.Write("No Data Found");
            }

        }
        else if (fundCode != "0" && companycode == "0" && transtype == "0")
        {
            sbMst.Append("select t.VCH_DT, t.F_CD  , f.f_name fund_name,t.COMP_CD , c.comp_nm,c.comp_nm  || '('|| t.COMP_CD|| ')',t.TRAN_TP , decode ( t.TRAN_TP, 'C', 'Cost','S','Sell','B','Bonus','R','Rightering.
[03/22/2018-14:21:45:112][000006e4] CHttpSvrDoc::StartListening() - entering.
[03/22/2018-14:21:45:112][000006e4] CHttpSvrDoc::StopListening() - entering.
[03/22/2018-14:21:45:112][000006e4] CHttpSvrDoc::StopListening() - exiting.
[03/22/2018-14:21:45:112][000006e4] CListenSocket::CListenSocket(0x007a69c0, 0x0040f304) - entering.
[03/22/2018-14:21:45:112][000006e4] CListenSocket::CListenSocket(0x007a69c0, 0x0040f304) - exiting.
[03/22/2018-14:21:45:112][000006e4] [Debug] m_pListen->Create OK.
[03/22/2018-14:21:45:112][000006e4] CHttpSvrDoc::StartListening() - exiting.
[03/22/2018-14:21:45:112][000006e4] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/22/2018-14:21:45:112][000006b8] service_main() - worker thread initialization success
[03/22/2018-14:21:47:935][000006e4] workerThread() - wait returned due to pending message
[03/22/2018-14:21:47:935][000006e4] workerThread() - wait returned due to pending message
[03/22/2018-14:26:12:153][000006e4] workerThread() - wait returned due to pending message
[03/22/2018-14:26:13:245][000006e4] workerThread() - wait returned due to pending message
[03/22/2018-14:26:13:276][000006e4] workerThread() - wait returned due to pending message

=====================================================================
OracleMTSRecoveryService
3/25/2018 11:41:31
---------------------------------------------------------------------
[03/25/2018-11:41:31:380][000006b4] OracleMTSRecoveryService starting
[03/25/2018-11:41:31:380][000006dc] workerThread() - entering
[03/25/2018-11:41:31:442][000006dc] ai_flags: 0x17 ai_family: 23 ai_socktype: 1 ai_protocol: 6
[03/25/2018-11:41:31:442][000006dc] ai_flags: 0x2 ai_family: 2 ai_socktype: 1 ai_protocol: 6
[03/25/2018-11:41:31:442][000006dc] createHTTPSvrs() - allocated mem for 2 srvrs
[03/25/2018-11:41:31:442][000006dc] CHttpSvrDoc::CHttpSvrDoc() - entering.
[03/25/2018-11:41:31:442][000006dc] CHttpSvrDoc::StartListening() - entering.
[03/25/2018-11:41:31:442][000006dc] CHttpSvrDoc::StopListening() - entering.
[03/25/2018-11:41:31:442][000006dc] CHttpSvrDoc::StopListening() - exiting.
[03/25/2018-11:41:31:442][000006dc] CListenSocket::CListenSocket(0x007718f8, 0x0040f304) - entering.
[03/25/2018-11:41:31:442][000006dc] CListenSocket::CListenSocket(0x007718f8, 0x0040f304) - exiting.
[03/25/2018-11:41:31:458][000006dc] [Debug] m_pListen->Create OK.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::StartListening() - exiting.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::CHttpSvrDoc() - entering.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::StartListening() - entering.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::StopListening() - entering.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::StopListening() - exiting.
[03/25/2018-11:41:31:458][000006dc] CListenSocket::CListenSocket(0x007769c0, 0x0040f304) - entering.
[03/25/2018-11:41:31:458][000006dc] CListenSocket::CListenSocket(0x007769c0, 0x0040f304) - exiting.
[03/25/2018-11:41:31:458][000006dc] [Debug] m_pListen->Create OK.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::StartListening() - exiting.
[03/25/2018-11:41:31:458][000006dc] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/25/2018-11:41:31:458][000006b4] service_main() - worker thread initialization success
[03/25/2018-11:41:39:164][000006dc] workerThread() - wait returned due to pending message
[03/25/2018-11:41:39:164][000006dc] workerThread() - wait returned due to pending message
[03/25/2018-11:45:58:062][000006dc] workerThread() - wait returned due to pending message
[03/25/2018-11:45:59:279][000006dc] workerThread() - wait returned due to pending message
[03/25/2018-11:45:59:295][000006dc] workerThread() - wait returned due to pending message

=====================================================================
OracleMTSRecoveryService
3/25/2018 15:04:31
---------------------------------------------------------------------
[03/25/2018-15:04:31:689][000006b4] OracleMTSRecoveryService starting
[03/25/2018-15:0
=====================================================================
OracleMTSRecoveryService
3/22/2018 14:29:16
---------------------------------------------------------------------
[03/22/2018-14:29:16:562][000006b0] OracleMTSRecoveryService starting
[03/22/2018-14:29:16:594][000006e0] workerThread() - entering
[03/22/2018-14:29:16:609][000006e0] ai_flags: 0x17 ai_family: 23 ai_socktype: 1 ai_protocol: 6
[03/22/2018-14:29:16:609][000006e0] ai_flags: 0x2 ai_family: 2 ai_socktype: 1 ai_protocol: 6
[03/22/2018-14:29:16:609][000006e0] createHTTPSvrs() - allocated mem for 2 srvrs
[03/22/2018-14:29:16:609][000006e0] CHttpSvrDoc::CHttpSvrDoc() - entering.
[03/22/2018-14:29:16:609][000006e0] CHttpSvrDoc::StartListening() - entering.
[03/22/2018-14:29:16:609][000006e0] CHttpSvrDoc::StopListening() - entering.
[03/22/2018-14:29:16:609][000006e0] CHttpSvrDoc::StopListening() - exiting.
[03/22/2018-14:29:16:609][000006e0] CListenSocket::CListenSocket(0x009f18f8, 0x0040f304) - entering.
[03/22/2018-14:29:16:609][000006e0] CListenSocket::CListenSocket(0x009f18f8, 0x0040f304) - exiting.
[03/22/2018-14:29:16:625][000006e0] [Debug] m_pListen->Create OK.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::StartListening() - exiting.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::CHttpSvrDoc() - exiting.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::CHttpSvrDoc() - entering.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::StartListening() - entering.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::StopListening() - entering.
[03/22/2018-14:29:16:625][000006e0] CHttpSvrDoc::StopListening() - exiting.
[03/22/2018-14:29:16:625][000006e0] CListenSocket::CListenSocket(0x009f69c0, 0x0040f304) - entering.
[03/22/2018-14:29:16:625][00
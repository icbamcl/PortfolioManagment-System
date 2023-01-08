<%@ Page Language="C#" MasterPageFile="~/UI/AMCLCommon.master" AutoEventWireup="true" CodeFile="NonListedSecuritiesInvestmentEntryForm.aspx.cs" Inherits="UI_NonListedSecuritiesInvestmentEntryForm" Title="Non Listed Securites (Investment) Entry Page" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="Stylesheet" type="text/css" href="../Scripts/jquery-ui.css"  />
    <link href="../CSS/vendor/bootstrap.min.css" rel="stylesheet" />
    <script  type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <style type="text/css">
        label.error {
            color: red;
            display: inline-flex;
        }

        .style5 {
            height: 24px;
        }

        .style6 {
            height: 14px;
        }
    </style>
     <style type="text/css">
         .Gridview {
             font-family: Verdana;
             font-size: 10pt;
             font-weight: normal;
             color: black;
         }

         .processBtn {
             BORDER-TOP: #CCCCCC 1px solid;
             BORDER-BOTTOM: #000000 1px solid;
             BORDER-LEFT: #CCCCCC 1px solid;
             BORDER-RIGHT: #000000 1px solid;
             COLOR: #FFFFFF;
             FONT-WEIGHT: bold;
             FONT-SIZE: 11px;
             BACKGROUND-COLOR: #547AC6;
             WIDTH: 146px;
             HEIGHT: 35px;
             font-size: 21px;
             border-radius: 25px;
         }
     </style>
     <link href="../CSS/vendor/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true" EnableScriptLocalization="true" ID="ScriptManager1" />

&nbsp;&nbsp;&nbsp;
<table "text-align"="center">
    <tr>
        <td class="FormTitle" align="center">
            NON LISTED SECURITIES (Investment) Details
        </td>           
        <td>
            <br />
        </td>
    </tr> 
</table>
&nbsp;&nbsp;&nbsp;
<table "text-align"="center">
    <tr>
        <td class="" align="center">
              <asp:Label ID="lblerror" runat="server" Text="" Style="font-size: 20px; color: red;"></asp:Label>
           
        </td>           
        <td>
            <br />
        </td>
    </tr> 
</table>


                       
<br />
<table width="750" "text-align"="center" cellpadding="0" cellspacing="0" border="0">
    
    <tr>
        <td align="right" style="font-weight: 700" class="style5"><b>Fund Name:&nbsp; </b></td>
        <td align="left" class="style5" >
            <asp:DropDownList ID="fundNameDropDownList" runat="server" TabIndex="1" OnSelectedIndexChanged="fundNameDropDownList_SelectedIndexChanged"
                AutoPostBack="true"
                 ></asp:DropDownList>
            </td>
    </tr>
     <tr>
        <td align="right" style="font-weight: 700" class="style5"><b>Company Name:&nbsp; </b></td>
        <td align="left" class="style5" >
            <asp:DropDownList ID="nonlistedCompanyDropDownList" OnSelectedIndexChanged="nonlistedCompanyDropDownList_SelectedIndexChanged"  AutoPostBack="true" runat="server" TabIndex="1" ></asp:DropDownList>
            </td>
    </tr>
    <tr>

       
       <%-- <td align="right" style="font-weight: 700" class="style5"><b>Nonlisted Category:</b></td>--%>
         <td align="right" style="font-weight: 700" class="style5"><asp:Label ID="Label2" runat="server" Text="Nonlisted Category:"></asp:Label></td>
        <td align="left">
            <asp:DropDownList ID="nonlistedCategoryDropDownList"  readonly="true" runat="server" TabIndex="8"></asp:DropDownList>

        </td>
    </tr>
    <%-- <tr>
        <td align="right" style="font-weight: 700" class="style5">Date of Purchase:</td>
        <td align="left" class="style5" >
            <asp:TextBox ID="TextBoxDateofPurchase" runat="server" Width="100px"></asp:TextBox>
            </td>
    </tr>--%>
     <tr>
        <td align="right" style="font-weight: 700" class="style5">
            <asp:Label ID="LabelInvestmentDate"  runat="server" Text="Transaction Date:"></asp:Label></td>
        <td align="left" class="style5" >
            <asp:TextBox ID="InvestMentDateTextBox" runat="server" Width="100px"></asp:TextBox>
            </td>
    </tr>
   <tr>

        <td align="right" style="font-weight: 700" class="style5">Transaction Type:</td>
        <td align="left" class="style5" >
            <asp:DropDownList ID="DropDownListTranTP" runat="server" >  
            <asp:ListItem Value="0">Please Select</asp:ListItem>  
            <asp:ListItem Value="B">Buy </asp:ListItem>  
            <asp:ListItem Value="S">Sell</asp:ListItem>   
        </asp:DropDownList>
       </td>
    </tr>
    
    <tr>
        <td align="right" style="font-weight: 700" class="style5"><b>Amount(BDT):&nbsp;</b></td>
        <td align="left" class="style5" >
            <asp:TextBox ID="amountTextBox" runat="server"  style="width:100px;" 
                CssClass="textInputStyleammount" TabIndex="2" OnTextChanged="amountTextBox_TextChanged"  AutoPostBack="true"
                ></asp:TextBox></td>   
        
    </tr>
     <tr>

        
            
        <td align="right" style="font-weight: 700" class="style5"><b>Rate(BDT):&nbsp;</b></td>
        <td align="left" class="style5" >
           <div> 
                <asp:UpdatePanel ID ="updt1" runat ="server" >
              <ContentTemplate >
            <asp:TextBox ID="rateTextBox" runat="server"  AutoPostBack="true"  style="width:100px" OnTextChanged=" rateChange_TextChanged"
                CssClass="textInputStyle" TabIndex="2" 
                ></asp:TextBox>
                   <asp:TextBox ID="noOfShareTextBox" runat="server"  style="width:100px;" AutoPostBack="true"
                CssClass="textInputStyle" TabIndex="2" 
                ></asp:TextBox>
                   </ContentTemplate >
                  
                  
                  </asp:UpdatePanel>
            </div>
                  </td>   
        
    </tr>
   
    
    <tr>
           <td align="left" class="style6" ></td>
    </tr>
    <tr>
        <td align="center" colspan="2" class="style5" >&nbsp;</td>
    </tr>
    <tr>
            <td align="center" colspan="2" >
            <asp:Button ID="saveButton" runat="server" Text="Save" 
                CssClass="buttoncommon" TabIndex="5" 
                     AccessKey="s" onclick="saveButton_Click"  
                    />
                 <asp:Button ID="resetButton" runat="server" Text="Reset" 
                CssClass="buttoncommon" TabIndex="6" onclick="resetButton_Click"/>
                  <asp:Button ID="ButtonDelete" runat="server" Text="Delete" 
                CssClass="buttoncommon" TabIndex="6" onclick="ButtonDelete_Click"  onclientclick="fnDeleteCloseModal();" />
            </td>
          <td align="center" colspan="2" >
            <asp:HiddenField ID="HiddenField2" runat="server" />
            </td>
            
    </tr>
    
</table>



    <script type="text/javascript">


       
   
        $.validator.addMethod("fundDropDownList", function (value, element, param) {  
            if (value == '0')  
                return false;  
            else  
                return true;  
        },"* Please select a Fund");




        $.validator.addMethod("pfoliodatecheck", function (value, element, param) {  
            if (value == '0')  
                return false;  
            else  
                return true;  
        },"* Please select a Date");
 
        $.validator.addMethod("companycheck", function (value, element, param) {  
            if (value == '0')  
                return false;  
            else  
                return true;  
        },"* Please select a Company");

        $.validator.addMethod("CategoryCheck", function (value, element, param) {  
            if (value == '0')  
                return false;  
            else  
                return true;  
        },"* Please select a Category");

        $.validator.addMethod("TransactionTypeCheck", function (value, element, param) {  
            if (value == '0')  
                return false;  
            else  
                return true;  
        },"* Please select a Transaction");

        jQuery.validator.addMethod("Date", function(value, element) { 
            return Date.parseExact(value, "dd/mm/yy");
        });

        $(function () {

            $('#<%=InvestMentDateTextBox.ClientID%>').datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "dd/mm/yy",
                maxDate: 'today',
                onSelect: function(selected) {
                   
                }
            });
      
        });
    
        $("#aspnetForm").validate({
            rules: {
                <%=fundNameDropDownList.UniqueID %>: {
                        
                    //required:true 
                    fundDropDownList:true
                        
                }
               ,
                <%=InvestMentDateTextBox.UniqueID %>: {
                        
                   //required:true 
                   Date:true
                        
               }
               ,
                <%=nonlistedCompanyDropDownList.UniqueID %>: {
                        
                   //required:true 
                   companycheck:true
                        
               }
               ,
                <%=InvestMentDateTextBox.UniqueID %>: {
                        
                   required:true 
                   
                        
               }
               , <%=amountTextBox.UniqueID %>: {
                        
                   required:true ,
                   number:true              
                        
               }
               ,<%=nonlistedCategoryDropDownList.UniqueID %>: {
                        
                   CategoryCheck:true 
                        
               }, <%=rateTextBox.UniqueID %>: {
                        
                   required:true ,
                   number:true              
                        
               }, <%=noOfShareTextBox.UniqueID %>: {
                        
                   required:true ,
                   number:true              
                        
               }, <%=DropDownListTranTP.UniqueID %>: {
                        
                   TransactionTypeCheck:true 
                        
               }
              
            }
        });

    </script>       
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
         
            <table class="table table-hover" style=" border: 1px solid black;" id="bootstrap-table">
                <thead>
                    <tr>
                        <th>Fund code</th>
                        <th>Company Code</th>
                        <th>Company Name</th>
                        <th>Amount</th>
                        <th>Rate</th>
                        <th>No Shares</th>
                        <th>Transaction Date</th>
                        <th>Category Name</th>
                        <th>Transaction Type</th>
                        <th>Action</th>
                       
                    </tr>
                </thead>
                <tbody>
                    <%

                        System.Data.DataTable dtallNonlistedSecurityGrid = (System.Data.DataTable)Session["ALLFundFillNonListedSecuritiesGrid"];
                        if (dtallNonlistedSecurityGrid.Rows.Count > 0)
                        {
                            for (int i = 0; i < dtallNonlistedSecurityGrid.Rows.Count; i++)
                            {
                    %>
                    <tr>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["F_CD"].ToString());   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["COMP_CD"].ToString());   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["COMP_NM"].ToString());   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["AMOUNT"].ToString());   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["RATE"].ToString());   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["NO_SHARES"].ToString());   %> </td>
                        <td><%   Response.Write(Convert.ToDateTime(dtallNonlistedSecurityGrid.Rows[i]["INV_DATE"].ToString()).ToString("dd/MM/yyyy"));   %> </td>
                        <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["CAT_NM"].ToString());   %> </td>
                          <td><%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["TRAN_TP"].ToString());   %> </td>
                        <%--  <td><asp:Button ID="UpdateButton" runat="server" Text="Update"  CssClass="buttoncommon" TabIndex="48" OnClick="UpdateButton_Click" /> </td> --%>
                        <td><a href="NonListedSecuritiesInvestmentEntryForm.aspx?ID=<%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["F_CD"].ToString());   %>&COMP_CD=<%   Response.Write(dtallNonlistedSecurityGrid.Rows[i]["COMP_CD"].ToString());   %>&INV_DATE=<%Response.Write(dtallNonlistedSecurityGrid.Rows[i]["INV_DATE"].ToString());%>&TRAN_TP=<%Response.Write(dtallNonlistedSecurityGrid.Rows[i]["TRAN_TP1"].ToString());%>" 
                            class="custUpdBtn">Select</a></td>
                    </tr>
                    <%

                            }
                        }

                    %>
                 
                </tbody>
            </table>
     <table width="750" "text-align"="center" cellpadding="0" cellspacing="0" border="0">
    
        <tr>
            <td align="right" style="font-weight: 700" class="style5"><asp:Label ID="lblTotalAmmont" visible="false" runat="server" Text="Total Ammount:"></asp:Label></td>
        <td align="left" class="style5" >
            <b> <asp:Label ID="lblsumTotalAmmount"  visible="false" runat="server" Text=""></asp:Label></b>
            </td>
        </tr>
    
    </table>

      <script type="text/javascript">
          $(document).ready(function () {
              $('#bootstrap-table').bdt({

              });
          });

          function fnDeleteCloseModal() {
        
              if (confirm("Are you sure you really want to delete.....?")) {
                  //  $("#HiddenField1").val("Yes");
                  $("#<%=HiddenField2.ClientID%>").val("Yes");
              } else {
                  // $("#HiddenField1").val("No");
                  $("#<%=HiddenField2.ClientID%>").val("No");
              }
          }
    </script>
               
</asp:Content>



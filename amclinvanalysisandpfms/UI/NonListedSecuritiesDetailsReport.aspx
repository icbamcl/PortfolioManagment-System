<%@ Page Language="C#" MasterPageFile="~/UI/AMCLCommon.master" AutoEventWireup="true" CodeFile="NonListedSecuritiesDetailsReport.aspx.cs" Inherits="UI_PortfolioWithNonListedSecurities" Title="Individual Portfolio Statement Report Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type ="text/css" >  
        label.error {             
            color: red;   
            display:inline-flex ;                 
        } 
      
    </style> 
  <script language="javascript" type="text/javascript"> 
      
    
    function fnCheckInput()
    {   
        if(document.getElementById("<%=fundNameDropDownList.ClientID%>").value =="0")
        {
            document.getElementById("<%=fundNameDropDownList.ClientID%>").focus();
            alert("Please Select Fund Name.");
            return false; 
        }
       
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true" EnableScriptLocalization="true" ID="ScriptManager1" />
&nbsp;&nbsp;&nbsp;
<table align ="center">
    <tr>
        <td class="FormTitle" align="center">
             Statement of Investment in Non-Listed Securities Details  Report 
        </td>           
        <td>
            &nbsp;</td>
    </tr> 
</table>
<br />
<table align="center" cellpadding="0" cellspacing="0" border="0">
        <tr>
           <td align="right">
                <b>From Date:</b>
            </td>
            <td align="left">
  
                <asp:TextBox ID="RIssuefromTextBox" runat="server" Width="100px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td align="right">
                <b>To Date:</b>
            </td>
            <td align="left">
                <asp:TextBox ID="RIssueToTextBox" runat="server" Width="100px"></asp:TextBox>
            </td>
        </tr>
    <tr>
        <td align="right" style="font-weight: 700" ><b>Fund Name:&nbsp; </b></td>
        <td align="left" width="200px">
            <asp:DropDownList ID="fundNameDropDownList" runat="server" TabIndex="4"></asp:DropDownList>
        </td>
        
    </tr>
    <tr>
            <td align="center" colspan="2" >
            <asp:Button ID="showButton" runat="server" Text="Show Report" 
                CssClass="buttoncommon" TabIndex="5" OnClientClick=" return fnCheckInput();" onclick="showButton_Click" 
                    />
            
            </td>
            
    </tr>
    <tr>
           <td align="center" colspan="4" >
                &nbsp;
           </td>
    </tr>
</table>
    <script type="text/javascript">
         $(function () {

              $('#<%=RIssuefromTextBox.ClientID%>').datepicker({
                  changeMonth: true,
                  
                 changeYear: true,
                 maxDate:"today",
                 onSelect: function(selected) {
                     $('#<%=RIssueToTextBox.ClientID%>').datepicker("option","minDate", selected)
                 }
             });
             $('#<%=RIssueToTextBox.ClientID%>').datepicker({ 
                 changeMonth: true,
                
                 changeYear: true,
                 maxDate:"today",
                 onSelect: function(selected) {

                 }
             });   



    });
  
    
    $("#aspnetForm").validate({
        rules: {
             <%=RIssuefromTextBox.UniqueID %>: {
                        
                        required: true
                      
                    },<%=RIssueToTextBox.UniqueID %>: {
                        
                        required: true,
                        greaterThan: '#<%=RIssueToTextBox.ClientID%>'                      
                    }
              
                }, messages: {
                   <%=RIssuefromTextBox.UniqueID %>:{  
                       required: "*From Date  is required*"
                     
                   },<%=RIssueToTextBox.UniqueID %>:{  
                       required: "*To Date  is required*",
                      
                   }
                    
                    
                        
                }
      });

    </script>

</asp:Content>


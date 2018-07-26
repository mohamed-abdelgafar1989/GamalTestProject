<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkflowHome.aspx.cs" Inherits="WorkflowApp.WorkflowHome" MasterPageFile="~/Site.Master" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>


    <asp:Content ContentPlaceHolderID="Main" runat="server">
 <div>
    <table style="padding-bottom: 5px; text-align: right; width: 100%" style="padding-bottom: 5px; text-align: right; width: 100%">
            <tr>

                 <td>
                     
                    <%--  <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" ToolTip="طباعة">
                         <img src="../../../..~/Assets/Images/print.png" width="40px" height="40px" />
                    </asp:HyperLink>--%>
                    <%-- <SharePoint:PeopleEditor ID="PeopleEditor1" runat="server"  Width="300px"  />--%>
                
                </td>
                <td>
                    <asp:HyperLink ID="hypr_Diagram" runat="server" Target="_blank" ToolTip="مخطط سير العمل "
                        NavigateUrl="#">
                         <img src="Assets/Images/11-Workflow60.png" width="40px" height="40px"  style="vertical-align:middle;"/>
                    </asp:HyperLink>
                </td>

                <td>
                    <asp:HyperLink ID="hypr_WFDoc" runat="server" Target="_blank" ToolTip="دليل الإجراءات الخاصة بنموذج سير العمل">
                         <img src="Assets/Images/10-ExportGOV2-60.png" width="40px" height="40px" style="vertical-align:middle;" />
                    </asp:HyperLink>
                </td>

                <td>

                    <asp:ImageButton ID="btn_RestartWF" Enabled="false" runat="server" ImageUrl="~/Assets/Images/9-RestartWorkflow60.png" ToolTip="إعادة بدء سير العمل"
                        OnClientClick="return confirm('هل أنت متأكد من إعادة بدء سير العمل؟');" OnClick="btn_RestartWF_Click" Width="40px" Height="40px" />
                </td>
                <td>

                    <asp:ImageButton ID="Comments_btn" runat="server" ImageUrl="~/Assets/Images/3-StepNotes_SQ.png" ToolTip="كل الملاحظات"
                        OnClientClick="return CallPanel();" Width="40px" Height="40px" />
                </td>
                <td>
                    <asp:HyperLink ID="hypr_WFAttach" runat="server" Target="_blank" ToolTip="تحميل المرفقات">
                         <img src="Assets/Images/36-WFAttachments.png" width="40px" height="40px" style="vertical-align:middle;" />
                    </asp:HyperLink>
                </td>
               
                <td></td>
                <td style="width: 50%"></td>
                <td>
                    <div id="DivAllTasks" runat="server" style="background-color: azure; padding: 7px; text-align: center; border-color: silver; border-width: 1px; border-style: solid;">

                        <asp:HyperLink ID="hypr_AllTasks" runat="server" Target="_self" Text="عرض كل المهمات" ToolTip="عرض كل المهمات" NavigateUrl="#" Font-Underline="true">
                        </asp:HyperLink>

                    </div>
                </td>

                <td style="width: 20px"></td>
                <td>
                    <div id="DivMyTasks" runat="server" style="background-color: azure; padding: 7px; text-align: center; border-color: silver; border-width: 1px; border-style: solid;">
                        <asp:HyperLink ID="hypr_MyTasks" runat="server" Target="_self" Text="مهماتي" ToolTip="عرض المهمات المعينة لي" NavigateUrl="#" Font-Underline="true">
                        </asp:HyperLink>
                    </div>
                </td>

            </tr>
        </table>
 </div>

    </asp:Content>
    

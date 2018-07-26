<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCustomField.aspx.cs" Inherits="WorkflowApp.PopUps.UpdateCustomField" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Data.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <style>
                .dxeListBoxItem {
                    text-align: right !important;
                }

                .dxgvHeader, .dxgvHeader table {
                    color: #38b6ab;
                }

                .dxgvHeader {
                    font-family: "DIN Next LT Arabic",sans-serif;
                    background: #f4f4f4;
                    text-align: Center;
                    border-top-width: 0px;
                    border-left-width: 0px;
                    border: 1px solid #e5e5e5;
                    border-bottom: 1px solid #e5e5e5;
                    border-top: 1px solid #e5e5e5;
                    border-left: 0px solid #F8F8F8;
                    border-left: 0px solid #F8F8F8;
                    color: #38b6ab;
                    vertical-align: middle;
                    font-weight: bold;
                    font-size: 13px;
                    background-color: #f4f4f4;
                    position: relative;
                }

                /** Update DevExpress group panel style **/
                .dxgvGroupPanel {
                    background: #e6edec !important;
                    white-space: nowrap;
                    background-color: #cfddee;
                    color: #777;
                    border-bottom: 1px solid #8ba0bc;
                    padding: 7px 4px 10px 6px;
                    border-radius: 7px 7px 0 0;
                }

                .dxeMemoEditAreaSys, input.dxeEditAreaSys[type="text"], input.dxeEditAreaSys[type="password"] {
                    width: 100%;
                    background: #f0f0f0;
                    background: -moz-linear-gradient(top,#f0f0f0 0,#fff 57%);
                    background: -webkit-linear-gradient(top,#f0f0f0 0,#fff 57%);
                    background: linear-gradient(to bottom,#f0f0f0 0,#fff 57%);
                    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f0f0f0', endColorstr='#ffffff', GradientType=0 );
                    border: 1px solid #ccc;
                    border-radius: 4px;
                    -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
                    box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
                    -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
                    -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
                    transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
                }

                input[type="text"] {
                    display: block;
                    width: 100%;
                    height: 34px;
                    padding: 6px 12px;
                    font-size: 14px;
                    line-height: 1.42857143;
                    color: #555;
                    background: #f0f0f0;
                    background: -moz-linear-gradient(top,#f0f0f0 0,#fff 57%);
                    background: -webkit-linear-gradient(top,#f0f0f0 0,#fff 57%);
                    background: linear-gradient(to bottom,#f0f0f0 0,#fff 57%);
                    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f0f0f0', endColorstr='#ffffff', GradientType=0 );
                    border: 1px solid #ccc;
                    border-radius: 4px;
                    -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
                    box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
                    -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
                    -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
                    transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
                }

                #Popup Table {
                    font-family: "DIN Next LT Arabic",sans-serif;
                }

                #Popup tr {
                    font-family: "DIN Next LT Arabic",sans-serif;
                }

                    #Popup tr:nth-child(even) {
                        background-color: #fafafa;
                    }

                        #Popup tr:nth-child(even):hover {
                            background-color: #FFFDFD;
                        }

                /*.tr .Alt {
        background-color: #fafafa;
    }*/
                .HideTableRow {
                    display: none;
                }

                .ProjectHeader, .FieldTitle {
                    font-family: "DIN Next LT Arabic",sans-serif;
                    margin-bottom: 24px;
                    font-size: 24px;
                    color: #38b6ab;
                }

                .ProjectLabelHeader {
                    font-size: 18px;
                    font-family: "DIN Next LT Arabic",sans-serif;
                    padding-right: 10px;
                    margin-right: 10px;
                    border-collapse: collapse;
                    /*border-color: gray;*/
                    border-spacing: 0px;
                    min-height: 30px;
                    font-weight: bold;
                    color: #666;
                    vertical-align: top;
                    text-align: right;
                    direction: rtl;
                    width: 98%;
                }

                .SectionHeader {
                    font-family: "DIN Next LT Arabic",sans-serif;
                    font-size: 16px;
                    padding-right: 10px;
                    margin-right: 10px;
                    border-collapse: collapse;
                    border-spacing: 0px;
                    min-height: 25px;
                    color: #38b6ab;
                    vertical-align: top;
                    text-align: right;
                    direction: rtl;
                    width: 30%;
                    /*text-decoration: underline;*/
                }

                .label-control.lg {
                    font-size: 16px;
                }

                .text-primary, .text-success {
                    color: #38b6ab;
                }

                .label-control {
                    padding: 5px 0;
                }

                /*.FieldTitle {
        font-size: 15px;
        /*background-color: #F5F5F5;*/
                padding-right: 10px; margin-right: 10px;
                /*border-collapse: collapse;
        border-width: 1px;
        border-style: solid;
        border-color: gray;
        border-spacing: 0px;
        min-height: 25px;
        color: #38b6ab;
        vertical-align: top;
        text-align: right;
        direction: rtl;
        width: 25%;
    }*/
                .TableCell {
                    border-collapse: collapse;
                    /*border-width: 1px;
        border-style: solid;
        border-color: gray;*/
                    border-spacing: 0px;
                }

                .TableCell2 {
                    border-collapse: collapse;
                    /*border-width: 1px;
        border-style: solid;
        border-color: gray;*/
                    font-size: 15px;
                    border-spacing: 0px;
                    width: 25%;
                    color: #666;
                }


                input[type="button"]:hover {
                    background-color: #AFEEEE !important;
                }

                .HideStatusBar {
                    display: none;
                }

                #notification {
                    position: relative;
                    top: 0px; /* Set to 0 or wherever */
                    width: 30%; /* set to 100% if space is available */
                    z-index: 105;
                    text-align: center;
                    font-weight: normal;
                    font-size: 14px;
                    font-weight: bold;
                    color: white;
                    background-color: #FF0024;
                    padding: 2px;
                }

                    #notification span.dismiss {
                        border: 2px solid #FFF;
                        padding: 0 5px;
                        cursor: pointer;
                        float: right;
                        margin-right: 10px;
                    }

                    #notification a {
                        color: white;
                        text-decoration: none;
                        font-weight: bold;
                    }

                h1, h2, h3, h4, h5, h6 {
                    color: #38b6ab;
                    margin: 0;
                    padding: 0;
                    font-size: 30px;
                }
            </style>
            <style>
                .TableStyle {
                    /*border: thin solid #C0C0C0;*/
                    border-collapse: collapse;
                    border-spacing: 0;
                    direction: rtl;
                    text-align: right;
                    width: 100%;
                    margin-left: auto;
                    margin-right: auto;
                }

                /*.FieldTitle {
        font-size: 12px;
        background-color: #FFFFE0;
        padding-right: 10px;
        margin-right: 10px;
        border-collapse: collapse;
        border-width: 1px;
        border-style: solid;
        border-color: gray;
        border-spacing: 0px;
        min-height: 25px;
        font-weight: bold;
        color: black;
        vertical-align: top;
        text-align: right;
        direction: rtl;
        width: 25%;
    }*/


                .TableRow {
                    border-collapse: collapse;
                    border-width: 1px;
                    border-style: solid;
                    border-color: gray;
                    border-spacing: 0px;
                }

                .TableCell {
                    border-collapse: collapse;
                    /*border-width: 1px;
        border-style: solid;
        border-color: gray;
        border-spacing: 0px;
        /*width: 25%;*/ */;
                }


                .SectionHeader {
                    font-size: 14px;
                    background-color: rgba(230, 242, 250, 1);
                    padding-right: 10px;
                    margin-right: 10px;
                    border-collapse: collapse;
                    border-width: 1px;
                    border-style: solid;
                    border-color: gray;
                    border-spacing: 0px;
                    min-height: 25px;
                    font-weight: bold;
                    color: black;
                    vertical-align: top;
                    text-align: right;
                    direction: rtl;
                    width: 30%;
                    text-decoration: underline;
                }

                input[type="button"]:hover {
                    background-color: #AFEEEE !important;
                }


                .ProjectHeader {
                    font-size: 18px;
                    background-color: rgba(54, 167, 202, 1);
                    padding-right: 10px;
                    margin-right: 10px;
                    border-collapse: collapse;
                    border-width: 1px;
                    border-style: solid;
                    border-color: gray;
                    border-spacing: 0px;
                    min-height: 30px;
                    font-weight: bold;
                    color: #FFFFFF;
                    vertical-align: top;
                    text-align: right;
                    direction: rtl;
                    /*width: 30%;*/
                    color: #fff;
                }

                .ProjectLabelHeader {
                    font-size: 18px;
                    background-color: rgba(54, 167, 202, 1);
                    padding-right: 10px;
                    margin-right: 10px;
                    border-collapse: collapse;
                    border-width: 1px;
                    border-style: none;
                    border-color: gray;
                    border-spacing: 0px;
                    min-height: 30px;
                    font-weight: bold;
                    color: #fff;
                    vertical-align: top;
                    text-align: right;
                    direction: rtl;
                    width: 30%;
                }

                h1, h2, h3, h4, h5, h6 {
                    color: #38b6ab;
                    margin: 0;
                    padding: 0;
                    font-size: 30px;
                }
            </style>

            <script type="text/javascript">

                function btnSubmit_onclick() {
                    lp.Show();
                    cbp.PerformCallback("SubmitProjectBtn");
                }

                function isNumberKey(evt) {
                    var charCode = (evt.which) ? evt.which : evt.keyCode;
                    if (charCode > 31 && (charCode < 48 || charCode > 57))
                        return false;
                    return true;
                }
            </script>

            <dx:ASPxHiddenField runat="server" ClientInstanceName="hfAnswers" ID="hfAnswers"></dx:ASPxHiddenField>

            <dx:ASPxLoadingPanel ID="lp" runat="server" ClientInstanceName="lp" Modal="true">
            </dx:ASPxLoadingPanel>

            <table style="width: 100%; height: 100%">
                <tr>
                    <td>

                        <div style="background-color: #004c45; padding-bottom: 5px; margin-bottom: 5px">
                            <div class="task-head">
                                <h2 id="MandateName" runat="server">
                                    <asp:Label ID="lbl_FieldTitle" runat="server" Text=" " Font-Bold="true"> </asp:Label>
                                </h2>
                                <div class="task-meta mtmd clearfix" style="font-family: DIN Next LT Arabic,sans-serif;">
                                    
                                </div>
                            </div>
                        </div>

                    </td>
                </tr>
                <tr>
                    <td style="height: 10px"></td>
                </tr>
                <tr>
                    <td>
                        <table id="Popup" style="border: double solid #C0C0C0; border-collapse: collapse; border-spacing: 0; direction: rtl; text-align: right" width="100%" align="right">
                            <tr>
                                <td>
                                    <dx:ASPxCallbackPanel ID="cbp" runat="server" ScrollBars="None" ClientInstanceName="cbp" Width="100%" Height="100%" OnCallback="cbp_Callback">
                                        <ClientSideEvents EndCallback="function(s, e) { lp.Hide(); var parentWindow = window.parent; parentWindow.SelectAndClosePopup(); }" />
                                        <PanelCollection>
                                            <dx:PanelContent runat="server">
                                                <asp:Panel ID="Pnl1_ProjectInfo" runat="server" Style="width: 100%; direction: rtl; display: block;">
                                                    <div id="Div1ProjectInfo" runat="server" style="direction: rtl; width: 100%; background-color: white; height: 80%">
                                                    </div>
                                                </asp:Panel>

                                                <asp:Panel ID="Pnl9_ApprovalActions" runat="server" Style="width: 100%; direction: rtl; display: Block;">
                                                    <div id="Div9ApprovalActions" style="direction: rtl; width: 100%; background-color: white; height: 15%">
                                                        <table style="border: 0px solid #C0C0C0; border-collapse: collapse; border-spacing: 0; direction: rtl; text-align: right" width="100%" align="right">
                                                            <tr>
                                                                <td style="height: 10px"></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: center; direction: rtl; width: 15%; font-weight: bold; font-size: 14px;">
                                                                    <input type="button" value="حفظ" onclick="return btnSubmit_onclick()" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </asp:Panel>

                                            </dx:PanelContent>
                                        </PanelCollection>
                                    </dx:ASPxCallbackPanel>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>

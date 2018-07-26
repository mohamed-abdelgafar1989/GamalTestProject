using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkflowApp.PopUps
{
    public partial class UpdateCustomField : System.Web.UI.Page
    {
        Guid CFId, ObjectId, ObjectTypeId;
        bool ReadOnly = true;
        int RtL = 0;

        protected void Page_Init(object sender, EventArgs e)
        {
            try
            {
                CFId = new Guid(Utilities.GetURLQuery("CFId"));
                ObjectId = new Guid(Utilities.GetURLQuery("ObjectId"));
                ObjectTypeId = new Guid(Utilities.GetURLQuery("ObjectTypeId"));

                Session.Add("CFId", CFId);
                Session.Add("ObjectId", ObjectId);
                Session.Add("ObjectTypeId", ObjectTypeId);

                //DisplayCFControl(CFId, ObjectId, ObjectTypeId);
            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField- Page_Init1"); }


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Controls

        
        private DataTable GetCFInfo(Guid cFId)
        {
            DataTable dtCustomFields = new DataTable();
            try
            {
                var remoteAddress = new System.ServiceModel.EndpointAddress(Utilities.GetConfigValue("ServiceURL"));
                using (SR_Service.ServiceClient srv = new SR_Service.ServiceClient(new System.ServiceModel.BasicHttpBinding(), remoteAddress))
                {
                    dtCustomFields = srv.GetCFInfo(CFId);
                }

            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-GetCFInfo"); }
            return dtCustomFields;
        }

        private object GetListValues(Guid LookUpListId)
        {
            object Value = new object();
            try
            {
                //Value 

            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-GetListValues"); }
            return Value;
        }

        private object GetCustomFieldValue(Guid cFId, Guid objectId)
        {
            object Value = new object();
            try
            {
                //Value 

            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-GetCustomFieldValue"); }
            return Value;
        }

        private void DisplayCFControl(Guid CFId, Guid ObjectId, Guid ObjectTypeId)
        {
            DataTable dtCustomFields = GetCFInfo(CFId);

            Table aspTable = new Table() { ID = "tblCustomFIelds", CssClass = "TableStyle" };
            const int i = 0;

            try
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();

                row.ID = "rw" + i;
                cell1.ID = "c" + i + "1";
                cell2.ID = "c" + i + "2";
                Label lbl_CFName = new Label();
                lbl_FieldTitle.Text = "تحديد " + Convert.ToString(dtCustomFields.Rows[i]["Name"]);
                string CFName = Convert.ToString(dtCustomFields.Rows[i]["Name"]);
                lbl_CFName.Text = CFName;
                cell1.Controls.Add(lbl_CFName);
                string ControlID = "CF_Field" + i;

                if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) == "SingleText")
                {
                    try
                    {
                        ASPxTextBox TB = new ASPxTextBox()
                        {
                            ID = ControlID,
                            ClientInstanceName = ControlID,
                            EnableViewState = true,
                            RightToLeft = (DevExpress.Utils.DefaultBoolean)RtL,
                            Width = new Unit("90%"),
                            ReadOnly = ReadOnly,
                            Value = Convert.ToString(GetCustomFieldValue(CFId, ObjectId))
                        };
                        cell2.Controls.Add(TB);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-DisplayCFControl1"); }
                }

                else if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) != "MultiLine")
                {
                    try
                    {
                        ASPxMemo MultiLine = new ASPxMemo()
                        {
                            ID = ControlID,
                            ClientInstanceName = ControlID,
                            EnableViewState = true,
                            RightToLeft = (DevExpress.Utils.DefaultBoolean)RtL,
                            Width = new Unit("90%"),
                            ReadOnly = ReadOnly,
                            Value = Convert.ToString(GetCustomFieldValue(CFId, ObjectId))
                        };
                        cell2.Controls.Add(MultiLine);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-DisplayCFControl2"); }
                }
                else if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) != "SingleSelection")
                {
                    try
                    {
                        ASPxComboBox ddl1 = new ASPxComboBox()
                        {
                            ID = ControlID,
                            ClientInstanceName = ControlID,
                            ValueField = "Id",
                            TextField = "Name",
                            EnableViewState = true,
                            ValueType = typeof(string),
                            EnableSynchronization = DevExpress.Utils.DefaultBoolean.True,
                            RightToLeft = DevExpress.Utils.DefaultBoolean.True,
                            Width = new Unit("90%"),
                            ReadOnly = ReadOnly

                        };
                        ddl1.DataSource = GetListValues(new Guid(Convert.ToString(dtCustomFields.Rows[i]["LookUpListId"])));
                        ddl1.DataBind();
                        ddl1.Value = Convert.ToString(GetCustomFieldValue(CFId, ObjectId));
                        cell2.Controls.Add(ddl1);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-DisplayCFControl3"); }
                }
                else if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) != "MultiSelection")
                {
                    try
                    {
                        ASPxComboBox ddl1 = new ASPxComboBox()
                        {
                            ID = ControlID,
                            ClientInstanceName = ControlID,
                            ValueField = "Title",
                            TextField = "Title",
                            EnableViewState = true,
                            ValueType = typeof(string),
                            EnableSynchronization = DevExpress.Utils.DefaultBoolean.True,
                            RightToLeft = DevExpress.Utils.DefaultBoolean.True,
                            Width = new Unit("90%"),
                            ReadOnly = ReadOnly

                        };
                        ddl1.DataSource = GetListValues(new Guid(Convert.ToString(dtCustomFields.Rows[i]["LookUpListId"])));
                        ddl1.DataBind();
                        ddl1.Value = Convert.ToString(GetCustomFieldValue(CFId, ObjectId));
                        cell2.Controls.Add(ddl1);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-DisplayCFControl4"); }
                }

                cell1.CssClass = "FieldTitle";
                cell2.CssClass = "TableCell";
                cell2.ColumnSpan = 3;
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);

                aspTable.Rows.Add(row);
            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-DisplayCFControl5"); }

            Div1ProjectInfo.Controls.Add(aspTable);
            if (dtCustomFields.Rows.Count < 1 || ReadOnly)
                Pnl9_ApprovalActions.Visible = false;
        }

        protected void cbp_Callback(object sender, CallbackEventArgsBase e)
        {
            ReadControlData(new Guid(Utilities.GetURLQuery("CFId")), new Guid(Utilities.GetURLQuery("ObjectId")));
        }

        public void ReadControlData(Guid CFId, Guid ObjectId)
        {
            Table asptable = (Table)Div1ProjectInfo.FindControl("tblCustomFIelds");
            DataTable dtCustomFields = GetCFInfo(CFId);
            const int i = 0;

            string Value = "";

            string ControlID = "CF_Field" + i;

            try
            {
                if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) == "SingleText")
                {
                    try
                    {
                        TableCell cell2 = asptable.Rows[i].Cells[1];
                        ASPxTextBox TB = (ASPxTextBox)cell2.FindControl(ControlID);
                        Value = Convert.ToString(TB.Value);
                        UpdateObjectRequiredItem(ObjectId, new Guid(Convert.ToString(dtCustomFields.Rows[i]["Id"])),
                             Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]), Value);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadControlData1"); }
                }
                if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) == "MultiLine")
                {
                    try
                    {
                        TableCell cell2 = asptable.Rows[i].Cells[1];
                        ASPxMemo Memo = (ASPxMemo)cell2.FindControl(ControlID);
                        Value = Convert.ToString(Memo.Value);
                        UpdateObjectRequiredItem(ObjectId, new Guid(Convert.ToString(dtCustomFields.Rows[i]["Id"])),
                             Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]), Value);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadControlData2"); }
                }
                if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) == "SingleSelection")
                {
                    try
                    {
                        TableCell cell2 = asptable.Rows[i].Cells[1];
                        ASPxComboBox ddl1 = (ASPxComboBox)cell2.FindControl(ControlID);
                        Value = Convert.ToString(ddl1.Value);
                        UpdateObjectRequiredItem(ObjectId, new Guid(Convert.ToString(dtCustomFields.Rows[i]["Id"])),
                             Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]), Value);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadControlData3"); }
                }
                if (Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]) == "MultiSelection")
                {
                    try
                    {
                        TableCell cell2 = asptable.Rows[i].Cells[1];
                        ASPxComboBox ddl1 = (ASPxComboBox)cell2.FindControl(ControlID);
                        Value = Convert.ToString(ddl1.Value);
                        UpdateObjectRequiredItem(ObjectId, new Guid(Convert.ToString(dtCustomFields.Rows[i]["Id"])),
                             Convert.ToString(dtCustomFields.Rows[i]["CustomFieldTypeName"]), Value);
                    }
                    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadControlData4"); }
                }

                //else if (Convert.ToBoolean(dtCustomFields.Rows[i]["People Picker"]))
                //{
                //    try
                //    {
                //        TableCell cell2 = asptable.Rows[i].Cells[1];
                //        string pPMLogin = string.Empty, pProjectLeader = string.Empty;
                //        try
                //        {
                //            PeopleEditor Owner = (PeopleEditor)cell2.FindControl(ControlID);
                //            PickerEntity selectedEntity = (PickerEntity)Owner.ResolvedEntities[0];
                //            pPMLogin = selectedEntity.Key;
                //            pProjectLeader = selectedEntity.DisplayText;
                //        }
                //        catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadData2"); }

                //        Value = pPMLogin;
                //        UpdateTextValueCustomField(pProjectUID, Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_UID"]), Value,
                //            Guid.NewGuid().ToString(), Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_ID"]), Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_TYPE_ENUM"]),
                //            Convert.ToString(dtCustomFields.Rows[i]["TableName"]), Convert.ToString(dtCustomFields.Rows[i]["ColumnPoolColumnName"]));

                //        //Added by Abeer
                //        if (Convert.ToBoolean(dtCustomFields.Rows[i]["Update Security Matrix"]))
                //        {
                //            UpdateSecurityMatrix(dtCustomFields.Rows[i]["CustomFieldName"].ToString(), pProjectUID, pPMLogin, pProjectLeader);
                //        }
                //    }
                //    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadData3"); }
                //}
                //else if (Convert.ToInt32(dtCustomFields.Rows[i]["MD_PROP_TYPE_ENUM"]) == 21 && Convert.ToBoolean(dtCustomFields.Rows[i]["MD_PROP_IS_MULTILINE_TEXT"]) == false)
                //{
                //    try 
                //    {
                //        // Text Field one line 
                //        TableCell cell2 = asptable.Rows[i].Cells[1];
                //        TextBox txt1 = (TextBox)cell2.FindControl(ControlID);
                //        Value = Convert.ToString(txt1.Text);
                //        UpdateTextValueCustomField(pProjectUID, Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_UID"]), Value,
                //            Guid.NewGuid().ToString(), Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_ID"]), Convert.ToString(dtCustomFields.Rows[i]["MD_PROP_TYPE_ENUM"]),
                //            Convert.ToString(dtCustomFields.Rows[i]["TableName"]), Convert.ToString(dtCustomFields.Rows[i]["ColumnPoolColumnName"]));
                //    }
                //    catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadData3"); }
                //}

            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-ReadControlData5"); }

        }

        private void UpdateObjectRequiredItem(Guid objectId, Guid CFId, string CustomFieldTypeName, object Value)
        {
            try
            {
            }
            catch (Exception ex) { string x = ex.Message; Utilities.WriteToLog(x, "WorkflowApp.PopUps.UpdateCustomField-UpdateObjectRequiredItem"); }
        }

        #endregion



    }
}
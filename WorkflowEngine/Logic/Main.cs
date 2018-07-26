using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Main
    {
        public List<DAL.lkup_JobTitle> JobTitle_Get()
        {
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                List<DAL.lkup_JobTitle> lkup_JobTitles = db.lkup_JobTitle.ToList();
                return lkup_JobTitles;
            }
        }

        public static void CopyPropertiesTo<T, TU>(T source, TU dest)
        {
            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            var destProps = typeof(TU).GetProperties().Where(x => x.CanRead).ToList();

            foreach (var sourceProp in sourceProps)
            {
                if (destProps.Any(x => x.Name == sourceProp.Name))
                {
                    try
                    {
                        var p = destProps.First(x => x.Name == sourceProp.Name);
                        p.SetValue(dest, sourceProp.GetValue(source, null), null);
                    }
                    catch
                    { }
                }
            }

        }

        public static List<T> ListCopy<T>(List<T> sourceLst, T descObjType)
        {
            List<T> destLst = new List<T>();
            foreach (var s in sourceLst)
            {
                T d = (T)Activator.CreateInstance(descObjType.GetType());
                CopyPropertiesTo(s, d);
                destLst.Add(d);
            }
            return destLst;
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static DataTable GetCFInfo(Guid CFId)
        {
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                DataTable Result = ToDataTable(db.TM_GetCFInfo(CFId).ToList());
                return Result;
            }
        }


        #region AbeerWork
        //public static DataTable GetWorkflowStepsbyObjectId(Guid? pObjectId, Guid? PObjectTypeId)
        //{
        //    DataTable result = new DataTable();
        //    using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
        //    {
        //        List<DAL.> StepsList = db.GetWFStepsbyObjectId(pObjectId, PObjectTypeId).ToList();
        //        result = ToDataTable(StepsList.ToList());
        //    }

        //    return result;

        //}
        public static DataTable GetStepRequiredItembyObjectId(Guid pObjectId)
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                DataTable StepsList = ToDataTable(db.TM_StepRequiredItem_GetbyObjectId(pObjectId).ToList());
            }

            return result;

        }
        public static DataTable GetStepsbyWorkflowId(Guid pWorkflow)
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                DataTable StepsList = ToDataTable(db.Step_GetByWorkflowId(pWorkflow).ToList());
            }

            return result;

        }
        #endregion


    }
}

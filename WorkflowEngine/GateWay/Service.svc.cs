using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace GateWay
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public void DoWork()
        {
        }

        public int calc(int x, int y)
        {
            return x * y;
        }

        public List<DAL.lkup_JobTitle> ShowAllJobTitles()
        {
            Logic.Main main = new Logic.Main();
            List<DAL.lkup_JobTitle> lkup_JobTitles = main.JobTitle_Get().ToList();

            return lkup_JobTitles;
        }


        public DataTable GetWorkflowStepsbyObjectId(Guid? pObjectId, Guid? PObjectTypeId)
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                //result = Logic.Main.GetWorkflowStepsbyObjectId(pObjectId, PObjectTypeId);
            }
            return result;

        }


        public DataTable GetCFInfo(Guid CFId)
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                result = Logic.Main.GetCFInfo(CFId);
            }

            return result;

        }

        #region Abeer Work
        public DataTable StepRequiredItemby_GetObjectId(Guid pObjectId )
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                result = Logic.Main.GetStepRequiredItembyObjectId(pObjectId);
            }
            return result;

        }
        public DataTable Steps_GetWorkflowId(Guid pWorkflowId)
        {
            DataTable result = new DataTable();
            using (DAL.StepPointWFEntities db = new DAL.StepPointWFEntities())
            {
                result = Logic.Main.GetStepsbyWorkflowId(pWorkflowId);
            }
            return result;

        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GateWay
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int calc(int x, int y);

        [OperationContract]
        List<DAL.lkup_JobTitle> ShowAllJobTitles();

        [OperationContract]
        DataTable GetWorkflowStepsbyObjectId(Guid? pObjectId, Guid? PObjectTypeId);


        [OperationContract]
        DataTable GetCFInfo(Guid CFId);
        [OperationContract]
        DataTable StepRequiredItemby_GetObjectId(Guid pObjectId);

    }
}

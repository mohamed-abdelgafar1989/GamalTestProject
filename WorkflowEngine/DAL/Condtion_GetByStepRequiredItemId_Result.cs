//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Runtime.Serialization;
    [DataContract]
    public partial class Condtion_GetByStepRequiredItemId_Result
    {
        [DataMember] public System.Guid Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public System.Guid StepRequiredItemId { get; set; }
        [DataMember] public System.Guid MatchingCritriaId { get; set; }
        [DataMember] public Nullable<double> MatchingValue_Number { get; set; }
        [DataMember] public Nullable<System.Guid> MatchingValue_Lookup { get; set; }
        [DataMember] public string MatchingValue_Text { get; set; }
        [DataMember] public string MatchingCritria { get; set; }
    }
}

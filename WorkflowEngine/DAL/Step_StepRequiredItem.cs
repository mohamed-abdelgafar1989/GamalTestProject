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
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public partial class Step_StepRequiredItem
    {
    	
    
        [DataMember] public System.Guid Id { get; set; }
    
        [DataMember] public System.Guid StepId { get; set; }
    
        [DataMember] public System.Guid StepRequiredItemId { get; set; }
    
        [DataMember] public Nullable<int> Order { get; set; }
    
        [DataMember] public Nullable<System.Guid> CreatedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> CreationDate { get; set; }
    
        [DataMember] public Nullable<System.Guid> ModifiedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> ModificationDate { get; set; }
    
        [DataMember] public bool IsActive { get; set; }
    
        public virtual Step Step { get; set; }
        public virtual StepRequiredItem StepRequiredItem { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

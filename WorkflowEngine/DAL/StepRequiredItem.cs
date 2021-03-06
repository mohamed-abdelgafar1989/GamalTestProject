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
    public partial class StepRequiredItem
    {
    	
    
        public StepRequiredItem()
        {
            this.Condtion = new HashSet<Condtion>();
            this.Object_StepRequiredItem = new HashSet<Object_StepRequiredItem>();
            this.Step_StepRequiredItem = new HashSet<Step_StepRequiredItem>();
        }
    
    
        [DataMember] public System.Guid Id { get; set; }
    
        [DataMember] public string Name { get; set; }
    
        [DataMember] public Nullable<System.Guid> RequiredItemTypeId { get; set; }
    
        [DataMember] public string Url { get; set; }
    
        [DataMember] public Nullable<System.Guid> CustomFieldTypeId { get; set; }
    
        [DataMember] public Nullable<System.Guid> LookUpListId { get; set; }
    
        [DataMember] public Nullable<System.Guid> CreatedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> CreationDate { get; set; }
    
        [DataMember] public Nullable<System.Guid> ModifiedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> ModificationDate { get; set; }
    
        [DataMember] public bool IsActive { get; set; }
    
        public virtual ICollection<Condtion> Condtion { get; set; }
        public virtual CustomFieldType CustomFieldType { get; set; }
        public virtual lkup_LookupList lkup_LookupList { get; set; }
        public virtual lkup_RequiredItemType lkup_RequiredItemType { get; set; }
        public virtual ICollection<Object_StepRequiredItem> Object_StepRequiredItem { get; set; }
        public virtual ICollection<Step_StepRequiredItem> Step_StepRequiredItem { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

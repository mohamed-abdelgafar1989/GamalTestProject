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
    public partial class ObjectTypeWorkflow
    {
    	
    
        public ObjectTypeWorkflow()
        {
            this.User2 = new HashSet<User>();
        }
    
    
        [DataMember] public System.Guid Id { get; set; }
    
        [DataMember] public string Name { get; set; }
    
        [DataMember] public string Description { get; set; }
    
        [DataMember] public Nullable<System.Guid> ParentId { get; set; }
    
        [DataMember] public Nullable<System.Guid> CreatedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> CreationDate { get; set; }
    
        [DataMember] public Nullable<System.Guid> ModifiedBy { get; set; }
    
        [DataMember] public Nullable<System.DateTime> ModificationDate { get; set; }
    
        [DataMember] public bool IsActive { get; set; }
    
        [DataMember] public Nullable<System.Guid> ObjectTypeId { get; set; }
    
        [DataMember] public Nullable<System.Guid> WorkflowId { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<User> User2 { get; set; }
    }
}
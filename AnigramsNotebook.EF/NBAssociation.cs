//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnigramsNotebook.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class NBAssociation
    {
        public int NBAssociationId { get; set; }
        public int ParentCategoryId { get; set; }
        public int ParentId { get; set; }
        public int ChildCategoryId { get; set; }
        public int ChildId { get; set; }
        public string ChildName { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
    
        public virtual NBCategory NBCategory { get; set; }
        public virtual NBCategory NBCategory1 { get; set; }
    }
}

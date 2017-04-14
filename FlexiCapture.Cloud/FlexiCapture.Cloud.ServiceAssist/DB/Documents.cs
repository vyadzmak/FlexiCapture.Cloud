//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlexiCapture.Cloud.ServiceAssist.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documents
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public System.DateTime Date { get; set; }
        public double FileSize { get; set; }
        public string OriginalFileName { get; set; }
        public System.Guid Guid { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public int DocumentStateId { get; set; }
        public int DocumentTypeId { get; set; }
        public string Hash { get; set; }
        public Nullable<int> DocumentCategoryId { get; set; }
    
        public virtual DocumentCategories DocumentCategories { get; set; }
        public virtual DocumentStates DocumentStates { get; set; }
        public virtual DocumentTypes DocumentTypes { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}

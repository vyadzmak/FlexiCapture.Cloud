//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlexiCapture.Cloud.Portal.Api.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZipTaskStatistics
    {
        public int Id { get; set; }
        public int ZipTaskId { get; set; }
        public int TotalCharacters { get; set; }
        public int UncertainCharacters { get; set; }
        public int PagesArea { get; set; }
    
        public virtual ZipTasks ZipTasks { get; set; }
    }
}

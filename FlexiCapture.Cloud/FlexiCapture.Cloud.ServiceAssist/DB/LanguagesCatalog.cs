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
    
    public partial class LanguagesCatalog
    {
        public LanguagesCatalog()
        {
            this.UserProfileLanguages = new HashSet<UserProfileLanguages>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    
        public virtual ICollection<UserProfileLanguages> UserProfileLanguages { get; set; }
    }
}

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
    
    public partial class UserProfilePrintTypes
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public int PrintTypeId { get; set; }
    
        public virtual PrintTypeCatalog PrintTypeCatalog { get; set; }
        public virtual UserProfiles UserProfiles { get; set; }
    }
}

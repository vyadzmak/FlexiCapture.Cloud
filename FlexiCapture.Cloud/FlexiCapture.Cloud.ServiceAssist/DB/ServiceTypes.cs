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
    
    public partial class ServiceTypes
    {
        public ServiceTypes()
        {
            this.Tasks = new HashSet<Tasks>();
            this.UserProfileServiceDefault = new HashSet<UserProfileServiceDefault>();
            this.UserServiceSubscribes = new HashSet<UserServiceSubscribes>();
        }
    
        public int Id { get; set; }
        public string ServiceName { get; set; }
    
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<UserProfileServiceDefault> UserProfileServiceDefault { get; set; }
        public virtual ICollection<UserServiceSubscribes> UserServiceSubscribes { get; set; }
    }
}

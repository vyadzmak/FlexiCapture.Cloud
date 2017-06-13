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
    
    public partial class UserLogins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserLogins()
        {
            this.UserConfirmationEmails = new HashSet<UserConfirmationEmails>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserLoginStateId { get; set; }
        public int UserRoleId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
    
        public virtual UserLoginStates UserLoginStates { get; set; }
        public virtual UserRoleTypes UserRoleTypes { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserConfirmationEmails> UserConfirmationEmails { get; set; }
    }
}

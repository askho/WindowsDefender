//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsDefenderWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatchHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatchHistory()
        {
            this.MatchHistoryDetails = new HashSet<MatchHistoryDetail>();
        }
    
        public int MatchId { get; set; }
        public int TimeElapsed { get; set; }
        public System.DateTime DatePlayed { get; set; }
        public string HostId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchHistoryDetail> MatchHistoryDetails { get; set; }
    }
}
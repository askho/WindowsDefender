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
    
    public partial class MatchHistoryDetail
    {
        public int HistoryId { get; set; }
        public int MatchId { get; set; }
        public string UserId { get; set; }
        public bool WonGame { get; set; }
        public string Team { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual MatchHistory MatchHistory { get; set; }
    }
}
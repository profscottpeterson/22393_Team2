//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoachSession
    {
        public int SessionID { get; set; }
        public string RoomID { get; set; }
        public string DayID { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public string CoachID { get; set; }
        public bool Active { get; set; }
    
        public virtual Coach Coach { get; set; }
        public virtual Time Time { get; set; }
        public virtual Time Time1 { get; set; }
        public virtual Day Day { get; set; }
        public virtual Room Room { get; set; }
    }
}

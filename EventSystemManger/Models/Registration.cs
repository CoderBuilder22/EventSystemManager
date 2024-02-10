namespace EventSystemManger.Models
{
    using System;

    public class Registration
    {
        public int RegistrationId { get; set; }
        public Event Event { get; set; }
        public Participant Participant { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}

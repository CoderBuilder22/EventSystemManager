namespace EventSystemManger.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EventService
    {
        private List<Event> events = new List<Event>();
        private List<Participant> participants = new List<Participant>();
        private List<Registration> registrations = new List<Registration>();

        public Event CreateEvent(string eventName, DateTime date, string location, string description)
        {
            var newEvent = new Event
            {
                EventId = events.Count + 1,
                EventName = eventName,
                Date = date,
                Location = location,
                Description = description
            };

            events.Add(newEvent);
            return newEvent;
        }

        public Event GetEvent(int eventId)
        {
            return events.FirstOrDefault(e => e.EventId == eventId);
        }

        public Registration RegisterParticipant(int eventId, string firstName, string lastName, string email, string phoneNumber)
        {
            var selectedEvent = GetEvent(eventId);

            if (selectedEvent != null)
            {
                var participant = new Participant
                {
                    ParticipantId = participants.Count + 1,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber
                };

                participants.Add(participant);

                var registration = new Registration
                {
                    RegistrationId = registrations.Count + 1,
                    Event = selectedEvent,
                    Participant = participant,
                    RegistrationDate = DateTime.Now
                };

                registrations.Add(registration);

                return registration;
            }

            return null;
        }

        public List<Registration> GetRegistrations(int eventId)
        {
            return registrations.Where(r => r.Event.EventId == eventId).ToList();
        }
    }

}

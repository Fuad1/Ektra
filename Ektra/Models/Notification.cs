using System;
using System.ComponentModel.DataAnnotations;

namespace Ektra.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; private set; }
        public string OriginalVenue { get; private set; }

        [Required]
        public Gig Gig { get; private set; }

        protected Notification()
        {

        }

        private Notification(Gig gig, NotificationType type)
        {
            Gig = gig ?? throw new ArgumentNullException(nameof(gig));

            DateTime = DateTime.Now;
            Type = type;
        }

        public static Notification GigCanceled(Gig gig)
        {
            return new Notification(gig, NotificationType.GigCanceled);
        }

        public static Notification GigUpdated(Gig newGig, string originalVenue, DateTime originalDateTime)
        {
            return new Notification(newGig, NotificationType.GigUpdated)
            {
                OriginalVenue = originalVenue,
                OriginalDateTime = originalDateTime
            };
        }
    }
}
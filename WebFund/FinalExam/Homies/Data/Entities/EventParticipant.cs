﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Entities
{
    [Comment("EventParticipant table")]
    public class EventParticipant
    {
        [Required]
        [ForeignKey("Helper")]
        public string HelperId { get; set; } = null!;
        public IdentityUser Helper { get; set; } = null!;

        [Required]
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;
    }
}


//•	HelperId – a string, Primary Key, foreign key (required)
//•	Helper – IdentityUser
//•	EventId – an integer, Primary Key, foreign key (required)
//•	Event – Event

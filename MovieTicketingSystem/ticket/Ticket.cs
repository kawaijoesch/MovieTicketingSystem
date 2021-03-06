﻿//============================================================
// Student Number	: S10173251C, S10166858B
// Student Name	    : Chin Wei Hong, Joe Kawai
// Module  Group	: IT04
//============================================================

namespace MovieTicketingSystem.ticket {
    abstract class Ticket {
        public Screening Screening { get; set; }

        public Ticket() { }

        public Ticket(Screening screening) {
            this.Screening = screening;
        }

        public abstract double CalculatePrice();

        public override string ToString() {
            return base.ToString();
        }
    }
}

﻿/* Plik przykładowy do rozdziału 3 - Stosy i kolejki. */

using System;

namespace CallCenterMany
{
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Consultant { get; set; }
    }
}

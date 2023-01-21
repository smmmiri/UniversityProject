﻿using Message.Enums;

namespace Message.Commands
{
    public class UpdateSemesterCommand
    {
        public Guid SemesterId  { get; set; }
        public string SemesterNumber { get; set; }
        public SemesterType SemesterType { get; set; }
        public DateTime SemesterYear { get; set; }
    }
}

﻿namespace LMS.Domain.Comman
{
    public class Auditable : Base
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

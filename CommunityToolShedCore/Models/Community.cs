﻿using System.ComponentModel.DataAnnotations;

namespace CommunityToolShedCore.Models
{
    public class Community
    {
        public Community(string name, bool isOpen)
        {
            Name = name;
            IsOpen = isOpen;
        }
        public int Id { get; set; }
        [Display(Name = "Open")]
        public string  Name { get; set; }
        public bool IsOpen { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} ({(IsOpen ? "Open" : "Closed")})";
        }
    }
}
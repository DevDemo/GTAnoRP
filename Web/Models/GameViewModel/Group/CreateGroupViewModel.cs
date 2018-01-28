﻿using GTAnoRP.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace GTAnoRP.WEB.Models.GameViewModel.Group
{
    public class CreateGroupViewModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        public GroupType Type { get; set; }

        [Required]
        public GroupExtraType ExtraType { get; set; }

        public string socialclub { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.Models
{
    public class CreatePartyRequest
    {
        [Required]
        [StringLength(40)]
        public string Name;
    }

    public class JoinPartyRequest
    {
        [Required]
        public string PartyId;
    }
}

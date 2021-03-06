﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Party
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
        public List<User> PendingMembers { get; set; }

    }
}

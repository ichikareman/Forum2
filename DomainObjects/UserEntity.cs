﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UCRMS_Version2.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
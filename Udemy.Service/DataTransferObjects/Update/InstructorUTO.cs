﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Service.DataTransferObjects.Update
{
    public class InstructorUTO
    {
        [StringLength(50)]
        public string? Title { get; set; }

        [StringLength(50)]
        public string? Bio { get; set; }

        public int? TotalCourses { get; set; }
    }
}
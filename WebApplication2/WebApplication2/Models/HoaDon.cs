﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int soKhach { get; set; }

        public double giaTien { get; set; }

        public virtual ICollection<ApplicationUser> applicationUser { get; set; }

        public virtual ICollection<Tour> tour { get; set; }

    }
}
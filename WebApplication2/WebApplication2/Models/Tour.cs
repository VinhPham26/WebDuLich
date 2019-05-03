using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string tenTour { get; set; }

        public int thoiGian { get; set; }

        public string phuongTien { get; set; }

        public int gia { get; set; }

        public DateTime ngayDi { get; set; }

        public string chiTiet { get; set; }
    }
}
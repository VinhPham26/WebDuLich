using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tên Tour")]
        public string tenTour { get; set; }
        [DisplayName("Thời gian")]
        public string thoiGian { get; set; }
        [DisplayName("Phương tiện")]
        public string phuongTien { get; set; }
        [DisplayName("Giá")]
        public int gia { get; set; }
        [DisplayName("Ngày đi")]
        public DateTime ngayDi { get; set; }
        [DisplayName("Chi tiết")]
        public string chiTiet { get; set; }
    }
}
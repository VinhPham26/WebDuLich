using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("GopY")]
    public class GopY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Tên khách hàng")]
        [Required(ErrorMessage = "Xin nhập tên")]
        public string tenKH { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Xin nhập email")]
        public string email { get; set; }

        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage = "Xin nhập tiêu đề")]
        public string tieuDe { get; set; }

        [DisplayName("Nội dung")]
        [Required(ErrorMessage = "Xin nhập nội dung")]
        public string noiDung { get; set; }

    }
}
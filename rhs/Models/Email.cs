using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rhs.Models
{
    [Table("Email")]
    public class Email
    {
        [Key]
        [Column("Id")]
        [Display(Name = "ID")]
        public int EmailID { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Column("SentDate")]
        [Display(Name = "Data de Envio")]
        public DateTime SentDate { get; set; }
    }
}
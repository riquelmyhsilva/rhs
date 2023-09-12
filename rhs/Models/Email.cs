using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rhs.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime SentDate { get; set; }
    }

}
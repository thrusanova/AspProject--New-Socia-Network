

namespace AspNetProject.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Certification
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string lisenceNumber { get; set; }

        public string Url { get; set; }

        public DateTime TakenDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        [Required]
        public string UserId { get; set; }
        
        public User User { get; set; }
    }
}
//386d6f6d-095e-4587-96b9-8b9d8a41e31a Tanya Hrusanova	07768557564	thrusanova www.thrusanova.co.nf    thrusanova Junior software developer   http://static.celebuzz.com/uploads/2009/02/11/msg-123431288371-3.jpg	thrusanova@gmail.com	False	AKcrW9rtlRDFRjczJGfl/tBL8UA9p6LQm6urmRtC9NikaGK8XYO0hO8XlwZs6mdbPQ==	e73f8678-753e-49c1-85bd-491cd449a504	NULL	False	False	NULL	True	0	thrusanova
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Model
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

    }
}

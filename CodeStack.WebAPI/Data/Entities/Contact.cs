using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CodeStack.WebAPI.Data.Entities {
  [Table("Contact")]
  public class Contact {
    [Key]
    public int ContactID { get; set; }

    [Column(TypeName = "VARCHAR(25)")]
    public string FirstName { get; set; }

    [Column(TypeName = "VARCHAR(25)")]
    public string LastName { get; set; }

    [Column(TypeName = "VARCHAR(25)")]
    public string EmailAddress { get; set; }

    [Column(TypeName = "VARCHAR(25)")]
    public string PhoneNumber { get; set; }

    [Column(TypeName = "VARCHAR(4000)")]
    public string Message { get; set; }
  }
}
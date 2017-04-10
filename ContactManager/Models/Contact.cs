using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    public class Contact
    {
        [ScaffoldColumn(false)]
        public int ContactId { get; set; }
       
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [StringLength(12,MinimumLength = 0)]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Phone number is invalid.")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber, ErrorMessage ="Phone number is invalid.")]
        [RegularExpression("^\\D?(\\d{3})\\D?\\D?(\\d{3})\\D?(\\d{4})$", ErrorMessage = "Phone number is invalid.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        [NotMapped]
        public string Self { get; set; }
    }

}
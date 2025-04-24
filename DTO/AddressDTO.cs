using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AddressDTO
    {
        public int ID { get; set; }
        public string AddressContent { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }

        [Required(ErrorMessage ="Please fill the map area")]
        public string LargeMapPath { get; set; }

        [Required(ErrorMessage ="Please fill the map area")]
        public string SmallMapPath { get; set; }
    }
}

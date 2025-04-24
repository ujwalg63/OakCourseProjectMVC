using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserStatic
    {
          public static int UserID { get; set; } //As long as u dont change userId in any code it will remain 1.
          public static bool isAdmin { get; set; }

          public static string Namesurname { get; set; }
          public static string Imagepath { get; set; }


    }

}

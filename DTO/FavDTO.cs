using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class FavDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Fav { get; set; }
        public string Logo { get; set; }
        public HttpPostedFileBase LogoImage { get; set; }
        [Display(Name = "Fav Image")]
        public HttpPostedFileBase FavImage { get; set; }

    }
}

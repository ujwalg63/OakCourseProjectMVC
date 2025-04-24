using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PostContext //database connect class from which we inherit all other dao classes
    {
        public static POSTDATAEntities db = new POSTDATAEntities();
    }
}

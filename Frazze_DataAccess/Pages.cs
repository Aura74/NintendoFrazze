using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_DataAccess
{
    public class Pages
    {
        [Key]
        public int ID { get; set; }
        public string PageName { get; set; }
        //public int ApplicationID { get; set; }
        public DateTime created { get; set; }

        public int ApplicationID { get; set; }
        //[ForeignKey("ApplicationID")]
        public Applications Application { get; set; }

    }
}

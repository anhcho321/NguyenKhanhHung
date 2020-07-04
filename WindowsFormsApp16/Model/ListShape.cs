using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    [Table("Hinh")]
    public class ListShape
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string begin { get; set; }
        public string end { get; set; }
        public string color { get; set; }
        public string dashstyle { get; set; }
        public string linewidth { get; set; }
        public string select { get; set; }

        public ICollection<ListShape> ListShapes { set; get; }
        
        

    }
}

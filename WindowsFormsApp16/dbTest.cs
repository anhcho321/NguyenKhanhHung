using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public class dbTest
    {
        public static void initializeDB()
        {
            using (var _context = new DBShapeContext())
            {
                var shape = new ListShape { name = "hung" };
                _context.tbListShapes.Add(shape);
                _context.SaveChanges();
            }
            MessageBox.Show("Finish");

        }
    }
}

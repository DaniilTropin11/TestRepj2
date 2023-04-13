using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursApp
{
    public partial class TourBaseEntities
    {
        static TourBaseEntities _context;
        
        public static TourBaseEntities GetContext()
        {
            if(_context == null)
            {
                _context = new TourBaseEntities();  
            }
            return _context;
        }
    }
}

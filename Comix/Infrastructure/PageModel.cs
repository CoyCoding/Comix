using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comix.Infrastructure
{
    public class PageModel
    {
        public int TotalItems { get { return 1500; } }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
            
        }
        
        public int Offset
        {
            get
            {
                return ItemsPerPage * (CurrentPage-1);
            }
        }

    }
}
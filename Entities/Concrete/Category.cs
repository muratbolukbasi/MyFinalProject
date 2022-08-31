using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //ÇIPLAK CLASS KALMASIN
    public class Category: IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } 
    }
}

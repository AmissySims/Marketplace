using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Models
{
    public partial class Product
    {
       public string FullName
        {
            get
            {
                return $" Title: {Title}, Price: {Price} руб.";
            }
        }
    }
}

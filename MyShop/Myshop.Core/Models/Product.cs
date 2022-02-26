using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.Core.models
{
    class Product
    {
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string  Id { get; set; }
        public string Name { get; set; }
        public string Descrition { get; set; }
        public decimal Price { get; set; }
        public string  Category { get; set; }
        public string     Image { get; set; }


        Product()
        {
            this.Id = Guid.NewGuid().ToString();

        }
    }
}

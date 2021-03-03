using System.Collections.Generic;

namespace MvvmApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNote { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }        

    }
}
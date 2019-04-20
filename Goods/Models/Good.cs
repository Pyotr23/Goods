using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Goods.Models
{
    public partial class Good
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

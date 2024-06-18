using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject;
internal class Lipstick : IProduct {

    public string ProductName {  get; set; } = string.Empty;
    public decimal ProductPrice { get; set; } = 0;
}

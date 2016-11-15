using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class PriceChange
  {
    public string Direction { get; set; }
    public DateTime Date { get; set; }
    public string Percent { get; set; }
    public decimal Price { get; set; }
  }
}
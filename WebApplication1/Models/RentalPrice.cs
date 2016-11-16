using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class RentalPrice
  {
    public decimal PerWeek { get; set; }
    public decimal PerMonth { get; set; }
    public string Accurate { get; set; }
  }
}
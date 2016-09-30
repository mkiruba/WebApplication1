﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class RentalYieldControllerTests
    {
        [TestMethod()]
        public void GetRentalYieldTest()
        {
            string postcode = "IG10";
            string area = "Loughton";

            RentalYieldController controller = new RentalYieldController();
            controller.GetRentalYield(postcode, area);
            Assert.Fail();
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPLayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void FootballPlayerTest()
        {
            FootballPlayer fp = new FootballPlayer();
            fp.Name = "Pedro";
            Assert.AreEqual("Pedro", fp.Name);

            fp.Id = 3;
            Assert.AreEqual(3, fp.Id);

            fp.Price = 150;
            Assert.AreEqual(150, fp.Price);

            fp.ShirtNumber = 5;
            Assert.AreEqual(5, fp.ShirtNumber);
        }

    }
}
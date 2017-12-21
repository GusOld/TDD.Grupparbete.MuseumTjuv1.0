using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Grupparbete.MuseumTjuv1._0;

namespace MuseumTjuvTest1
{
    [TestFixture]
    public class TDD_Grupparbete_Tester
    {
        [Test]
        public void GameTest()
        {
            //Arrange
            int posXY = 1;

            //Act

            Game game = new Game();
            int output = game.gameboard[0, 0];

            //Assert
            Assert.AreEqual(posXY, output);
            
        }
    }
}

using NUnit.Framework;
using Controller;
using Controller.Models;

namespace UnitTest
{
    public class ClassTests
    {
        [SetUp]
        public void Setup()
        {
  
        }

        [Test]
        public void EnemyTest() {          Materials TestMats = new Materials("Steen", rarity: 0);
            Drops TestDrops = new Drops(TestMats, 0, 4);
            Drops[] TestArrayDrops = new Drops[1];
            Enemies enemy = new Enemies("Test", TestArrayDrops);
            if (enemy != null) { Assert.Pass(); } }



    }
}
using NUnit.Framework;
using LastBastion.Model;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Villagers sid = new Villagers(false, 11.6f, 0.5f, "Villageois", 150, 5, 0, false, 2, 0.1f);

            Assert.That(sid, Is.Not.Null);
        }
    }
}
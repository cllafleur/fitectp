using ContosoUniversity.DAL;
using ContosoUniversity.Tests.Tools;
using NUnit.Framework;
using System.Data.Entity;
using System.Linq;

namespace ContosoUniversity.Tests.Controllers
{
    public class Tests : IntegrationTestsBase
    {

        [Test]
        public void MyFirstTest()
        {
            SchoolContext context = new SchoolContext(this.ConnectionString);

            var instructors = context.Instructors.ToList();

            Assert.AreEqual(6, instructors.Count);
        }
    }
}

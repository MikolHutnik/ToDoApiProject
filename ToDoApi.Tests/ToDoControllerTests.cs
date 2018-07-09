using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApi.Controllers;
using ToDoApi.Models;

namespace ToDoApi.Tests
{
    [TestFixture]
    public class ToDoControllerTests
    {
        [Test]
        public void GetAll_Returns_List_Of_Todos()
        {
            var controller = new TodoController();
            var result = controller.GetAll();
            Assert.That(result.Count, Is.EqualTo(1));

        }
        [Test]
        public void Post_Saves_Todo()
        {
            var todo = new Todo();
            var controller = new TodoController();

            controller.Post(todo);
            var result = controller.GetAll();
            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}

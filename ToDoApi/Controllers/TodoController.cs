using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    public class TodoController : ApiController
    {
        private static List<Todo> todos = new List<Todo>()
        {
             {
                new Todo() {Id = 1, Name = "Feed cat", Priority = 1 }
            };
    }
        public List<Todo> GetAll()
        {
            return new List<Todo>()
            {
                new Todo() {Id = 1, Name = "Feed cat", Priority = 1 }
            };
        }

        public void Post(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}

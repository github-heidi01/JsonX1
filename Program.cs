using System;
using System.Collections.Generic;
using JsonX1.Models;
using System.IO;
using System.Threading;

namespace JsonX1
{
    class Program
    {
        static void Main(string[] args)
        {

            TodoItemsContext todos = new TodoItemsContext();
            IEnumerable<TodoItem> todoItems = todos.TodoItems;
            foreach (TodoItem todo in todoItems)
            {
                Console.WriteLine("{0}, {1}, {2}", todo.Id, todo.Name, todo.Done);
            }


            TodoItem td2 = new TodoItem() {
                Id = 2,
                Name = "t2",
                Done = false
            };

            TodoItem td3 = new TodoItem()
            {
                Id = 3,
                Name = "t3",
                Done = true
            };

            IEnumerable<TodoItem> newTodos = new List<TodoItem> { td2, td3 };

            todos.TodoItems = newTodos;


            foreach (TodoItem todo in todoItems)
            {
                Console.WriteLine("{0}, {1}, {2}", todo.Id, todo.Name, todo.Done);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace JsonX1.Models
{
    public class TodoItemsContext
    {
        public TodoItemsContext()
        {
        }

        string path = @"D:\0_workspace\webRazor_X\JsonX1\Data\TodoItems.json";

        public string ToDoItemsString { get; set; }

        public IEnumerable<TodoItem> TodoItems
        {
            get
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    IEnumerable<TodoItem> toDoItems = JsonConvert.DeserializeObject<List<TodoItem>>(jsonString);
                    return toDoItems;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("value must not be null");
                }
                try
                {
                    List<TodoItem> todoItemList = (List<TodoItem>)value;
                    string todoItemListString = JsonConvert.SerializeObject(todoItemList);
                    File.WriteAllTextAsync(path, todoItemListString);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

    }
}

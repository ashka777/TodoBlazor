using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TodoBlazor
{
    public class Todos
    {

        public int Number { get; set; }

        public string Name { get; set; }

        public bool Complited { get; set; }

        public DateTime Date { get; set; }

        public static List<Todos> GetTodos()
        {
            List<Todos> todos = new List<Todos>()
            {
               new Todos{ Number=1, Name = "Создать", Complited = true, Date = DateTime.Now.AddDays(-2)},
               new Todos{ Number=2, Name = "Оформить", Complited = true, Date = DateTime.Now.AddDays(-1)},
               new Todos{ Number=3, Name = "Сохранить", Complited = true, Date = DateTime.Now.AddDays(-1)},
               new Todos{ Number=4, Name = "Показать", Complited = false, Date = DateTime.Now}
            };
            return todos;
        }
    }
}

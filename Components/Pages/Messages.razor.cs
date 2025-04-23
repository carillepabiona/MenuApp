using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Components.Pages
{
    public partial class Messages:ComponentBase
    {
        public string Message { get; set; }
        protected async void Initialized()
        {
            var messageFilePath = FileSystem.AppDataDirectory + "/messages.txt";
            if (!File.Exists(messageFilePath))
            {
                File.WriteAllText(messageFilePath, "Hello World");
            }

            //var readdata = File.ReadAllText(messageFilePath);
            Message = "Hello World";
        }
    }
}

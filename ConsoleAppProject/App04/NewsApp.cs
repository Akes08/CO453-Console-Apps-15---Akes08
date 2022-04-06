using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NewsApp
    {
        public NewsList NewsList { get; set; } = new NewsList();
        string[] choices =
        {
            "Add a Message Post",
            "Add a Photo Post",
            "Display All Post"
        };

        public void Run()
        {
            AddMessage();
        }

        private void AddMessage()
        {
            Console.WriteLine("Please enter your name > ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsList.AddPost(post);
        }
    }
}

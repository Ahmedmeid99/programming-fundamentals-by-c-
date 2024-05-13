using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Event
{
    // Article dataType class
    public class NewsArticle
    {
        public string Title { get; }
        public string Content { get; }

        public NewsArticle(string Title,string Content)
        {
            this.Title = Title;
            this.Content =Content;
        }
    }
    // NewsPublisher

    public class NewsPublisher
    {
        // properties
        // ...

        // Create Evant
        public event EventHandler<NewsArticle> NewNewsPublished;

        public void PublishNews(string Title, string Content)
        {
            OnNewNewsPublished(new NewsArticle(Title, Content));
        }

        // Create protected Method to raise data
        protected virtual void OnNewNewsPublished(NewsArticle newsArticle)
        {
            NewNewsPublished.Invoke(this, newsArticle);
        }  
    }

    // NewsSubscriber
    public class NewsSubscriber
    {
        public string Name { get; } 
        public NewsSubscriber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(NewsPublisher newsPublisher)
        {
            newsPublisher.NewNewsPublished += HandleNewNewsPublished;
        }    
        public void UnSubscribe(NewsPublisher newsPublisher)
        {
            newsPublisher.NewNewsPublished -= HandleNewNewsPublished;
        }

        public void HandleNewNewsPublished(object sender, NewsArticle e)
        {
            Console.WriteLine("NewNewsPublished :. ");
            Console.WriteLine(Name);
            Console.WriteLine("Title : " + e.Title);
            Console.WriteLine("Content : " + e.Content);
            Console.WriteLine();
        }
    }
    //internal class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        NewsPublisher newsPublisher = new NewsPublisher();

    //        NewsSubscriber newsSubscriber = new NewsSubscriber("Ahmed");
    //        NewsSubscriber newsSubscriber2 = new NewsSubscriber("Mohamed");

    //        newsSubscriber.Subscribe(newsPublisher);
    //        newsSubscriber2.Subscribe(newsPublisher);

    //        newsPublisher.PublishNews("React" , "the most frontend library using");
    //        newsPublisher.PublishNews("js" , "the most Scripiting language using");

    //        newsSubscriber2.UnSubscribe(newsPublisher);

    //        newsPublisher.PublishNews("C#" , "my fav programing Language");

    //        Console.ReadKey();

    //    }
    //}
}

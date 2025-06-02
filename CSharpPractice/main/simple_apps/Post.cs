using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _publishDate;
        private int _votes = 0;
       

        public Post(string Title, string Desciption, DateTime PublishDate)
        {
            _title = Title;
            _description = Desciption;
            _publishDate = PublishDate;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
       
        public void UpVote()
        {
           _votes ++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public void DisplayVotes()
        {
            Console.WriteLine($"Votes: {_votes}");
        }

        public void DisplayPost()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Publish Date: {_publishDate.ToShortDateString()}");
            DisplayVotes();
        }
    }
}

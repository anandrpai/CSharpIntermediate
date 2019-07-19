using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime DateCreated = DateTime.Now;

        public Post(string title, string desc)
        {
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(desc))
                throw new ArgumentException();
            Title = title.Trim();
            Description = desc.Trim();
        }

        public void Upvote()
        {
            Votes++;
        }

        public void Downvote()
        {
            Votes--;
        }
    }
}

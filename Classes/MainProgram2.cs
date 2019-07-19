using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var post = new Post("How do I remove a particular element from an array in JavaScript?", "Is there a simple way to remove a specific element from an array? I have to use core JavaScript -no frameworks are allowed.");
                post.Upvote(); post.Upvote(); post.Upvote(); post.Upvote(); post.Upvote();
                Console.WriteLine("Welcome to StackOverflow");
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("Description: {0}", post.Description);
                Console.WriteLine("Press 1 to upvote and 0 to downvote this post.");
                int vote = Convert.ToInt32(Console.ReadLine());
                if (vote == 1)
                {
                    post.Upvote();
                }
                else
                {
                    post.Downvote();
                }

                Console.WriteLine("Votes: {0}", post.Votes);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Post title and description can't be blank.");
            }
            
        }
    }
}

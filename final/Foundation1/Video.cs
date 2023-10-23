using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Video
    {

        public string _title;
        public string _author;
        public int _time;
        public List<Comments> _commentList;

        // Create a method to return the total of comments made by users in the video
        public int GetCommentsTotal()
        {
            return _commentList.Count;
        }

        // Create a method to display the video information and comments
        public void DisplayVideo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Video Length in Seconds: {_time}\n");
            Console.WriteLine("Comments:");

            foreach (Comments comment in _commentList)
            {
                comment.DisplayComments();
            }
            Console.WriteLine("\n");
        }
    }
}
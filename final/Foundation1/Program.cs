using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "PASIEMPRE";
        video1._author = "Tainy";
        video1._time = 358;

        Comments comment1 = new Comments();
        comment1._userName = "Kevin";
        comment1._userComment = "This song is too good! I love it.";

        Comments comment2 = new Comments();
        comment2._userName = "Phillip";
        comment2._userComment = "Puerto Ricans knows how to rap";

        Comments comment3 = new Comments();
        comment3._userName = "Franklin";
        comment3._userComment = "Bad bunny makes the different among them";

        // here I'm adding the comments to a list so it can be display 
        video1._commentList = new List<Comments>();
        {
            video1._commentList.Add(comment1);
            video1._commentList.Add(comment2);
            video1._commentList.Add(comment3);
        }


        Video video2 = new Video();
        video2._title = "How to create a class in c#";
        video2._author = "Bro Code";
        video2._time = 294;

        Comments comment4 = new Comments();
        comment4._userName = "Laurin";
        comment4._userComment = "I learned a lot from this video.";

        Comments comment5 = new Comments();
        comment5._userName = "Peter";
        comment5._userComment = "I think we need more information, is not all well defined.";

        Comments comment6 = new Comments();
        comment6._userName = "Jeremy";
        comment6._userComment = "It was a very helpful video.";

        video2._commentList = new List<Comments>();
        {
            video2._commentList.Add(comment4);
            video2._commentList.Add(comment5);
            video2._commentList.Add(comment6);
        }

        Video video3 = new Video();
        video3._title = "how to make lasagna";
        video3._author = "Gordon Ramsay";
        video3._time = 640;

        Comments comment7 = new Comments();
        comment7._userName = "San";
        comment7._userComment = "I have tried this way and it's better than I thought";

        Comments comment8 = new Comments();
        comment8._userName = "Bruno";
        comment8._userComment = "Thanks for this video! now I can cook a great lasagna for my sister";

        Comments comment9 = new Comments();
        comment9._userName = "Michelle";
        comment9._userComment = "Gordon Ramsay knows how to cook well!";

        video3._commentList = new List<Comments>();
        {
            video3._commentList.Add(comment7);
            video3._commentList.Add(comment8);
            video3._commentList.Add(comment9);
        }


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }

    }
}
using System;

namespace Foundation1
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video { _title = "How to make a baby sleep", _author = "Momma Knows Best", _length = 300 };
        Video video2 = new Video { _title = "10 ways to make amazing smoothies", _author = "Fit4life", _length = 400 };
        Video video3 = new Video { _title = "top ten celebrities in the fashion industry", _author = "keepingupwithKim", _length = 500};
        Video video4 = new Video { _title = "GRWM to go to grocery shopping in London",  _author = "Tara Benson", _length = 600};
        
        video1._comments.Add(new Comment {_name = "Jared Smith", _text = "Thanks for this hack, its works"});
        video1._comments.Add(new Comment {_name = "Maria", _text = "Love this hack"});
        video1._comments.Add(new Comment {_name = "Benita", _text = "It works like magic thanks"});

        video2._comments.Add(new Comment {_name = "Benson", _text = "Thanks, I will try them"});
        video2._comments.Add(new Comment {_name = "Nathan", _text = "I enjoyed the video"});
        video2._comments.Add(new Comment {_name = "Nelly", _text = "Yummy"});

        video3._comments.Add(new Comment {_name = "Jones", _text = "my fav celebrity is Taylor Swift"});
        video3._comments.Add(new Comment {_name = "Rogers", _text = "Good content, keep it up"});
        video3._comments.Add(new Comment {_name = "Nora", _text = "I don't agree with this list"});

        video4._comments.Add(new Comment {_name = "folashade", _text = "You look beautiful"});
        video4._comments.Add(new Comment {_name = "Laura", _text = "I love you content"});
        video4._comments.Add(new Comment {_name = "Fred", _text = "When will you come to Mayfair?"});


        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"\t{comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }

    }
}
}

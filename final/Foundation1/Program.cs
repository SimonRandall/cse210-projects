using System;

namespace Foundation1{
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("video 1", "Billy", "34.4");
        videos.Add(video1);
        Video video2 = new Video("video 2", "Bob", "50");
        videos.Add(video2);
        Video video3 = new Video("video 3", "Joe", "30");
        videos.Add(video3);
        Video video4 = new Video("video 4", "Barthalomew", "120"); 
        videos.Add(video4);

        foreach (Video vid in videos){
            Comment comment = new Comment("George", "first comment");
            vid.addComment(comment);
            Comment comment2 = new Comment ("James", "Why does each video have the same comments?");
            vid.addComment(comment2);
            Comment comment3 = new Comment("Tom", "Because it is so much easier to test and run when there isn't a million different comments");
            vid.addComment(comment3);
        }

        foreach (Video vid2 in videos){
            Console.WriteLine($"Title:{vid2.getTitle()}, Author:{vid2.getAuthor()}, Duration:{vid2.getDuration()}, Number of Comments:{vid2.numberofComments()}");
            vid2.DisplayComments();
            Console.WriteLine();
        }
    }
}
}
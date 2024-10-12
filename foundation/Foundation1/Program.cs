using System;

class Program
{
    static List<Videos> videos = new List<Videos>();
    static void Main(string[] args)
    {
        Videos video1 = new Videos();
        video1._title = "How to make a cake.";
        video1._author = "Betty Crocker";
        video1._length = 1800;
        video1.GetComments("Cathy", "I love chocolate cake!!");
        video1.GetComments("Paul", "Could you make a german chocolate cake next?");
        video1.GetComments("Steve", "I hate cake, why not make a better desert next time.");
        videos.Add(video1);

        Videos video2 = new Videos();
        video2._title = "Tech products that make life easier";
        video2._author = "Steve Jobs";
        video2._length =  1500;
        video2.GetComments("Ethan", "This video sucks!");
        video2.GetComments("Geoff", "Are these products affordable for those who are middle class?");
        video2.GetComments("Morgan", "How much does the phone cost and can I take photos of my family with it?");
        video2.GetComments("Jake", "I love this brand, but do they make cameras for streaming?");
        video2.GetComments("Ben", "I wish you gave a genuine review, you seem bias and like youre getting paid to say positive things about the products.");
        videos.Add(video2);

        Videos video3 = new Videos();
        video3._title = "Snowmobiling in Hawaii gone wrong.";
        video3._author = "Dakine_Bruddah";
        video3._length = 2700;
        video3.GetComments("YoMa", "Oh my goodness I got so worried when you crashed. I hope you're ok!");
        video3.GetComments("FatherDakine", "That flip was epic, too bad you didn't land it.");
        videos.Add(video3);

        foreach(Videos video in videos)
        {
            video.Display();
        }
    }
}
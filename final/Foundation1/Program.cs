using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video v1 = new Video("Product 1", "Author 1", 300);
        v1.AddComment("Juan dela Cruz", "I love this product.");
        v1.AddComment("John Snow", "I bought this product and it's worth every penny!");
        v1.AddComment("Vanessa Lim", "I bought 1 for my husband, and he really loved it!");
        v1.AddComment("JJ Lim", "Definitely buying this product again.");
        _videos.Add(v1);

        Video v2 = new Video("Product 2", "Author 2", 600);
        v2.AddComment("Jollibee", "I bought 3 of this. It's a great product!");
        v2.AddComment("Kenjiro", "This product is hight quality!");
        v2.AddComment("Aurora", "I wish I found this earlier.");
        v2.AddComment("Optimus", "Let's roll out!");
        _videos.Add(v2);

        Video v3 = new Video("Product 3", "Author 3", 450);
        v3.AddComment("Son Goku", "Kamehameha!");
        v3.AddComment("Luffy", "If you don't take risks, you can't create a future.");
        v3.AddComment("Vegeta", "Push through the pain. Giving up hurts more.");
        v3.AddComment("Tanjiro", "The strong should aid and protect the weak. Then, the weak will become strong, and they in turn will aid and protect those weaker than them. That is the law of nature.");
        _videos.Add(v3);

        


        foreach (Video video in _videos)
        {
            video.DisplayVideo();

        }


    }
}
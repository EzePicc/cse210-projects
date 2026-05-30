class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("1: Introduction To C# | What Is C# | C# Tutorial For Beginners", "Dani Krossing", 340);
        video1.AddComment(new Comment("carlos_dev", "This is exactly what I needed to get started, thank you!"));
        video1.AddComment(new Comment("maria_codes", "Very clear and simple explanation."));
        video1.AddComment(new Comment("luis_aprendiz", "Been looking for a good C# intro for weeks, this is the best one."));
        video1.AddComment(new Comment("sofia_it", "Could you make one comparing C# with Java?"));
        videos.Add(video1);


        Video video2 = new Video("2: Installing Visual Studio | Setup Our First Project | C# Tutorial For Beginners", "Dani Krossing", 1204);
        video2.AddComment(new Comment("pedro_mx", "I got stuck on the installation and this video saved me."));
        video2.AddComment(new Comment("ana_coder", "Very well explained step by step, nothing was skipped."));
        video2.AddComment(new Comment("jorge_tech", "Worked perfectly on Windows 11, thanks!"));
        video2.AddComment(new Comment("valeria_dev", "Best installation tutorial I have ever seen."));
        videos.Add(video2);

    Video video3 = new Video("3: How To Create Variables In C# | Data Types In C# | C# Tutorial For Beginners", "Dani Krossing", 657);
        video3.AddComment(new Comment("miguel_csharp", "I finally understand the difference between int and string!"));
        video3.AddComment(new Comment("daniela_learn", "Very useful, I took a lot of notes from this video."));
        video3.AddComment(new Comment("roberto_jr", "The variable examples with real names really helped."));
        videos.Add(video3);


        Video video4 = new Video("4: Help Yourself When Writing C# | VS Object Browser | C# Tutorial For Beginners", "Dani Krossing", 672);
        video4.AddComment(new Comment("lucia_prog", "I had no idea the Object Browser existed, super useful!"));
        video4.AddComment(new Comment("andres_dev", "This tip is going to save me so much time."));
        video4.AddComment(new Comment("camila_it", "Dani always explains things in a very practical way."));
        video4.AddComment(new Comment("tomas_coder", "I wish I had seen this when I first started programming."));
        videos.Add(video4);

    foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title:    {video.GetTitle()}");
            Console.WriteLine($"Author:   {video.GetAuthor()}");
            Console.WriteLine($"Length:   {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
        
    }
}
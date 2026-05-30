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

    
    }
}
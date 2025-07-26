class VideoCreator
{

    private List<Video> _videos;
    private string[] _titles = {
    "You Won’t Believe What Happened Next!",
    "I Tried This So You Don’t Have To",
    "The Truth About This Will Shock You",
    "Top 5 Things You Didn’t Know",
    "What Everyone Gets Wrong About This",
    "This Changed My Life",
    "Watch This Before You Decide",
    "How I Made It in Just One Week",
    "Do This Every Day – It Actually Works",
    "How to Start with Zero Experience",
    "Biggest Mistakes to Avoid",
    "A Day in My Life",
    "This is Why You’re Not Seeing Results",
    "The Ultimate Beginner’s Guide",
    "My Honest Review – No Sugarcoating",
    "How I Went From Beginner to Expert",
    "What No One Tells You",
    "30 Days That Changed Everything",
    "The Secret is Finally Revealed",
    "I Wish I Knew This Sooner"
};
    private string[] _authors = {
    "alexcreates",
    "visualvivi",
    "itsjaydaily",
    "codewithmira",
    "thejakeedit",
    "livlogix",
    "mattmakesmedia",
    "em_oncam",
    "niko.studio",
    "rileyinmotion",
    "artbylena",
    "vlogvanessa",
    "craftycaleb",
    "techtrish",
    "dannyfilmsit",
    "tashatalks",
    "brandonpixels",
    "sofiasnaps",
    "marcus.raw",
    "ellaonedit"
};
    private string[] _comments = {
    "This was super helpful, thank you!",
    "I didn’t even know I needed this!",
    "The editing on this is 🔥",
    "Can’t wait to try this myself!",
    "You earned a new subscriber 🙌",
    "So underrated — this deserves more views!",
    "Your content keeps getting better and better!",
    "I’ve been looking for a video like this all day!",
    "This just saved me hours, thank you!",
    "Can you make a tutorial on this too?",
    "I love your energy and style!",
    "How did you even think of this? Genius!",
    "Please never stop making content like this.",
    "The quality here is next level.",
    "Instant like before even watching it all!",
    "You explained it better than anyone else.",
    "I’ve watched this 3 times already 😅",
    "Why aren’t you more famous?",
    "This deserves to go viral!",
    "Respect for putting this out for free!"
};
    private int _quantity;


    public VideoCreator(int quantity)
    {
        _videos = new List<Video>();
        _quantity = quantity;
        CreateVideos();
    }

    private String GetRandomAuthor()
    {
        return _authors[new Random().Next(_authors.Count())];
    }

    private String GetRandomComment()
    {
        return _comments[new Random().Next(_comments.Count())];
    }

    private String GetRandomTitle()
    {
        return _titles[new Random().Next(_titles.Count())];
    }
    private void AddComments(Video video)
    {
        int comments = new Random().Next(1, 10);
        for (int i = 0; i < comments; i++)
        {
            video.AddComment(GetRandomAuthor(), GetRandomComment());
        }
    }
    private void CreateVideos()
    {
        for (int i = 0; i < _quantity; i++)
        {
            Video video = new Video(GetRandomTitle(), GetRandomAuthor(), new Random().Next(5, 50));
            AddComments(video);
            _videos.Add(video);
        }
    }
    public List<Video> GetVideos()
    {
        return _videos;
    }
}
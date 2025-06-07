using System;

class Program
{
    static void Main(string[] args)
    {

        //Videos creation
        Video gangnamStyle = new Video("Gangnam Style", "PSY", 253);
        Video nyanCat = new Video("Nyan Cat!", "NyanCat", 217);
        Video radioActive = new Video("Radioactive (Cover)", "Lindsey Stirling", 265);
        Video charlieBit = new Video("Charlie bit my finger!", "HDCYT", 56);

        //Storing Comments

        Comment gangnamOne = new Comment("ReLikeVibes", "Now PSY is Back!");
        Comment gangnamTwo = new Comment("BrianBaileyedtech", "When this song came out I used it for my ringtone - it was hilarious. I would get people to call me at work and then the whole department would end up dancing - never gets old!");
        Comment gangnamThree = new Comment("Kuzshika", "Gangnam Style will always be at the top of my list");

        Comment nyanOne = new Comment("PrincessHalo11", "I love the part when he said 'Nyan-Nyan-Nyan' PRICELESS!");
        Comment nyanTwo = new Comment("DrPepper", "It is good to see you again... old friend...");
        Comment nyanThree = new Comment("Jay", "14 years of pure joy.");

        Comment radioOne = new Comment("MorganJade", "We need a collab with her and 2CELLOS. Sign the petition here.");
        Comment radioTwo = new Comment("CactusMan", "my favorite video. still amazing!");
        Comment radioThree = new Comment("Jackie", "One of my Top 5 songs!");

        Comment charlieOne = new Comment("Hooligan27", "THIS WILL STAY FORVERRRRRRR");
        Comment charlieTwo = new Comment("DanRock", "Come on Charlie");
        Comment charlieThree = new Comment("StarDiamond", "The most iconic thing on the internet to ever be conceived.");

        // Storing them in the video 

        gangnamStyle.AddComment(gangnamOne);
        gangnamStyle.AddComment(gangnamTwo);
        gangnamStyle.AddComment(gangnamThree);

        nyanCat.AddComment(nyanOne);
        nyanCat.AddComment(nyanTwo);
        nyanCat.AddComment(nyanThree);

        radioActive.AddComment(radioOne);
        radioActive.AddComment(radioTwo);
        radioActive.AddComment(radioThree);

        charlieBit.AddComment(charlieOne);
        charlieBit.AddComment(charlieTwo);
        charlieBit.AddComment(charlieThree);

        //Creating the list of videos

        var ViralVideos = new List<Video>();

        ViralVideos.Add(gangnamStyle);
        ViralVideos.Add(nyanCat);
        ViralVideos.Add(radioActive);
        ViralVideos.Add(charlieBit);

        foreach (Video videos in ViralVideos)
        {
            videos.GetDisplayText();
        }

    }
}
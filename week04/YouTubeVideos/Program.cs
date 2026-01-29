using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Beauty and Mr. Beast", "Studio C", 309);
        Comment commentA1 = new Comment("@JasLamArr91", "Somehow being trapped with Mr.Beast seems way worse than being with the actual Beast.");
        video1.GetComments(commentA1);
        Comment commentA2 = new Comment("@LadyIronDregon", "Mr Beast turning human beings into inanimate objects against their will and then destroying them (RIP Chandler) seems like a natural progression for him");
        video1.GetComments(commentA2);
        Comment commentA3 = new Comment("@LeahSteup", "The best part was when he said the dishes were former subscribers");
        video1.GetComments(commentA3);
        Comment commentA4 = new Comment("@CrazyCobraCC", "I started cryinig laughing when I saw the -1 over each flower petal");
        video1.GetComments(commentA4);
        video1.DisplayInformation();

        Video video2 = new Video("\nWorst Funeral Director Ever", "Studio C", 216);
        Comment commentB1 = new Comment("@baabaopare-addo5989", "'What are you doing out of your casket' the fact that he said it so nonchalantly");
        video2.GetComments(commentB1);
        Comment commentB2 = new Comment("@TheDailyDoseofSports_817", "I'd be scared if he did weddings");
        video2.GetComments(commentB2);
        Comment commentB3 = new Comment("@damotoneko1500", "Love that the guy in the casket was trying to hold it in but he couldnt stop from smiling.");
        video2.GetComments(commentB3);
        Comment commentB4 = new Comment("@scienceontology", "We offer a two-for-one deal: Are any of you close to dying anytime soon?");
        video2.GetComments(commentB4);
        video2.DisplayInformation();

        Video video3 = new Video("\nThe Hunger Games Musical: Mockingjay | Peeta's Song", "Studio C", 184);
        Comment commentC1 = new Comment("peytonb7100", "the moment you realize Peeta is named after flat bread");
        video3.GetComments(commentC1);
        Comment commentC2 = new Comment("@yasmin-nr1rm", "How to get your crush to like you (Peeta edition):\n1. Listen to her sing\n2. Stalk her\n3. Throw bread at her\n...18. get married and live happily ever after with two children");
        video3.GetComments(commentC2);
        Comment commentC3 = new Comment("@puppypals3305", "Is it socially acceptable for me to have memorized this whole song by heart? Eh, who cares?");
        video3.GetComments(commentC3);
        Comment commentC4 = new Comment("@MilyBakes", "'he's slightly useless but there's no one sweeter' is the most accurate peeta description");
        video3.GetComments(commentC4);
        video3.DisplayInformation();
        
        Video video4 = new Video("\nTop Soccer Shootout Ever With Scott Sterling", "Studio C", 316);
        Comment commentD1 = new Comment("@scottsterling6144", "Years have passed but people didnt forget me wow");
        video4.GetComments(commentD1);
        Comment commentD2 = new Comment("@anonymouslies", "Don't lie this isn't your first time here.");
        video4.GetComments(commentD2);
        Comment commentD3 = new Comment("@Smileandwavelol", "AI will never be able to reach this level of comedy.");
        video4.GetComments(commentD3);
        Comment commentD4 = new Comment("@Colin.Smith.Pianist", "We are ALL Scott Sterling.\nAnd 2020 is the ball.");
        video4.GetComments(commentD4);
        Comment commentD5 = new Comment("@bilalshams9417", "Fifa should hire these commentators");
        video4.GetComments(commentD5);
        video4.DisplayInformation();
    }
}
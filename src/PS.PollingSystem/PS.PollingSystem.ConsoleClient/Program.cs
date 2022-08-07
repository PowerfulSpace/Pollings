using PS.PollingSystem.Application;

var builder = new PollBuilder("Какое расстояние до луны?")
    .AddAnswer(Guid.Parse("39C4385F-C7CB-42AE-8C05-8F632EF42491"), "589м")
    .AddAnswer(Guid.Parse("6A30D62B-433E-4DA8-A341-7883D4AE4B13"), "140км")
    .AddAnswer(Guid.Parse("92AB8794-2B55-4318-8275-51E43B547F78"), "384км")
    .AddAnswer(Guid.Parse("3028BBD3-4213-41CD-BFD2-1289CFCC21C2"), "573км")
    .AddAnswer(Guid.Parse("775D8345-4806-4E90-9166-AE8A17ECC80C"), "984км")
    .AddAnswer(Guid.Parse("7B771BF9-A98D-4A40-B41B-B6E28D407FF4"), "1901км")
    .AddAnswer(Guid.Parse("BAB6635C-A395-49C4-8E23-2D69988CF1A3"), "5872км");

var poll = builder.Build();

poll.VoteTo(Guid.Parse("39C4385F-C7CB-42AE-8C05-8F632EF42491"));
poll.VoteTo(Guid.Parse("6A30D62B-433E-4DA8-A341-7883D4AE4B13"), 7);
poll.VoteTo(Guid.Parse("92AB8794-2B55-4318-8275-51E43B547F78"), 9);
poll.VoteTo(Guid.Parse("3028BBD3-4213-41CD-BFD2-1289CFCC21C2"), 16);
poll.VoteTo(Guid.Parse("775D8345-4806-4E90-9166-AE8A17ECC80C"));
poll.VoteTo(Guid.Parse("7B771BF9-A98D-4A40-B41B-B6E28D407FF4"), 5);
poll.VoteTo(Guid.Parse("BAB6635C-A395-49C4-8E23-2D69988CF1A3"), 25);

//using(var context = new ApplicationDbContext())
//{
//    context.Polls.Add(poll);
//    context.SaveChanges();
//}

var result = builder.GetResults(poll);

Console.WriteLine(result.GetView());
Console.ReadLine();
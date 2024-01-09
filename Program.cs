var stack = new StackOverFlowPost("Title", "Description", DateTime.Now);
while (true)
{
    stack.Post();
    Console.WriteLine("Please upvote or downvote this post");
    var input = Console.ReadLine();

    if (input == "exit")
        break;

    if (!string.IsNullOrEmpty(input))
    {
        stack.Upvote(input);
        stack.Downvote(input);
        stack.Totalvotes(input);
    }
}


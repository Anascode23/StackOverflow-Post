public class StackOverFlowPost
{
    private string _title;
    private int _upvote;
    private int _downvote;
    private string _descrption;
    private DateTime _created;
    private string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    private string Descrption
    {
        get { return _descrption; }
        set { _descrption = value; }
    }
    private DateTime Created
    {
        get { return _created; }
        set { _created = value; }

    }
    private int Upvotes { get { return _upvote; } set { _upvote = value; } }
    private int Downvotes { get { return _downvote; } set { _downvote = value; } }
    public StackOverFlowPost(string title, string description, DateTime created)
    {
        _title = title;
         if(!string.IsNullOrEmpty(Title))
    throw new ArgumentException(Title);
        _descrption = description;
        if(!string.IsNullOrEmpty(Descrption))
    throw new ArgumentException(Descrption);
        Created = created;
    }
    public void Post()
    {
        Console.WriteLine("Created post");
        Console.WriteLine("------------------------");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Description: " + Descrption);
        Console.WriteLine("Created: " + Created);
        Console.WriteLine("------------------------");
    }

    public void Upvote(string userinput)
    {
        if (userinput == "u")
            _upvote++;
    }
    public void Downvote(string userinput)
    {
        if (userinput == "d")
            _downvote++;
    }
    public void Totalvotes(string userinput)
    {
        if (userinput == "votes")
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Total upvotes: " + Upvotes);
            Console.WriteLine("Total downvotes:" + Downvotes);
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }



    }
}

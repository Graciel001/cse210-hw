using System;


class Comment
{
    public string CommenterName { get; set;}
    public string CommentText {get; set;}

    public Comment (string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"Commenter: {CommenterName}");
        Console.WriteLine($"Comment: {CommentText}");
    }
}
using System;

class Comment
{
    public string userComenterName {get ; set;}

    public string commentText {get ; set;}

    public  Comment (string UserComenterName, string CommentText)
    {
        userComenterName = UserComenterName;
        commentText = CommentText;
    }

    public override string ToString()
    {
        return $"{userComenterName}: {commentText}";
    }

    
}
using System;
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count; 
    }

    public override string ToString()
    {
        int minutes = Length / 60;
        int seconds = Length % 60;
        string lengthFormatted = $"{minutes}m {seconds}s";
        return $"Title: {Title}\nAuthor: {Author}\nLength: {lengthFormatted}\nComments: {GetCommentCount()}";
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}

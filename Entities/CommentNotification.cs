namespace Twitter_Clone.Entities;

public class CommentNotification
{
    public class CommentNotificationResponse
    {
        public CommentNotificationResponse(Guid CommentByUserId) : base ("Comment")
        {
            CommentByUserId = CommentByUserId; 
            

        }
        public Guid CommentByUserId { get; set; } 
        public void AddMessage(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }
}
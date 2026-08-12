namespace Twitter_Clone.Entities;

public class Notification :BaseEntity
{
    private Guid _userId;
    private string _type;
    private string _message;
    private bool isRead;

    public Notification(string  notificationType):base(Guid.NewGuid())
    {
        
        
        
    }

    public Guid UserId
    {
        get { return _userId; } 
        set { _userId = value; }
    }

    public string Type
    {
        get { return _type; } 
        set { _type = value; } 
    }

    protected string Message
    {
        get { return _message; } 
        set { _message = value; } 
    }
    public bool IsRead
    {
        get { return isRead; }
        set { isRead = value; } 
        
    }
    
    
}
namespace Twitter_Clone.Entities;

public class Notification :BaseEntity
{
    private Guid _userId;
    private string _type;
    private string _message;
    private bool isRead;

    public Notification()
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
}
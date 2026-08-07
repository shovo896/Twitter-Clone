namespace DefaultNamespace;


public class Tweet
{
    public string  Content { get;private set; }

    public void AddContent(string content)
    {
        if (string.IsNullOrEmpty(content))
        {
            Content = string.Empty;
            // we are done ....sob sikhe kaj korba tumi    
            
            //  khub  eeee important 
        }
    }
}
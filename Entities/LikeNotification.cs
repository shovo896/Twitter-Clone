using TwitterClone.Domain.Entities;

namespace Twitter_Clone.Entities;

public class LikeNotification
{
    public class LikeNotification : Notification
    {
        public  LikeNotification(Guid likeByUserId): base("like")
        {
            LikeByUserId = likeByUserId; 
            

        }
        
        public Guid LikeByUserId { get; set; } 
        public User LikeByUser { get; set; }
        
        
    }
}
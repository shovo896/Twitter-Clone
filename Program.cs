using Twitter_Clone.Entities;
using TwitterClone.Domain.Entities;

var user = new User
{
    FirstName = "Amin",
    LastName = "Hossain",
    Email = "amin@example.com"
};

var tweet = new Tweet("Hello from console app!")
{
    UserId = user.Id
};

var likeNotification = new LikeNotification(user.Id);
likeNotification.AddMessage("Someone liked your tweet.");

var commentNotification = new CommentNotification(user.Id);
commentNotification.AddMessage("Someone commented on your tweet.");

Console.WriteLine(user.DescribeRecord());
Console.WriteLine(tweet.DescribeRecord());
Console.WriteLine(likeNotification.DescribeRecord());
Console.WriteLine(commentNotification.DescribeRecord());

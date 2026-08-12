using System;
using Twitter_Clone.Entities;
using TwitterClone.Domain.Entities;

var user = new User();
var likeNotification = new LikeNotification(user.Id);
likeNotification.AddMessage("Someone liked your tweet.");
Console.WriteLine(likeNotification.DescribeRecord());

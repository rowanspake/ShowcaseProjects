using System;
using TheatreCMS3.Models;

namespace TheatreCMS3.Areas.Blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public ApplicationUser Author { get; set; }
        public string Message { get; set; }
        public DateTime CommentDate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Comment()
        {
            CommentDate = DateTime.Now;
        }

        public double LikeRatio()
        {
            if (Likes + Dislikes == 0)
            {
                return 0;
            }
            return (double)Likes / (Likes + Dislikes) * 100;
        }

        public string TimeSinceCreation()
        {
            var timeSince = DateTime.Now - CommentDate;

            if (timeSince.TotalSeconds < 60)
            {
                return $"{(int)timeSince.TotalSeconds} seconds ago";
            }
            else if (timeSince.TotalMinutes < 60)
            {
                return $"{(int)timeSince.TotalMinutes} minutes ago";
            }
            else if (timeSince.TotalHours < 24)
            {
                return $"{(int)timeSince.TotalHours} hours ago";
            }
            else if (timeSince.TotalDays < 2)
            {
                return "1 day ago";
            }
            else
            {
                return $"{(int)timeSince.TotalDays} days ago";
            }
        }
    }
}
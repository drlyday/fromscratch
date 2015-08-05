using System;
using System.Data.Entity;
using ToyBot.Models;

namespace ToyBot
{
    public class TweetDbInitializer : DropCreateDatabaseAlways<ToyBotDBContext>
    {
        protected override void Seed(ToyBotDBContext context)
        {
            var date = DateTime.Now;
            context.Tweets.Add(
                new Tweet(){User="Dustin",IntelligenceRating = 1, PostTime = date, Post = "What UP!?", Likes = 0});

            context.Tweets.Add(
                new Tweet() { User = "Jufei", IntelligenceRating = 2, PostTime = date.AddDays(-1), Post = "Good Morning", Likes = 1});

            context.Tweets.Add(
                new Tweet() { User = "Benjamin", IntelligenceRating = 3, PostTime = date.AddDays(-2), Post = "Daa-dy?", Likes = 10});
                        
            base.Seed(context);
        }
    }
}
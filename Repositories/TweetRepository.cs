﻿using TwitterCloneAPIUserAuth.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TwitterCloneAPIUserAuth;

namespace TwitterCloneAPIUserAuth.Repositories
{
    public class TweetRepository
    {
        private readonly ApplicationDbContext _context;

        public TweetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Tweet GetById(int tweetId)
        {
            return _context.Tweets.FirstOrDefault(t => t.Id == tweetId);
        }

        public Tweet Create(Tweet tweet)
        {
            _context.Tweets.Add(tweet);
            _context.SaveChanges();
            return tweet;
        }

        // Add additional methods as needed...
    }
}

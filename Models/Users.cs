using System.Collections.Generic;

namespace s9tweets.Models{
    public class User{ 
        public int Id { get; set;}
        public string UserName { get; set; }
        public List<Tweet> Tweets { get; set; }
    }
}
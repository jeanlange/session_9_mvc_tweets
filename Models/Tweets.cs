using System;


namespace s9tweets.Models{
    public class Tweet{
        public int Id {get; set;}
        public int UserId {get; set;}

        public string Text {get; set;}

        public DateTime PostDate {get; set;}

        public User User {get; set;}
    }
}
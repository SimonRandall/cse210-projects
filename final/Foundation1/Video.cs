using System.Collections.Generic;
using System;

namespace Foundation1
{
    public class Video{
        private string title;
        private string author;
        private string duration;
        private List<Comment> comments = new List<Comment>();

        public Video(string name, string creator, string time){
            title = name;
            author = creator;
            duration = time;
        }

        public int numberofComments(){
            int count = comments.Count();
            return count;
        }

        public void addComment(Comment _comment){
            comments.Add(_comment);
        }

        public string getTitle(){
            return title;
        }

        public string getAuthor(){
            return author;
        }

        public string getDuration(){
            return duration;
        }

        public void DisplayComments(){
            foreach (Comment comment in comments){
                comment.getComment();
            }
        }
    }
}
using System;

namespace Foundation1
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public List<Comment>  _comments = new List<Comment>();

        public Video()
        {
            _comments = new List<Comment>();
        }
        public object GetNumberOfComments()
        {
            foreach( Comment comment in _comments)
            {
                comment.Display();
            }

            return _comments.Count;
            
        }
    }

    
        
}
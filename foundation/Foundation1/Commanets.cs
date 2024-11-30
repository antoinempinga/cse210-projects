using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

public class Comment
{
   private string _CommentName;
   private string _text;

   public Comment (string commentName, string text)
   {
    _CommentName = commentName;
    _text = text;
   }
  

     public string DisplayComment()
    {
        return $"{_CommentName}: {_text}";
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Comments
    {
        public string _userName;
        public string _userComment;

        public void DisplayComments()
        {
            Console.WriteLine($"{_userName} - {_userComment}");
        }
    }
}
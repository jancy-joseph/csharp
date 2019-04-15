using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public class staticConstructur
    {
        public static int count = 0;
        //public static Random randomKey;
        static staticConstructur()
        {
            count++;
         //   randomKey = new Random();
        }
        public int Printrandomn()
        {
            return count;
          //  return randomKey.Next();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Question
    {
        public int type { get; set; }//1-blue, 2-red, 3-green, 4-yelow 
        public String question { get; set; }
        public List<String> ansvears { get; set; }
        public int corectAnswear { get; set; }
        public Question(int t, String q, List<String>a, int ca)
        {
            type = t;
            question = q;
            ansvears = a;
            corectAnswear = ca;
        }
    }
}

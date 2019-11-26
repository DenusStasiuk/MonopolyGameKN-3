﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Question
    {
        private int type { get; set; }//1-blue, 2-red, 3-green, 4-yelow 
        private String question { get; set; }
        private List<String> ansvears { get; set; }
        private int corectAnswear { get; set; }
        Question(int t, String q, List<String>a, int ca)
        {
            type = t;
            question = q;
            ansvears = a;
            corectAnswear = ca;
        }
    }
}

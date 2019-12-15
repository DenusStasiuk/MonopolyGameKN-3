using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class Player
    {
        public int number;
        public Vector3 position;
        public List<Vector3> fields = new List<Vector3>();
        public static int rand = 0;
        public static int pos = 0;
        public static bool check_move;
        public GameObject fishka;
        public Player(int n, GameObject o)
        {
            number = n;
            fishka = o;
            fields.Add(new Vector3(61.7f, 23.5f));
            fields.Add(new Vector3(60.4f, 23.5f));
            fields.Add(new Vector3(58.8f, 23.5f));
            fields.Add(new Vector3(57.2f, 23.5f));
            fields.Add(new Vector3(56.2f, 23.5f));
            fields.Add(new Vector3(55.0f, 23.5f));
            fields.Add(new Vector3(53.5f, 23.5f));
            fields.Add(new Vector3(53.5f, 24.9f));
            fields.Add(new Vector3(53.5f, 26.4f));
            fields.Add(new Vector3(53.5f, 27.6f));
            fields.Add(new Vector3(53.5f, 28.7f));
            fields.Add(new Vector3(53.5f, 30.3f));
            fields.Add(new Vector3(53.5f, 31.7f));
            fields.Add(new Vector3(54.9f, 31.7f));
            fields.Add(new Vector3(56.5f, 31.7f));
            fields.Add(new Vector3(57.6f, 31.7f));
            fields.Add(new Vector3(58.8f, 31.7f));
            fields.Add(new Vector3(60.2f, 31.7f));
            fields.Add(new Vector3(61.8f, 31.7f));
            fields.Add(new Vector3(61.8f, 30.3f));
            fields.Add(new Vector3(61.8f, 29.1f));
            fields.Add(new Vector3(61.8f, 28.0f));
            fields.Add(new Vector3(61.8f, 26.45f));
            fields.Add(new Vector3(61.8f, 25.0f));
        }

        public void Move()
        {

        }
    }
}

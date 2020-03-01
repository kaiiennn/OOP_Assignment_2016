//============================================================
// Student Number	: S10170878, S10173513
// Student Name	: Teo Wen Yu Carlsen, Yong Kai En
// Module  Group	: IT03
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class CinemaHall
    {
        public string Name { get; set; }
        public int HallNo { get; set; }
        public int Capacity { get; set; }
        public CinemaHall() { }
        public CinemaHall(string n, int hn, int c)
        {
            Name = n;
            HallNo = hn;
            Capacity = c;
        }
        public override string ToString()
        {
            return "Name: " + Name + "HallNo: " + HallNo + "Capacity: " + Capacity;
        }
    }
}

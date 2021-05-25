using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Sportsman : Person
    {
        protected bool _uniform;
        protected string _sportRank, _gym;
        public Sportsman()
        {
            _uniform = false;
            _sportRank = "";
            _gym = "";
        }
        public Sportsman(bool Uniform)
        {
            _uniform = Uniform;
        }
        public Sportsman(bool Uniform, string SportRank)
        {
            _uniform = Uniform;
            _sportRank = SportRank;
        }
        public Sportsman(bool Uniform, string SportRank, string Gym)
        {
            _uniform = Uniform;
            _sportRank = SportRank;
            _gym = Gym;
        }
        public string SportsmanRank
        {
            get { return _sportRank; }
            set { _sportRank = value; }
        }
        public string Gym
        {
            get { return _gym; }
            set { _gym = value; }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Athlete title: {_sportRank}");
            Console.WriteLine($"Train in gym: {_gym}");
            Console.WriteLine($"Sportsman has got his uniform: {_uniform}");
        }
    }
}

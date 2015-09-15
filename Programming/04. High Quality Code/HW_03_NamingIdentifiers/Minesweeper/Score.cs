using System;

namespace Minesweeper
{
    public class Score
    {
        private string name;
        private int points;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        //Constructors
        public Score() 
        {
        }

        public Score(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoritBall : Ball
    {
        public int TrailObjectTime { get; set; }

        public MeteoritBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjectTime = 3)
            : base(topLeft, speed)
        {
            this.TrailObjectTime = trailObjectTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tail = new List<TrailObject>();
            tail.Add(new TrailObject(this.TopLeft, new char[,] { { '*' } }, this.TrailObjectTime));
            return tail;
        }
    }
}

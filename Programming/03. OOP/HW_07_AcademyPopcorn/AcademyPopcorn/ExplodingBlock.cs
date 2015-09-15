using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public const char Symbol = 'B';
        public new const string CollisionGroupString = "explodingBlock";

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> projectiles = new List<GameObject>();
            char[,] symbol = { { '+' } };

            if (this.IsDestroyed)
            {
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(0, 0)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(0, 1)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(0, -1)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(1, 0)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(1, 1)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(1, -1)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(-1, 0)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(-1, 1)));
                projectiles.Add(new Explosion(this.topLeft, symbol, new MatrixCoords(-1, -1)));
            }
            return projectiles;
        }
    }
}

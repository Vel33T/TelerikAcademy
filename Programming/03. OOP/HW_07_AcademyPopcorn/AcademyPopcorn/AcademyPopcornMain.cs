using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
                
                engine.AddObject(new UnpassableBlock(new MatrixCoords(3, i * 4)));
            }
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow + 1, 6)));
            engine.AddObject(new GiftBlock(new MatrixCoords(startRow + 1, endCol - 2)));

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //Ball theBall = new MeteoritBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //Ball theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            //Engine gameEngine = new Engine(renderer, keyboard);
            ShootingEngine gameEngine = new ShootingEngine(renderer, keyboard, 400);

            //Task 01
            for (int i = 0; i < WorldRows; i++)
            {
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }
            for (int i = 0; i < WorldCols; i++)
            {
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(0, i)));
            }

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            gameEngine.Run();

           
        }
    }
}

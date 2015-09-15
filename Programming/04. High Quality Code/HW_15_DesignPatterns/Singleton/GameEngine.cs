namespace Singleton
{
    using System;

    public class GameEngine
    {
        private static GameEngine gameEngineInstance = null;

        private GameEngine()
        {
            Console.WriteLine("Hi from inside the game engine.");
        }

        public static GameEngine StartGame()
        {
            return new GameEngine();
        }
    }
}

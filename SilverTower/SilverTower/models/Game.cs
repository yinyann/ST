namespace SilverTower.models
{
    public class Game
    {
        public int NbPlayers { get; set; }

        // Singleton non threadSafe - à réparer ?
        #region Singleton
        private static Game _instance;

        public static Game Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Game();
                return _instance;
            }
            private set { _instance = value; }
        }

        private Game()
        {
            NbPlayers = 2;
        }
        #endregion
    }
}

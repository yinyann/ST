using System.Collections.Generic;

namespace SilverTower.models
{
    public class Game
    {
        public static Dictionary<string, string> AvailableHeroesDictionnary { get; set; } = new Dictionary<string, string>
        {
            {"darkoath_chieftain","darkoath chieftain" },
            {"excelsior_warpriest_with_gryph_hound","excelsior warpriest" },
            {"fyreslayer_doomseeker","fyreslayer doomseeker" },
            {"tenebrael_shard","tenebrael shard" },
            {"knight_questor","knight questor" },
            {"mistweaver_saih","mistweaver saih" },
        };

        public int NbPlayers { get; set; }

        public List<string> Heroes { get; }

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
            Heroes = new List<string>();
        }
        #endregion
    }
}

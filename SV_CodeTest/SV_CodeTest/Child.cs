namespace SV_CodeTest
{
    public class Child
    {
        private int _id;
        private bool _ingame;

        // Constructor

        public Child(int id, bool inGame = true)
        {
            this._id = id;
            this._ingame = inGame;
        }

        // Gets name

        public int ID
        {
            get { return _id; }
        }
        public bool InGame
        {
            get { return _ingame; }
            set { _ingame = value; }
        }

    }
}
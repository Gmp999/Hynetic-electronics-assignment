namespace Hello1
{
    class Player
    {
        public string name = "Jimmy";
        private int health = 55;

        public int gethealth()
        {
            return health;
        }
        public void sethealth(int h)
        {
            health = h;
        }
    }
}
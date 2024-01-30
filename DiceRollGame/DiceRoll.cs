class DiceRoll
{
    public int Roll
    {
        get
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
        private set { }
    }
}

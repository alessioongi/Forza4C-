namespace Go4Library
{
    public class PlayField
    {
        public string[,] gameField { get; private set; }

        public PlayField()
        {
            gameField = new string[6, 7];
        }



        public void createField()
        {
            for (int i = 0; i<6;i++)
            {
                for(int y = 0; y < 7; y++)
                {
                        gameField[i,y] = " - ";                 
                }
            }
        }
    }
}
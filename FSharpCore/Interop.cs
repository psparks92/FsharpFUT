namespace FSharpFUT.API 
{
    public static class FSharpInterop
    {
        public static int GetRobbenRating(int a)
        {
            return FSharpCalc.FSharpCalc.GetRobbenRating(a);
        }

        public static int GetLink(int id1, int id2)
        {
            Player player1 = Player.GetById(id1.ToString());
            Player player2 = Player.GetById(id2.ToString());
            var FSharpPlayer1 = Player.GetFSharpPlayerInfo(player1);
            var FSharpPlayer2 = Player.GetFSharpPlayerInfo(player2);
            var quality =  FSharpCalc.FSharpCalc.ComputeLink(FSharpPlayer1, FSharpPlayer2);
            if (quality == FSharpCalc.FSharpCalc.LinkQuality.Perfect) 
                return 3;
            else if (quality == FSharpCalc.FSharpCalc.LinkQuality.Good) 
                return 2;
            else if (quality == FSharpCalc.FSharpCalc.LinkQuality.Okay) 
                return 1;
            else if (quality == FSharpCalc.FSharpCalc.LinkQuality.Bad) 
                return 0;
            else return -1;
        }
    }
}
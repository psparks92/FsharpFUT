
namespace FSharpFUT.API 
{
    public static class FSharpInterop
    {
        public static int GetRobbenRating(int a)
        {
            return FSharpCalc.FSharpCalc.GetRobbenRating(a);
        }
    }
}
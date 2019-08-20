using System;

namespace TcpPressureTest.Win.Utility
{
    public static class UtilityExtension
    {
        public static int ToInt(this string text)
        {
            int i = 0;
            return int.TryParse(text, out i) ? i : 0;
        }
    }
}
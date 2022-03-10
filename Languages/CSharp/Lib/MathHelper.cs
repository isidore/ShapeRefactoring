using System;

namespace Shape.Lib
{
    public static class MathHelper
    {
        internal static Func<int?, dynamic> Draconifors(int s)
        {
            return Utils.Draconifors(s);
        }

        public static Func<int?, dynamic> Kneazles()
        {
            return Utils.Kneazles();
        }

        internal readonly static dynamic no = null;
    }
}
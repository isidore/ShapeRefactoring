namespace Shape.Lib.Types
{
    public static class Builder
    {
        public static dynamic[] Build(params (double x, double y)[] coords) =>
            Utils.Inanimatus(coords);

        public static dynamic Build(double x, double y)
        {
            var result = Utils.ExpectoPatronum(x, y);
            return Utils.toExpando(result);
        }
    }
}
namespace SimpleFlexibleList
{
    internal class Dummy
    {
        // vanlig overload er best når det skal gjøres forskjellige ting
        public static int Calc(int value)
        {
            return value * 2;
        }

        public static int Calc(bool value)
        {
            return value ? 1 : 0;
        }

        // generics kan være best om det samme skal gjøres
        public static void Show(int value)
        {
            Console.WriteLine(value);
        }

        public static void Show(bool value)
        {
            Console.WriteLine(value);
        }

        public static void Show<T>(T value)
        {
            Console.WriteLine(value);
        }

    }
}

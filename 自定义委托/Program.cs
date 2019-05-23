namespace 自定义委托
{
    class Program
    {

        public static int TestInAndOut(ref int b, int a)
        {
            b = 10;
            return a + b;
        }
        static void Main(string[] args)
        {

            var i = 10;
            var result = TestInAndOut(ref i, 20);
        }
    }
}

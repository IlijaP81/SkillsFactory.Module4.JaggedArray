class MainClass
{
    public static void Main(string[] args)
    {
        int[][] jaggedArray = [[1, 2], [1, 2, 3], [1, 2, 3, 4, 5]];

        foreach (var i in jaggedArray)
        {
            foreach (var j in i)
            {
                Console.Write(j + " ");    

            }
        }
    }
}

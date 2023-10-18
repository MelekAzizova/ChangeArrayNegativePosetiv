namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 52, 25, 56, -45, 23, -12, 24, -91 };
            int modul = -1;
            Array(array);
            ChaneArray(array, modul);
            Console.WriteLine("Change array:");
            Array(array);






        }

        static void ChaneArray(int[] array,int modul)
        {
            for(int i=0; i<array.Length; i++)
            {
                if (array[i]<0)
                {
                    array[i]*=modul;
                }
            }
        }
        static void Array(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }

        
    }
}
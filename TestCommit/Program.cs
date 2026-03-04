using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
class Program
{
    static void Resize(char znak, ref int[] array)
    {
        Random random = new Random();
        if (znak == '+')
        {
            Console.WriteLine("Сколько элементов вы хотите добавить?");
            int kolvo = int.Parse(Console.ReadLine());
            int[] newarray = new int[array.Length + kolvo];
            for (int i = 0; i < newarray.Length; i++)
            {
                if (i < array.Length)
                    newarray[i] = array[i];
                if (i >= array.Length)
                    newarray[i] = random.Next(10);

            }
            array = newarray;
        }
        if (znak == '-')
        {
            Console.WriteLine("Сколько элементов вы хотите убрать?");
            int kolvo = int.Parse(Console.ReadLine());
            int[] newarray = new int[array.Length - kolvo];
            for (int i = 0; i < newarray.Length; i++)
            {
                newarray[i] = array[i];

            }
            array = newarray;
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Ваши элементы в массиве : ");
            Random random = new Random();
            int[] myarray = new int[random.Next(2, 10)];
            for (int i = 0; i < myarray.Length; i++)
                myarray[i] = random.Next(20);
            for (int i = 0; i < myarray.Length; i++)
                Console.Write(myarray[i] + "\t");
            Console.WriteLine();
            Console.WriteLine("Если хотите добавить элемент в массив напишите '+'.Если же убрать, то '-' : ");
            char vibor = char.Parse(Console.ReadLine());
            if (vibor == '+' || vibor == '-')
            {
                Resize(vibor, ref myarray);
                Console.WriteLine("Ваш новый массив : ");
                for (int i = 0; i < myarray.Length; i++)
                {
                    Console.Write(myarray[i] + "\t");
                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Введите верную команду!");
                Console.ReadLine();
                continue;
            }
            Console.ReadLine();
        }
    }
}

using System.Runtime.Intrinsics.X86;

namespace Intel8086
{
    internal class Program
    {
        public static string readValue(string input)
        {          
            if(input.Length != 2) 
            {
                Console.WriteLine("Błąd");               
            }
            return input;
        } 
        static void Main(string[] args)
        {
            bool check = true;
            string ax, bx, cx, dx, first, second, third, fourth, temp;
            Console.WriteLine("Podaj wartość rejestru AX:");
            readValue(ax = Console.ReadLine());
            ax = ax.ToUpper();
            Console.WriteLine("Podaj wartość rejestru BX:");
            readValue(bx = Console.ReadLine());
            bx = bx.ToUpper();
            Console.WriteLine("Podaj wartość rejestru CX:");
            readValue(cx = Console.ReadLine());
            cx = cx.ToUpper();
            Console.WriteLine("Podaj wartość rejestru DX:");
            readValue(dx = Console.ReadLine());
            dx = dx.ToUpper();

            while (check)
            {
                Console.Clear();
                Console.WriteLine("Zawartość rejestru AX:" + ax);
                Console.WriteLine("Zawartość rejestru BX:" + bx);
                Console.WriteLine("Zawartość rejestru CX:" + cx);
                Console.WriteLine("Zawartość rejestru DX:" + dx);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Wbierz rodzaj operacji jaką chcesz wykonać.");
                Console.WriteLine("1. MOV");
                Console.WriteLine("2. XCHG");
                Console.WriteLine("3. Zakończ program");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Podaj nazwe rejestru do którego ma zostać skopiowana wartość drugiego wybranego rejestru:");
                        first = Console.ReadLine();
                        first.ToUpper();
                        Console.WriteLine("Podaj wartość rejestru do skopiowania:");
                        second = Console.ReadLine();
                        second.ToUpper();

                        if (first == "AX" && second == "AX")
                            ax = ax;
                        if (first == "AX" && second == "BX")
                            ax = bx;
                        if (first == "AX" && second == "CX")
                            ax = cx;
                        if (first == "AX" && second == "DX")
                            ax = dx;
                        if (first == "BX" && second == "AX")
                            bx = ax;
                        if (first == "BX" && second == "BX")
                            bx = bx;
                        if (first == "BX" && second == "CX")
                            bx = cx;
                        if (first == "BX" && second == "DX")
                            bx = dx;
                        if (first == "CX" && second == "AX")
                            cx = ax;
                        if (first == "CX" && second == "BX")
                            cx = bx;
                        if (first == "CX" && second == "CX")
                            cx = cx;
                        if (first == "CX" && second == "DX")
                            cx = dx;
                        if (first == "DX" && second == "AX")
                            dx = ax;
                        if (first == "DX" && second == "BX")
                            dx = bx;
                        if (first == "DX" && second == "CX")
                            dx = cx;
                        if (first == "DX" && second == "DX")
                            dx = dx;
                        break;

                    case 2:
                        Console.WriteLine("Podaj pierwszy rejestr którego wartości chcesz zamienić:");
                        third = Console.ReadLine();
                        third.ToUpper();
                        Console.WriteLine("Podaj drugi rejestr którego wartości chcesz zamienić:");
                        fourth = Console.ReadLine();
                        fourth.ToUpper();
                        if (third == "AX" && fourth == "AX")
                            ax = ax;
                        if (third == "AX" && fourth == "BX")
                        {
                            temp = ax;
                            ax = bx;
                            bx = temp;
                        }
                        if (third == "AX" && fourth == "CX")
                        {
                            temp = ax;
                            ax = cx;
                            cx = temp;
                        }
                        if (third == "AX" && fourth == "DX")
                        {
                            temp = ax;
                            ax = dx;
                            dx = temp;
                        }
                        if (third == "BX" && fourth == "BX")
                            bx = bx;
                        if (third == "BX" && fourth == "AX")
                        {
                            temp = bx;
                            bx = ax;
                            ax = temp;
                        }
                        if (third == "BX" && fourth == "CX")
                        {
                            temp = bx;
                            bx = cx;
                            cx = temp;
                        }
                        if (third == "BX" && fourth == "DX")
                        {
                            temp = bx;
                            bx = dx;
                            dx = temp;
                        }
                        if (third == "CX" && fourth == "CX")
                            cx = cx;
                        if (third == "CX" && fourth == "AX")
                        {
                            temp = cx;
                            cx = ax;
                            ax = temp;
                        }
                        if (third == "CX" && fourth == "BX")
                        {
                            temp = cx;
                            cx = bx;
                            bx = temp;
                        }
                        if (third == "CX" && fourth == "DX")
                        {
                            temp = cx;
                            cx = dx;
                            dx = temp;
                        }
                        if (third == "DX" && fourth == "DX")
                            dx = dx;
                        if (third == "DX" && fourth == "AX")
                        {
                            temp = dx;
                            dx = ax;
                            ax = temp;
                        }
                        if (third == "DX" && fourth == "BX")
                        {
                            temp = dx;
                            dx = bx;
                            bx = temp;
                        }
                        if (third == "DX" && fourth == "CX")
                        {
                            temp = dx;
                            dx = cx;
                            cx = temp;


                        }
                        break;
                    case 3:
                        check = false;
                        break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string argumet;
            Stack<double> st = new Stack<double>();

            while ((argument = Console.ReadLine()) != "exit")
            {
                double number;
                bool isNumber = double.TryParse(argument, out number);
                if (isNumber)
                    st.Push(number);
                else
                {
                    double op2;
                    switch (argument)
                    {
                        case "+":
                            st.Push(st.Pop() + st.Pop());
                            break;
                        case "*":
                            st.Push(st.Pop() * st.Pop());
                            break;
                        case "-":
                            op2 = st.Pop();
                            st.Push(st.Pop() - op2);
                            break;
                        case "/":
                            op2 = st.Pop();
                            if (op2 != 0.0)
                                st.Push(st.Pop() / op2);
                            else
                                Console.WriteLine("Ошибка. Деление на ноль");
                            break;
                        case "calc":
                            Console.WriteLine("Результат: " + st.Pop());
                            break;
                        default:
                            Console.WriteLine("Ошибка. Неизвестная команда");
                            break;
                    }
                }
            }
        }
    }
}

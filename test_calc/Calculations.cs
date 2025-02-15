namespace test_calc
{
    public class Calculations
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            try
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Возведение в степень\n" +
                    "6. Извлечение корня\n7. Поиск процента от числа\n8. Логарифм числа\n9. Синус\n10. Котангенс");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0 || choice > 10) Console.WriteLine("Неверный номер опреации. Попробуйте снова");
                else
                {
                    Console.WriteLine("Введите числа через пробел:");
                    List<double> list = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToList();
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Результат вычислений: "+ calc.MySum(list));
                            break;
                        case 2:
                            Console.WriteLine("Результат вычислений: " + calc.MyDiff(list));
                            break;
                        case 3:
                            Console.WriteLine("Результат вычислений: " + calc.MyMult(list));
                            break;
                        case 4:
                            Console.WriteLine("Результат вычислений: " + calc.MyDiv(list));
                            break;
                        case 5:
                            Console.WriteLine("Результат вычислений: " + calc.MyDeg(list));
                            break;
                        case 6:
                            Console.WriteLine("Результат вычислений: " + calc.MyRoot(list));
                            break;
                        case 7:
                            Console.WriteLine("Результат вычислений: " + calc.MyProc(list));
                            break;
                        case 8:
                            Console.WriteLine("Результат вычислений: " + calc.MyLog(list));
                            break;
                        case 9:
                            Console.WriteLine("Результат вычислений: " + calc.MySin(list));
                            break;
                        case 10:
                            Console.WriteLine("Результат вычислений: " + calc.MyCot(list));
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine("Попробуйте снова");
            }
        }

        public double MySum(List<double> doubles)
        {
            return doubles.Sum();
        }

        public double MyDiff(List<double> doubles)
        {
            double diff = doubles[0];
            for (int i = 1; i < doubles.Count; i++)
            {
                diff = diff - doubles[i];
            }
            return diff;
        }

        public double MyMult(List<double> doubles)
        {
            double mult = doubles[0];
            for (int i = 1; i < doubles.Count; i++)
            {
                mult = mult * doubles[i];
            }
            return mult;
        }

        public double MyDiv(List<double> doubles)
        {
            double div = doubles[0];
            for (int i = 1; i < doubles.Count; i++)
            {
                if (doubles[i] != 0) div = div / doubles[i];
                else throw new Exception("Ошибка! Деление на ноль невозможно. Перепроверьте числа и попробуйте снова");
            }
            return div;
        }

        public double MyDeg(List<double> doubles)
        {
            if (doubles[0] == 0 && doubles[1] <= 0)
                throw new Exception("Ошибка! 0 нельзя возводить в 0 или отрицательную степень. Перепроверьте числа и попробуйте снова");
            if (doubles[0] < 0 && doubles[1] % 1 != 0)
                throw new Exception("Ошибка! Отрицательное основание нельзя возводить в дробную степень. Перепроверьте числа и попробуйте снова");
            return Math.Pow(doubles[0], doubles[1]);
        }

        public double MyRoot(List<double> doubles)
        {
            if (doubles[1] == 2 && doubles[0] >= 0) return Math.Sqrt(doubles[0]);
            else if (doubles[1] == 3) return Math.Cbrt(doubles[0]);
            else throw new Exception("Ошибка! Извлечение корня невозможно. Перепроверьте числа и попробуйте снова");
        }

        public double MyProc(List<double> doubles)
        {
            return doubles[0] * (doubles[1] / 100);
        }

        public double MyLog(List<double> doubles)
        {
            if (doubles[1] != 1 && doubles[1] > 0 && doubles[0] >= 0) return Math.Log(doubles[0], doubles[1]);
            else throw new Exception("Ошибка! Нахождение логарифма невозможно. Перепроверьте числа и попробуйте снова");
        }

        public double MySin(List<double> doubles)
        {
            return Math.Sin(doubles[0]);
        }

        public double MyCot(List<double> doubles)
        {
            if (Math.Sin(doubles[0]) != 0) return 1 / Math.Tan(doubles[0]);
            else throw new Exception("Ошибка! Нахождение котангенса невозможно. Перепроверьте числа и попробуйте снова");
        }
    }
}

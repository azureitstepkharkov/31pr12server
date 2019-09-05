using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QudraticEquationUnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Схема программирования по принципам TDD (Test Drive Develop)
            //1. Сначала создаётся внешний вид готового кода
            //2. Негативный тест с заглушкрй = показывае как выглядит заглушка
            //3. Рефакторинг кода
            //4. Позитивный тест с заглушкой = показываем как выглядит успех
            //5. Рефакторинг = меняется внешний вид кода (сокращение кол-ва строк: ввод функций, классов и т.д. - устранение дублирования кода)
            //6. Заглушка заменяется на реальный код (реальная формула) для негативного теста 
            //7. Заглушка заменяется на реальный код для позитивного теста 
            //8. Рефакторинг тестов: эталонный лог тестирования
            double A;
            double B;
            double C;
            double x1;
            double x2;
            string msg = String.Empty;

            bool result;
            StringBuilder log = new StringBuilder();
            CalcSolutionTest1_1_minus_7_12_NoReturned(out A, out B, out C, out x1, out x2, out msg, out result, log);

            CalcSolutionTest2_1_minus_7_14_NoReturned(out A, out B, out C, out x1, out x2, out msg, out result, log);

            msg = CheckLog(msg, log);

            Console.WriteLine(msg);
            Console.WriteLine("Press any key");
            Console.ReadKey(true);
        }

        public static string CheckLog(string msg, StringBuilder log)
        {
            string logEtalon = "Корней нет";
            if (String.CompareOrdinal(log.ToString(), logEtalon) == 0)
            {
                msg = "Все тесты прошли успешно";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Регрессивные тесты не выполнены");
                sb.AppendLine("Ожидаю.");
                sb.AppendLine(logEtalon);
                sb.AppendLine("Пришло:");
                sb.AppendLine(msg);

                msg = sb.ToString();
            }
            log.Append(msg);
            return msg;
        }

        public static void CalcSolutionTest2_1_minus_7_14_NoReturned(out double A, out double B, out double C, out double x1, out double x2, out string msg, out bool result, StringBuilder log)
        {
            A = 1;
            B = -7;
            C = 14;
            QuadraticEquation qe2 = new QuadraticEquation(A, B, C);
            result = qe2.calc(out x1, out x2);
            msg = TestResult(x1, x2, result, log);
        }

        public static void CalcSolutionTest1_1_minus_7_12_NoReturned(out double A, out double B, out double C, out double x1, out double x2, out string msg,out bool result, StringBuilder log)
        {
            A = 1;
            B = -7;
            C = 12;
            QuadraticEquation qe1 = new QuadraticEquation(A, B, C);

            result = qe1.calc(out x1, out x2);
            log = new StringBuilder();
            msg = TestResult(x1, x2, result, log);
        }

        public static string TestResult(double x1, double x2, bool result, StringBuilder log)
        {
            string msg;
            if (result)
            {
                msg = $"X1={x1}, X2={x2}";
            }
            else
            {
                msg = "Корней нет";
            }
            log.AppendLine(msg);
            return msg;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assert.AreNotEqual<double>(0.0, A, "A==0");
            //
            //Схема программирования по принципам TDD (Test Drive Develop)
            //1. Сначала создаётся внешний вид готового кода
            //2. Негативный тест с заглушкрй = показывае как выглядит заглушка
            //3. Рефакторинг кода
            //4. Позитивный тест с заглушкой = показываем как выглядит успех
            //5. Рефакторинг = меняется внешний вид кода (сокращение кол-ва строк: ввод функций, классов и т.д. - устранение дублирования кода)
            //6. Заглушка заменяется на реальный код (реальная формула) для негативного теста 
            //7. Заглушка заменяется на реальный код для позитивного теста 
            //8. Рефакторинг тестов: эталонный лог тестирования
            //
            double A = 1;
            double B = -7;
            double C = 14;
            bool result = false;
            String msg = String.Empty;
            double X1;
            double X2;
            QuadraticEquation qE1 = new QuadraticEquation(A, B, C);
            result = qE1.calc(out X1, out X2);
            StringBuilder log = new StringBuilder();
            msg = testResult(X1, X2, result, log);
            A = 1;
            B = -7;
            C = 12;
            QuadraticEquation qE2 = new QuadraticEquation(A, B, C);
            result = qE2.calc(out X1, out X2);
            msg = testResult(X1, X2, result, log);

            string logEtalon = "Корней нет.X1=3, X2=4";
            if (String.CompareOrdinal(logEtalon, log.ToString()) == 0)
            {
                msg = "Все тесты выполнены без ошибок!";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Регрессивные тесты не выполнены.");
                sb.AppendLine("Ожидаю:");
                sb.AppendLine(logEtalon);
                sb.AppendLine("Пришло:");
                sb.AppendLine(log.ToString());
                msg = sb.ToString();
            }

            Console.WriteLine(msg);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static string testResult(double X1, double X2, bool result, StringBuilder log)
        {
            string msg;
            if (result == false)
            {
                msg = "Корней нет.";
            }
            else
            {
                msg = String.Format("X1={0}, X2={1}", X1, X2);
            }
            log.Append(msg);
            return msg;
        }
    }
}

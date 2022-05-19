using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLimp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //случайное заполнение класса
            int kol_judges = rnd.Next(3, 10); // кол-тво судей
            int kol_figuresk = rnd.Next(10, 100); // кол-во фигуристов
            int[,] chempionat = new int[kol_figuresk, kol_judges]; // вводные данные
            double[] grade = new double[kol_judges]; // оценки участника
            double min_grade = 10;
            double max_grade = 0;
            int number_min_grade = 0;
            int number_max_grade = 0;

            for (int i = 0; i < 1; i++) // счет для каждого фигуриста
            {
                do
                {
                    min_grade = 10; 
                    max_grade = 0; // обнуляем значения

                    for (int j = 0; j < kol_judges; j++) // все участники жюри участвуют
                    {
                        grade[j] = (rnd.Next(-0, 100) / 10.0); // даем оценку

                        if (min_grade > grade[j]) // поиск минимальное
                        {
                            min_grade = grade[j];
                            number_min_grade = j;
                        }

                        if (max_grade < grade[j]) // поиск максимальное
                        {
                            max_grade = grade[j];
                            number_max_grade = j;
                        }
                    }
                }
                while (!(number_min_grade == grade[kol_judges - 1]) & !(number_min_grade == grade[kol_judges - 2]) & !(number_max_grade == grade[kol_judges - 1]) & !(number_max_grade == grade[kol_judges - 2])); // проверяем не являестя ли последнее и предпоследнее числа минимальным или максиммальным
                for (int n = 0; n < kol_judges; n++) Console.WriteLine(grade[n]);
                grade[number_min_grade] = grade[kol_judges - 1]; // замена минимальной оценки последним числом
                grade[number_max_grade] = grade[kol_judges - 2]; // замена максимальной оценки последним числом
                double summ = 0;
                double sred = 0;
                for (int n = 0; n < kol_judges - 2; n++) summ += grade[n]; // сумма всех оценок
                sred = summ / (kol_judges - 2); // среднее число от оценок
                Console.WriteLine(" Фигурист под номером " + (i + 1) + " набрал " + Math.Round(sred, 1) + " очков."); // ответ
            }
        }
    }
}
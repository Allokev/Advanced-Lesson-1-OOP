using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public static class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Shape[,] matrix = new Shape[3, 10];

            for (int i = 0; i < 10; i++)
            {
                matrix[0, i] = new Circle(i);
                matrix[1, i] = new Rectangle(i, i);
                matrix[2, i] = new Triangli(i, i);

            }

            for (int i = 0; i <= matrix.Rank; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{matrix[i, j].GetSquare(),5}    ");
                }
                Console.WriteLine();


            }

        }
        public  class Shape
        {
            public virtual double GetSquare()
            {
                return 0;
            }
            
        }

        public class Circle : Shape
        {
            private int _radious;

            public Circle(int radious)
            {
                this._radious = radious;
            }

            public override double GetSquare()
            {
                return Math.Round(Math.PI * _radious * _radious, 1);
            }
        }

        public class Rectangle : Shape
        {
            private int height;
            private int wight;

            public Rectangle(int _height, int _wight)
            {
                this.height = _height;
                this.wight = _wight;
            }

            public override double GetSquare()
            {
                return height*wight;
            }
        }

        public class Triangli : Shape
        {
            private int height;
            private int basement;

            public Triangli(int _height, int _basement)
            {
                this.height = _height;
                this.basement = _basement;
            }

            public override double GetSquare()
            {
                double v = 0.5;
                return v*height*basement;
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {

        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
            
        }


        
    }
}

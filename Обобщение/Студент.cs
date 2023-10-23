using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщение
{

    /// <summary>
    /// Класс студент
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Студент<T>
    {

        /// <summary>
        /// Имя студента
        /// </summary>
        public string Имя { get; set; }

        /// <summary>
        /// Оценка студента
        /// </summary>
        public T Оценка { get; set; }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="имя"></param>
        /// <param name="оценка"></param>
        public Студент(string имя, T оценка)
        {
            Имя = имя;
            Оценка = оценка;
        }


        /// <summary>
        /// Метод показывает информацию о студенте
        /// </summary>
        public void ПоказатьИнформацию()
        {
            Console.WriteLine($"Студент: {Имя}, Оценка: {Оценка}");
        }
    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static List<string> taskList = new List<string>();
    

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите опцию");//интерфейс/нумерация чего пользователь хочет
            Console.WriteLine("1. Добавить задание");
            Console.WriteLine("2. Изменить задание");
            Console.WriteLine("3. Удалить задание");
            Console.WriteLine("4. Посмотреть список заданий");

            int choice = Convert.ToInt32(Console.ReadLine());// переменная для свитч, конвертируем из строки в инт

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    UpdateTask();
                    break;
                case 3:
                    RemoveTask();
                    break;
                case 4:
                    ViewList();
                    break;
                default: Console.WriteLine("Выбран неверный индекс");
                    break;
            }

        }

        static void AddTask()// метод добавления задания
        {
            Console.WriteLine("Введите новое задание:");
            string newTask = Console.ReadLine();
            taskList.Add(newTask);// Добавляем в лист задание написаное пользователем
            Console.WriteLine("Задание добавленно к списку");
        }

        static void UpdateTask()//метод для изменения задания
        {
            Console.WriteLine("Введите индекс задания, которое надо найти:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            

            if (index >= 0 && index < taskList.Count)//если индекс больше или равно 0 или индекс меньше листа.количества
            {
                Console.WriteLine("Введите новый текст задания");
                string updatedTask = Console.ReadLine();
                taskList[index] = updatedTask;// обращаемся в листтаск индекс обновляем текст
                Console.WriteLine("Задания обновленны");
            }
            else
            {
                Console.WriteLine("Не верный индекс");
            }
        }

        static void RemoveTask()// метод для удаления из списка
        {
            Console.WriteLine("Введите индекс задания, которое нужно удалить");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < taskList.Count)
            {
                taskList.RemoveAt(index);// используем функцию RemoveAt для удаления из списка под определенным индексом
                Console.WriteLine("Задание удаленно");
            }
            else { Console.WriteLine("Не верный индекс"); }
        }

        static void ViewList()// метод для просмотра заданий из списка
        {
            Console.WriteLine("Список заданий:");

            for (int i = 0; i < taskList.Count; i++)// специальный цыкл фор для вывода текста/i меньше листа
            {
                Console.WriteLine($"{i + 1}.{taskList[i]}");
            }

            Console.WriteLine();//для красоты
        }

    }
}

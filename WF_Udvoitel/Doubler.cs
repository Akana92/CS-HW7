using System;
using System.Collections.Generic;

namespace WF_Udvoitel
{
    public delegate void reverseFunc();

    class Doubler
    {
        int value;
        int steps;
        int goal;

        Stack<reverseFunc> operations = new Stack<reverseFunc>();

        new Random rand = new Random();

        //Возвращает текущее значение поля value
        public int Value { get { return this.value; } }
        //Возвращает текущее значение поля steps
        public int Steps { get { return this.steps; } }
        //Возвращает текущее значение поля goal
        public int Goal { get { return this.goal; } }
      
        //Конструктор присваивает всем полям значение 0
        public Doubler()
        {
            this.value = 0;
            this.steps = 0;
            this.goal = 0;
        }

        //Функция инкремента
        public void Increment()
        {
            this.value++;
            this.steps++;
            operations.Push(new reverseFunc(Decrement));
        }

        //Функция удваивания
        public void Double()
        {
            this.value *= 2;
            this.steps++;
            operations.Push(new reverseFunc(DivideByTwo));
        }

        //Функция декремента
        public void Decrement()
        {
            this.value--;
            this.steps--;
        }

        //Функция деления на два
        public void DivideByTwo()
        {
            this.value /= 2;
            this.steps--;
        }

        //Функция отмены действия
        public void CheckStack()
        {
            reverseFunc reverseFunc;
            if (operations.Count != 0)
            {
                reverseFunc = operations.Pop();
                reverseFunc();
            }
            return;
        }

        //Функция сброса текущего значения и счётчика шагов
        public void Reset()
        {
            this.value = 1;
            this.steps = 0;
            operations.Clear();
        }

        //Функция генерации целевого значения
        public void GetGoal()
        {
            this.goal = rand.Next(2, 2049);
        }

        //Функция проверки текущего значения с целевым
        public bool CheckGoal()
        {
            return this.value == this.goal ? true : false;
        }
    }
}

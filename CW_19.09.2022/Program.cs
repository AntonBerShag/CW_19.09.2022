using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_19._09._2022
{
    delegate void myDelegate(string _str);
    class PC
    {
        public string Name;
        private string nameOfDisplay, nameOfPCBox, nameOfKeyboard, nameOfMouse, empty = "<none>";
        public myDelegate myAction;
        private struct Example
        {

        }

        public PC()
        {
            Console.WriteLine("Введите имя ПК : ");
            Name = Console.ReadLine();
            nameOfDisplay = nameOfPCBox = nameOfKeyboard = nameOfMouse = empty;
        }
        public void PC_menu(int _number, string _name)
        {
            if (_number == 1)
            {
                myAction += addDisplay;
                Print(_name);
            }
        }
        private void Print(string _text)
        {
            myAction(_text);
        }
        public void addDisplay(string nameOfDisplay)
        {
            this.nameOfDisplay = nameOfDisplay;
            Console.WriteLine("К рабочему месту добавлен монитор {0}.", nameOfDisplay);

        }
        public void minusDisplay(string nameOfDisplay)
        {
            if (this.nameOfDisplay == nameOfDisplay)
            {
                this.nameOfDisplay = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfDisplay);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfDisplay);
            }


        }
        public void addPCBox(string nameOfPCBox)
        {
            this.nameOfPCBox = nameOfPCBox;
            Console.WriteLine("К рабочему месту добавлен системный блок {0}.", nameOfPCBox);
        }
        public void addKeyboard(string nameOfKeyboard)
        {
            this.nameOfKeyboard = nameOfKeyboard;
            Console.WriteLine("К рабочему месту добавлена клавиатура {0}.", nameOfKeyboard);
        }
        public void addMouse(string nameOfMouse)
        {
            this.nameOfMouse = nameOfMouse;
            Console.WriteLine("К рабочему месту добавлена мышь {0}.", nameOfMouse);
        }


    }

    class workPlace
    {
        private string nameOfDisplay;
        class sysUnit
        {
            private bool active;

        }

        class Monitor
        {
            private bool active;
            private string nameOfMonitor;
            public void addDisplay(string nameOfMonitor, bool active = true)
            {
                this.nameOfMonitor = nameOfMonitor;
                this.active = active;
                Console.WriteLine("К рабочему месту добавлен монитор {0}.", nameOfMonitor);

            }
        }

        class Kayboard
        {
            private bool active;
            private string nameOfKeyboard;
            public void addKeyboard(string nameOfKeyboard, bool active = true)
            {
                this.nameOfKeyboard = nameOfKeyboard;
                this.active = active;
                Console.WriteLine("К рабочему месту добавлена клавиатура {0}.", nameOfKeyboard);
            }

        }

        class Mouse
        {
            private bool active;
            private string nameOfMouse;
            public void addMouse(string nameOfMouse, bool active = true)
            {
                this.nameOfMouse = nameOfMouse;
                this.active = active;
                Console.WriteLine("К рабочему месту добавлена мышь {0}.", nameOfMouse);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var myPC = new PC();
            myPC.PC_menu(1, "Samsung");
            Console.ReadKey();
        }
    }
}

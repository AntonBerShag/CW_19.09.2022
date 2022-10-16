using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CW_19._09._2022
{
    public abstract class Component
    {
        //public abstract void PC_menu();
        public abstract void addComponent(string component);
        public abstract void deleteComponent(string component);
        public abstract void changeComponent(string component);
        public abstract void toFile();
        public abstract void toRead();
    }

    class PcBox : Component
    {
        private string nameOfPcBox, nameOfMotherboard, nameOfMemory, nameOfProcessor, nameOfSsd, empty = null;

        public override void addComponent(string component)
        {
            if (this.nameOfPcBox != null)
            {
                Console.WriteLine("У рабочего места есть системный блок {0}.", this.nameOfPcBox);
                return;
            }
            this.nameOfPcBox = component;
            Console.WriteLine("К рабочему месту добавлен системный блок {0}.", component);
        }
        public override void changeComponent(string component)
        {
            if (this.nameOfPcBox == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте системный блок.");
                return;
            }
            this.nameOfPcBox = component;
            Console.WriteLine("Системный блок изменен {0}.", component);
        }
        public override void deleteComponent(string component)
        {
            if (this.nameOfPcBox == component)
            {
                this.nameOfPcBox = empty;
                Console.WriteLine("От рабочего места забран системный блок {0}.", nameOfPcBox);
            }
            else
            {
                Console.WriteLine("У рабочего места нет системного блока {0}.", nameOfPcBox);
            }
        }
        // материнская плата
        public void addMotherboard(string motherboard)
        {
            if (this.nameOfMotherboard != null)
            {
                Console.WriteLine("У системного блока есть материнская плата {0}.", this.nameOfMotherboard);
                return;
            }
            this.nameOfMotherboard = motherboard;
            Console.WriteLine("В системный блок добавлена материнская плата {0}.", motherboard);
        }
        public void changeMotherboard(string newMotherboard)
        {
            if (this.nameOfMotherboard == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте материнскую плату.");
                return;
            }
            this.nameOfMotherboard = newMotherboard;
            Console.WriteLine("Материнская плата изменена на {0}.", nameOfMotherboard);
        }
        public void deleteMotherboard(string motherboard)
        {
            if (this.nameOfMotherboard == motherboard)
            {
                this.nameOfMotherboard = empty;
                Console.WriteLine("От рабочего места забрана материнская плата {0}.", nameOfMotherboard);
            }
            else
            {
                Console.WriteLine("У рабочего места нет материнской платы {0}.", nameOfMotherboard);
            }
        }
        //память
        public void addMemory(string memory)
        {
            if (this.nameOfMemory != null)
            {
                Console.WriteLine("У системного блока есть память {0}.", this.nameOfMemory);
                return;
            }
            this.nameOfMemory = memory;
            Console.WriteLine("В системный блок добавлена память {0}.", memory);
        }
        public void changeMemory(string newMemory)
        {
            if (this.nameOfMemory == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте память.");
                return;
            }
            this.nameOfMemory = newMemory;
            Console.WriteLine("Память изменена на {0}.", nameOfMemory);
        }
        public void deleteMemory(string memory)
        {
            if (this.nameOfMemory == memory)
            {
                this.nameOfMotherboard = empty;
                Console.WriteLine("От рабочего места забран системный блок {0}.", nameOfMemory);
            }
            else
            {
                Console.WriteLine("У рабочего места нет системного блока {0}.", nameOfMemory);
            }
        }
        //процессор
        public void addProcessor(string processor)
        {
            if (this.nameOfProcessor != null)
            {
                Console.WriteLine("У системного блока есть процессор {0}.", this.nameOfProcessor);
                return;
            }
            this.nameOfProcessor = processor;
            Console.WriteLine("В системный блок добавлен процессор {0}.", processor);
        }
        public void changeProcessor(string newProcessor)
        {
            if (this.nameOfProcessor == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте процессор.");
                return;
            }
            this.nameOfProcessor = newProcessor;
            Console.WriteLine("Процессор изменен на {0}.", nameOfProcessor);
        }
        public void deleteProcessor(string processor)
        {
            if (this.nameOfProcessor == processor)
            {
                this.nameOfMotherboard = empty;
                Console.WriteLine("От рабочего места забран системный блок {0}.", nameOfProcessor);
            }
            else
            {
                Console.WriteLine("У рабочего места нет системного блока {0}.", nameOfProcessor);
            }
        }
        //ssd
        public void addSsd(string ssd)
        {
            if (this.nameOfSsd != null)
            {
                Console.WriteLine("У системного блока есть SSD {0}.", this.nameOfSsd);
                return;
            }
            this.nameOfSsd = ssd;
            Console.WriteLine("В системный блок добавлен SSD {0}.", ssd);
        }
        public void changeSsd(string newSsd)
        {
            if (this.nameOfSsd == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте SSD.");
                return;
            }
            this.nameOfSsd = newSsd;
            Console.WriteLine("SSD изменена на {0}.", nameOfSsd);
        }
        public void deleteSsd(string ssd)
        {
            if (this.nameOfSsd == ssd)
            {
                this.nameOfMotherboard = empty;
                Console.WriteLine("От рабочего места забран системный блок {0}.", nameOfSsd);
            }
            else
            {
                Console.WriteLine("У рабочего места нет системного блока {0}.", nameOfSsd);
            }
        }
        public override void toFile()
        {
            string _path = "PC.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Системный блок: {0}", this.nameOfPcBox);
            sw.WriteLine("Материнская плата: {0}", this.nameOfMotherboard);
            sw.WriteLine("Память: {0}", this.nameOfMemory);
            sw.WriteLine("Процессор: {0}", this.nameOfProcessor);
            sw.WriteLine("SSD: {0}", this.nameOfSsd);
            sw.Close();
        }
        public override async void toRead()
        {
            string _path = "PC.txt";
            using (StreamReader reader = new StreamReader(_path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    class Monitor : Component
    {
        private string nameOfMonitor1, nameOfMonitor2, nameOfMonitor3, empty = null;

        public override void addComponent(string component)
        {
            if (this.nameOfMonitor1 != null)
            {
                Console.WriteLine("У рабочего места есть монитор {0}.", nameOfMonitor1);
                return;
            }
            this.nameOfMonitor1 = component;
            Console.WriteLine("К рабочему месту добавлен монитор {0}.", component);
        }
        public override void changeComponent(string component)
        {
            if (this.nameOfMonitor1 == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте монитор.");
                return;
            }
            this.nameOfMonitor1 = component;
            Console.WriteLine("Монитор изменен {0}.", nameOfMonitor1);
        }
        public override void deleteComponent(string component)
        {
            if (this.nameOfMonitor1 == component)
            {
                this.nameOfMonitor1 = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfMonitor1);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfMonitor1);
            }
        }
        public void addMonitor2(string monitor)
        {
            if (this.nameOfMonitor2 != null)
            {
                Console.WriteLine("У рабочего места есть второй монитор {0}.", nameOfMonitor2);
                return;
            }
            this.nameOfMonitor2 = monitor;
            Console.WriteLine("К рабочему месту добавлен второй монитор {0}.", nameOfMonitor2);
        }
        public void changeMonitor2(string newMonitor2)
        {
            if (this.nameOfMonitor2 == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте второй монитор.");
                return;
            }
            this.nameOfMonitor2 = newMonitor2;
            Console.WriteLine("Второй монитор изменен {0}.", newMonitor2);
        }
        public void deleteMonitor2(string monitor)
        {
            if (this.nameOfMonitor2 == monitor)
            {
                this.nameOfMonitor2 = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfMonitor2);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfMonitor2);
            }
        }
        public void addMonitor3(string monitor)
        {
            if (this.nameOfMonitor3 != null)
            {
                Console.WriteLine("У рабочего места есть второй монитор {0}.", nameOfMonitor3);
                return;
            }
            this.nameOfMonitor3 = monitor;
            Console.WriteLine("К рабочему месту добавлен второй монитор {0}.", nameOfMonitor3);
        }
        public void changeMonitor3(string newMonitor3)
        {
            if (this.nameOfMonitor3 == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте третий монитор.");
                return;
            }
            this.nameOfMonitor3 = newMonitor3;
            Console.WriteLine("Третий монитор изменен {0}.", newMonitor3);
        }
        public void deleteMonitor3(string monitor)
        {
            if (this.nameOfMonitor3 == monitor)
            {
                this.nameOfMonitor3 = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfMonitor3);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfMonitor3);
            }
        }
        public override void toFile()
        {
            string _path = "PC.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Монитор: {0}", this.nameOfMonitor1);
            if (this.nameOfMonitor2 != null)
                sw.WriteLine("Второй монитро: {0}", this.nameOfMonitor2);
            if (this.nameOfMonitor3 != null)
                sw.WriteLine("Третий монитор: {0}", this.nameOfMonitor3);
            sw.Close();
        }
        public override async void toRead()
        {
            string _path = "PC.txt";
            using (StreamReader reader = new StreamReader(_path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    class Kayboard : Component
    {
        private string nameOfKeyboard, empty = null;

        public override void addComponent(string component)
        {
            if (this.nameOfKeyboard != null)
            {
                Console.WriteLine("У рабочего места есть клавиатура {0}.", nameOfKeyboard);
                return;
            }
            this.nameOfKeyboard = component;
            Console.WriteLine("К рабочему месту добавлена клавиатура {0}.", nameOfKeyboard);
        }
        public override void changeComponent(string component)
        {
            if (this.nameOfKeyboard == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте клавиатуру.");
                return;
            }
            this.nameOfKeyboard = component;
            Console.WriteLine("Клавиатура изменена {0}.", nameOfKeyboard);
        }
        public override void deleteComponent(string component)
        {
            if (this.nameOfKeyboard == component)
            {
                this.nameOfKeyboard = empty;
                Console.WriteLine("От рабочего места забрана клавиатура {0}.", nameOfKeyboard);
            }
            else
            {
                Console.WriteLine("У рабочего места нет клавиатуры {0}.", nameOfKeyboard);
            }
        }
        public override void toFile()
        {
            string _path = "PC.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Монитор: {0}", this.nameOfKeyboard);
            sw.Close();
        }
        public override async void toRead()
        {
            string _path = "PC.txt";
            using (StreamReader reader = new StreamReader(_path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    class Mouse : Component
    {
        private string nameOfMouse, empty = null;

        public override void addComponent(string component)
        {
            if (this.nameOfMouse != null)
            {
                Console.WriteLine("У рабочего места есть мышка {0}.", nameOfMouse);
                return;
            }
            this.nameOfMouse = component;
            Console.WriteLine("К рабочему месту добавлена мышь {0}.", component);
        }
        public override void changeComponent(string component)
        {
            if (this.nameOfMouse == null)
            {
                Console.WriteLine("Компонент отсутствует.\nДобавте мышку.");
                return;
            }
            this.nameOfMouse = component;
            Console.WriteLine("Мышка изменена {0}.", nameOfMouse);
        }
        public override void deleteComponent(string component)
        {
            if (this.nameOfMouse == component)
            {
                this.nameOfMouse = empty;
                Console.WriteLine("От рабочего места забрана мышка {0}.", nameOfMouse);
            }
            else
            {
                Console.WriteLine("У рабочего места нет мышки {0}.", nameOfMouse);
            }
        }
        public override void toFile()
        {
            string _path = "PC.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Монитор: {0}", this.nameOfMouse);
            sw.Close();
        }
        public override async void toRead()
        {
            string _path = "PC.txt";
            using (StreamReader reader = new StreamReader(_path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myPcBox = new PcBox();
            var myMonitor = new Monitor();
            var myKeyboar = new Kayboard();
            var myMouse = new Mouse();

            string answerMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберете опцию(для выбора введите цифру):\n" +
                "1 - Добавить/изменить системный блок\n" +
                "2 - Добавить/изменить монитор\n" +
                "3 - Добавить/изменить клавиатуру\n" +
                "4 - Добавить/изменить мышь\n" +
                "5 - Вывести список комплектующих\n" +
                "0 - Выход");
                answerMenu = Console.ReadLine();
                // 1
                if (answerMenu == "1")
                {
                    string answerPc;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Добавить компоненты\n" +
                            "2 - Изменить компоненты\n" +
                            "0 - Выход");
                        answerPc = Console.ReadLine();
                        if (answerPc == "1")
                        {
                            string answerAdd;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1 - Добавить системный блок\n" +
                                    "2 - Добавить материнскую плату\n" +
                                    "3 - Добавить память\n" +
                                    "4 - Добавить процессор\n" +
                                    "5 - Добавить SSD\n" +
                                    "0 - Выход");
                                answerAdd = Console.ReadLine();
                                if (answerAdd == "0")
                                {
                                    myPcBox.toFile();
                                    break;
                                }
                                switch (answerAdd)
                                {
                                    case "1":
                                        Console.WriteLine("Введите модель системного блока:");
                                        string pc = Console.ReadLine();
                                        myPcBox.addComponent(pc);
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите модель материнской платы:");
                                        string mb = Console.ReadLine();
                                        myPcBox.addMotherboard(mb);
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.WriteLine("Введите модель памяти:");
                                        string my = Console.ReadLine();
                                        myPcBox.addMemory(my);
                                        Console.ReadKey();
                                        break;
                                    case "4":
                                        Console.WriteLine("Введите модель процессора:");
                                        string proc = Console.ReadLine();
                                        myPcBox.addProcessor(proc);
                                        Console.ReadKey();
                                        break;
                                    case "5":
                                        Console.WriteLine("Введите модель процессора:");
                                        string ssd = Console.ReadLine();
                                        myPcBox.addSsd(ssd);
                                        Console.ReadKey();
                                        break;
                                    default: break;
                                }
                            } while (answerAdd != "0");
                        }
                        if (answerPc == "2")
                        {
                            string answerChange;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1 - Изменить системный блок\n" +
                                    "2 - Изменить материнскую плату\n" +
                                    "3 - Изменить память\n" +
                                    "4 - Изменить процессор\n" +
                                    "5 - Изменить SSD\n" +
                                    "0 - Выход");
                                answerChange = Console.ReadLine();
                                if (answerChange == "0")
                                {
                                    myPcBox.toFile();
                                    break;
                                }
                                switch (answerChange)
                                {
                                    case "1":
                                        Console.WriteLine("Введите модель системного блока:");
                                        string pcCg = Console.ReadLine();
                                        myPcBox.changeComponent(pcCg);
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите модель материнской платы:");
                                        string mbCg = Console.ReadLine();
                                        myPcBox.changeMotherboard(mbCg);
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.WriteLine("Введите модель памяти:");
                                        string myCg = Console.ReadLine();
                                        myPcBox.changeMemory(myCg);
                                        Console.ReadKey();
                                        break;
                                    case "4":
                                        Console.WriteLine("Введите модель процессора:");
                                        string procCg = Console.ReadLine();
                                        myPcBox.changeProcessor(procCg);
                                        Console.ReadKey();
                                        break;
                                    case "5":
                                        Console.WriteLine("Введите модель процессора:");
                                        string ssdCg = Console.ReadLine();
                                        myPcBox.changeSsd(ssdCg);
                                        Console.ReadKey();
                                        break;
                                    default: break;
                                }
                            } while (answerChange != "0");
                        }
                        if (answerPc == "0")
                            break;
                    } while (answerPc == "0");
                }
                //2
                if (answerMenu == "2")
                {
                    string answerMonitor;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Добавить компоненты\n" +
                            "2 - Изменить компоненты\n" +
                            "0 - Выход");
                        answerMonitor = Console.ReadLine();
                        if(answerMonitor == "1")
                        {
                            string answerAdd;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1 - Добавить первый монитор\n" +
                                    "2 - Добавить второй монитор\n" +
                                    "3 - Добавить третий монитор\n" +
                                    "0 - Выход");
                                answerAdd = Console.ReadLine();
                                if( answerAdd == "0")
                                {
                                    myMonitor.toFile();
                                    break;
                                }
                                switch (answerAdd)
                                {
                                    case "1":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.addComponent(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.addMonitor2(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.addMonitor3(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                        default : break;
                                }

                            } while (answerAdd != "0");
                        }
                        if (answerMonitor == "2")
                        {
                            string answerChange;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1 - Изменить первый монитор\n" +
                                    "2 - Изменить второй монитор\n" +
                                    "3 - Изменить третий монитор\n" +
                                    "0 - Выход");
                                answerChange = Console.ReadLine();
                                if (answerChange == "0")
                                {
                                    myMonitor.toFile();
                                    break;
                                }
                                switch (answerChange)
                                {
                                    case "1":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.changeComponent(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.changeMonitor2(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.WriteLine("Введите название монитора: ");
                                        myMonitor.changeMonitor3(Console.ReadLine());
                                        Console.ReadKey();
                                        break;
                                    default: break;
                                }

                            } while (answerChange != "0");
                        }
                        if(answerMonitor == "0")
                            break;
                    } while (answerMonitor != "0");
                }
                //3
                if (answerMenu == "3")
                {
                    string answerKeyboar;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Добавить компоненты\n" +
                            "2 - Изменить компоненты\n" +
                            "0 - Выход");
                        answerKeyboar = Console.ReadLine();
                        if(answerKeyboar == "0")
                        {
                            myKeyboar.toFile();
                            break;
                        }
                        if(answerKeyboar == "1")
                        {
                            Console.WriteLine("Введите название клавиатуры: ");
                            myKeyboar.addComponent(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        }
                        if( answerKeyboar == "2")
                        {
                            Console.WriteLine("Введите название клавиатуры: ");
                            myKeyboar.changeComponent(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        }
                    } while (answerKeyboar != "0");
                }
                // 4
                if (answerMenu == "4")
                {
                    string answerMous;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Добавить компоненты\n" +
                            "2 - Изменить компоненты\n" +
                            "0 - Выход");
                        answerMous = Console.ReadLine();
                        if (answerMous == "0")
                        {
                            myKeyboar.toFile();
                            break;
                        }
                        if (answerMous == "1")
                        {
                            Console.WriteLine("Введите название мышки: ");
                            myMouse.addComponent(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        }
                        if (answerMous == "2")
                        {
                            Console.WriteLine("Введите название мышки: ");
                            myMouse.changeComponent(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        }
                    } while (answerMous != "0");
                }
                if (answerMenu == "5")
                {
                    myKeyboar.toRead();
                    Console.ReadKey();
                }
                if (answerMenu == "0")
                    return;
            } while (answerMenu != "0");
        }
    }
}
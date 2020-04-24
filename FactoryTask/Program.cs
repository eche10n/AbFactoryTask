using System;

namespace FactoryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("Choose your OS");
            type = Console.ReadLine();
            if (type == "windows")
                new client().windowsSet();
            else if (type == "ubuntu")
                new client().ubuntuSet();
            else if (type == "macos")
                new client().macOSSet();
            else
                Console.WriteLine("Wrong inputut");

            Console.ReadKey();

        }
    }

    /// <summary>
    /// интерфейс отвечает за настройку
    /// </summary>
    public interface setting
    {
        int[] Flag { get; set; }
    }

    /// <summary>
    /// интерфейс настройки
    /// </summary>
    public interface OS_Switch
    {
        int[] getSettingtings();
        /// <summary>
        /// тип системы
        /// </summary>
        /// <returns></returns>
        string type();
        /// <summary>
        /// настройка 
        /// </summary>
        string getSetting1();
        string getSetting2();
        string getSetting3();
        string getSetting4();
        string getSetting5();
        string getSetting6();
        string getSetting7();
        string getSetting8();
        string getSetting9();
        string getSetting10();

    }

    class client
    {
        /// <summary>
        /// Вызов настройки Windows
        /// </summary>
        public void windowsSet()
        {
            newSetup(new Windows_switch());
        }

        /// <summary>
        /// Вызов настройки Ubuntu
        /// </summary>
        public void ubuntuSet()
        {
            newSetup(new ubuntu_Switch());
        }
        /// <summary>
        /// Вызов настройки MacOS
        /// </summary>
        public void macOSSet()
        {
            newSetup(new Macos_OS_Switch());
        }

        /// <summary>
        /// Выводим настройки
        /// </summary>
        /// <param name="newSetup"></param>
        public void newSetup(OS_Switch OS_Switch)
        {
            string input = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(OS_Switch.type());
                Console.WriteLine(OS_Switch.getSetting1());
                Console.WriteLine(OS_Switch.getSetting2());
                Console.WriteLine(OS_Switch.getSetting3());
                Console.WriteLine(OS_Switch.getSetting4());
                Console.WriteLine(OS_Switch.getSetting5());
                Console.WriteLine(OS_Switch.getSetting6());
                Console.WriteLine(OS_Switch.getSetting7());
                Console.WriteLine(OS_Switch.getSetting8());
                Console.WriteLine(OS_Switch.getSetting9());
                Console.WriteLine(OS_Switch.getSetting10());
                input = Console.ReadLine();
                if (input == "exit") return;
                try
                {
                    int fl = Convert.ToInt32(input);
                    if (fl < 1 || fl > 10) throw new FormatException();
                    OS_Switch.getSettingtings()[fl - 1] ^= 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong conf");
                }
            }
        }
    }

    /// <summary>
    /// класс, отвечает за настройку windows
    /// </summary>
    class Windows_setting : setting
    {
        private int[] flag;
        public Windows_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }

    /// <summary>
    /// windows настройка
    /// </summary>
    class Windows_switch : OS_Switch
    {
        private setting Setting;

        public Windows_switch()
        {
            Setting = new Windows_setting();
        }

        public string type()
        {
            return "Windows";
        }
        public string getSetting1()
        {
            if (getSettingtings()[0] == 1)
                return "Текущий язык: RU\n1. Сменить на EN";
            else
                return "Current language: EN\n1. Change to RU";
        }
        public string getSetting2()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[1] == 1)
                    return "Синхронизация Windows.Аккаунт: вкл\n2. Выключить";
                else
                    return "Синхронизация Windows.Аккаунт: выкл\n2. Включить";
            }
            else
            {
                if (getSettingtings()[1] == 1)
                    return "Windows.Akk sync: enabled\n2. Disable";
                else
                    return "Windows.Akk sync: disable\n2. Enable";
            }
        }
        public string getSetting3()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[2] == 1)
                    return "Режим максимальной производительности: вкл\n3. Выключить";
                else
                    return "Режим максимальной производительности: выкл\n3. Включить";
            }
            else
            {
                if (getSettingtings()[2] == 1)
                    return "Maximum performance mode: enabled\n3. Disable";
                else
                    return "Maximum performance mode: disable\n3. Enable";
            }
        }
        public string getSetting4()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[3] == 1)
                    return "Режим \"В самолете\": вкл\n4. Выключить";
                else
                    return "Режим \"В самолете\": выкл\n4. Включить";
            }
            else
            {
                if (getSettingtings()[3] == 1)
                    return "Airplane mode: enabled\n4. Disable";
                else
                    return "Airplane mode: disable\n4. Enable";
            }
        }
        public string getSetting5()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: вкл\n5. Выключить";
                else
                    return "Wi-fi: выкл\n5. Включить";
            }
            else
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: enabled\n5. Disable";
                else
                    return "Wi-fi: disable\n5. Enable";
            }
        }
        public string getSetting6()
        {

            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: вкл\n6. Выключить";
                else
                    return "Bluetooth: выкл\n6. Включить";
            }
            else
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: enabled\n6. Disable";
                else
                    return "Bluetooth: disable\n6. Enable";
            }
        }
        public string getSetting7()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[6] == 1)
                    return "Ночной режим: вкл\n7. Выключить";
                else
                    return "Ночной режим: выкл\n7. Включить";
            }
            else
            {
                if (getSettingtings()[6] == 1)
                    return "Night mode: enabled\n7. Disable";
                else
                    return "Night mode: disable\n7. Enable";
            }
        }
        public string getSetting8()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[7] == 1)
                    return "Блокировка клавиатуры: вкл\n8. Выключить";
                else
                    return "Блокировка клавиатуры: выкл\n8. Включить";
            }
            else
            {
                if (getSettingtings()[7] == 1)
                    return "Keyboard block: enabled\n8. Disable";
                else
                    return "Keyboard block: disable\n8. Enable";
            }
        }
        public string getSetting9()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[8] == 1)
                    return "Автоматический вход в систему: вкл\n9. Выключить";
                else
                    return "Автоматический вход в систему: выкл\n9. Включить";
            }
            else
            {
                if (getSettingtings()[8] == 1)
                    return "Auto Login: enabled\n9. Disable";
                else
                    return "Auto Login: disable\n9. Enable";
            }
        }
        public string getSetting10()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[9] == 1)
                    return "Браузер по умолчанию: Safari\n10. Сменить на Chrome";
                else
                    return "Браузер по умолчанию: Chrome\n10. Сменить на Safari";
            }
            else
            {
                if (getSettingtings()[9] == 1)
                    return "Default internet browser: Safari\n10. Change to Chrome";
                else
                    return "Default internet browser: Chrome\n10. Change to Safari";
            }
        }

        public int[] getSettingtings()
        {
            return this.Setting.Flag;
        }
    }

    /// <summary>
    /// класс отвечает за настройку ubuntu
    /// </summary>
    class Ubuntu_setting : setting
    {

        private int[] flag;
        public Ubuntu_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }

    /// <summary>
    /// ubuntu настройка
    /// </summary>
    class ubuntu_Switch : OS_Switch
    {
        private setting Setting;

        public ubuntu_Switch()
        {
            Setting = new Ubuntu_setting();
        }

        public string type()
        {
            return "Ubuntu";
        }
        public string getSetting1()
        {
            if (getSettingtings()[0] == 1)
                return "Текущий язык: RU\n1. Сменить на EN";
            else
                return "Current language: EN\n1. Change to RU";
        }
        public string getSetting2()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[1] == 1)
                    return "Синхронизация Ununtu.Аккаунт: вкл\n2. Выключить";
                else
                    return "Синхронизация Ununtu.Аккаунт: выкл\n2. Включить";
            }
            else
            {
                if (getSettingtings()[1] == 1)
                    return "Ununtu.Akk sync: enabled\n2. Disable";
                else
                    return "Ununtu.Akk sync: disable\n2. Enable";
            }
        }
        public string getSetting3()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[2] == 1)
                    return "Режим максимальной производительности: вкл\n3. Выключить";
                else
                    return "Режим максимальной производительности: выкл\n3. Включить";
            }
            else
            {
                if (getSettingtings()[2] == 1)
                    return "Maximum performance mode: enabled\n3. Disable";
                else
                    return "Maximum performance mode: disable\n3. Enable";
            }
        }
        public string getSetting4()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[3] == 1)
                    return "Режим \"В самолете\": вкл\n4. Выключить";
                else
                    return "Режим \"В самолете\": выкл\n4. Включить";
            }
            else
            {
                if (getSettingtings()[3] == 1)
                    return "Airplane mode: enabled\n4. Disable";
                else
                    return "Airplane mode: disable\n4. Enable";
            }
        }
        public string getSetting5()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: вкл\n5. Выключить";
                else
                    return "Wi-fi: выкл\n5. Включить";
            }
            else
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: enabled\n5. Disable";
                else
                    return "Wi-fi: disable\n5. Enable";
            }
        }
        public string getSetting6()
        {

            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: вкл\n6. Выключить";
                else
                    return "Bluetooth: выкл\n6. Включить";
            }
            else
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: enabled\n6. Disable";
                else
                    return "Bluetooth: disable\n6. Enable";
            }
        }
        public string getSetting7()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[6] == 1)
                    return "Ночной режим: вкл\n7. Выключить";
                else
                    return "Ночной режим: выкл\n7. Включить";
            }
            else
            {
                if (getSettingtings()[6] == 1)
                    return "Night mode: enabled\n7. Disable";
                else
                    return "Night mode: disable\n7. Enable";
            }
        }
        public string getSetting8()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[7] == 1)
                    return "Блокировка клавиатуры: вкл\n8. Выключить";
                else
                    return "Блокировка клавиатуры: выкл\n8. Включить";
            }
            else
            {
                if (getSettingtings()[7] == 1)
                    return "Keyboard block: enabled\n8. Disable";
                else
                    return "Keyboard block: disable\n8. Enable";
            }
        }
        public string getSetting9()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[8] == 1)
                    return "Автоматический вход в систему: вкл\n9. Выключить";
                else
                    return "Автоматический вход в систему: выкл\n9. Включить";
            }
            else
            {
                if (getSettingtings()[8] == 1)
                    return "Auto Login: enabled\n9. Disable";
                else
                    return "Auto Login: disable\n9. Enable";
            }
        }
        public string getSetting10()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[9] == 1)
                    return "Браузер по умолчанию: Safari\n10. Сменить на Chrome";
                else
                    return "Браузер по умолчанию: Chrome\n10. Сменить на Safari";
            }
            else
            {
                if (getSettingtings()[9] == 1)
                    return "Default internet browser: Safari\n10. Change to Chrome";
                else
                    return "Default internet browser: Chrome\n10. Change to Safari";
            }
        }

        public int[] getSettingtings()
        {
            return this.Setting.Flag;
        }
    }

    /// <summary>
    /// отвечает за настройку macos
    /// </summary>
    class macos_setting : setting
    {
        private int[] flag;
        public macos_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }

    /// <summary>
    /// macos настройка
    /// </summary>
    class Macos_OS_Switch : OS_Switch
    {
        private setting Setting;

        public Macos_OS_Switch()
        {
            Setting = new macos_setting();
        }

        public string type()
        {
            return "MacOS";
        }
        public string getSetting1()
        {
            if (getSettingtings()[0] == 1)
                return "Текущий язык: RU\n1. Сменить на EN";
            else
                return "Current language: EN\n1. Change to RU";
        }
        public string getSetting2()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[1] == 1)
                    return "Синхронизация iCloud: вкл\n2. Выключить";
                else
                    return "Синхронизация iCloud: выкл\n2. Включить";
            }
            else
            {
                if (getSettingtings()[1] == 1)
                    return "iCloud sync: enabled\n2. Disable";
                else
                    return "iCloud sync: disable\n2. Enable";
            }
        }
        public string getSetting3()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[2] == 1)
                    return "Режим максимальной производительности: вкл\n3. Выключить";
                else
                    return "Режим максимальной производительности: выкл\n3. Включить";
            }
            else
            {
                if (getSettingtings()[2] == 1)
                    return "Maximum performance mode: enabled\n3. Disable";
                else
                    return "Maximum performance mode: disable\n3. Enable";
            }
        }
        public string getSetting4()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[3] == 1)
                    return "Режим \"В самолете\": вкл\n4. Выключить";
                else
                    return "Режим \"В самолете\": выкл\n4. Включить";
            }
            else
            {
                if (getSettingtings()[3] == 1)
                    return "Airplane mode: enabled\n4. Disable";
                else
                    return "Airplane mode: disable\n4. Enable";
            }
        }
        public string getSetting5()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: вкл\n5. Выключить";
                else
                    return "Wi-fi: выкл\n5. Включить";
            }
            else
            {
                if (getSettingtings()[4] == 1)
                    return "Wi-fi: enabled\n5. Disable";
                else
                    return "Wi-fi: disable\n5. Enable";
            }
        }
        public string getSetting6()
        {

            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: вкл\n6. Выключить";
                else
                    return "Bluetooth: выкл\n6. Включить";
            }
            else
            {
                if (getSettingtings()[5] == 1)
                    return "Bluetooth: enabled\n6. Disable";
                else
                    return "Bluetooth: disable\n6. Enable";
            }
        }
        public string getSetting7()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[6] == 1)
                    return "Ночной режим: вкл\n7. Выключить";
                else
                    return "Ночной режим: выкл\n7. Включить";
            }
            else
            {
                if (getSettingtings()[6] == 1)
                    return "Night mode: enabled\n7. Disable";
                else
                    return "Night mode: disable\n7. Enable";
            }
        }
        public string getSetting8()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[7] == 1)
                    return "Блокировка клавиатуры: вкл\n8. Выключить";
                else
                    return "Блокировка клавиатуры: выкл\n8. Включить";
            }
            else
            {
                if (getSettingtings()[7] == 1)
                    return "Keyboard block: enabled\n8. Disable";
                else
                    return "Keyboard block: disable\n8. Enable";
            }
        }
        public string getSetting9()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[8] == 1)
                    return "Показывать список пользователей: вкл\n9. Выключить";
                else
                    return "Показывать список пользователей: выкл\n9. Включить";
            }
            else
            {
                if (getSettingtings()[8] == 1)
                    return "Show user list: enabled\n9. Disable";
                else
                    return "Show user list: disable\n9. Enable";
            }
        }
        public string getSetting10()
        {
            if (getSettingtings()[0] == 1)
            {
                if (getSettingtings()[9] == 1)
                    return "Браузер по умолчанию: Safari\n10. Сменить на Chrome";
                else
                    return "Браузер по умолчанию: Chrome\n10. Сменить на Safari";
            }
            else
            {
                if (getSettingtings()[9] == 1)
                    return "Default internet browser: Safari\n10. Change to Chrome";
                else
                    return "Default internet browser: Chrome\n10. Change to Safari";
            }
        }

        public int[] getSettingtings()
        {
            return this.Setting.Flag;
        }
    }


}

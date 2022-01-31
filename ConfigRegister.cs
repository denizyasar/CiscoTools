using System.Collections.Generic;

namespace CiscoTools
{
    public sealed class ConfigRegister

    {
        // ReSharper disable once InconsistentNaming
        private static readonly ConfigRegister _instance = new ConfigRegister();

        private string _baudrate;
        private string _bootsystem;
        private string _desciption;
        private string _info;
        private string _register;

        private ConfigRegister()
        {
            Bit1 = Bit8 = Bit13 = true;
        }


        public void RegisterCalculate()
        {
            string tmp = _register.PadLeft(4, '0');
            Part4 = tmp.Substring(3, 1);
            Part3 = tmp.Substring(2, 1);
            Part2 = tmp.Substring(1, 1);
            Part1 = tmp.Substring(0, 1);
        }


        public string Baudrate
        {
            get
            {
                _baudrate = "9600 (default)";
                if (Bit12 & !Bit11 & !Bit5)
                    _baudrate = "1200";
                if (Bit12 & Bit11 & !Bit5)
                    _baudrate = "2400";
                if (Bit11 & !Bit12 & !Bit5)
                    _baudrate = "4800";
                if (!Bit11 & !Bit12 & Bit5)
                    _baudrate = "19200";
                if (Bit11 & !Bit12 & Bit5)
                    _baudrate = "38400";
                if (!Bit11 & Bit12 & Bit5)
                    _baudrate = "57600";
                if (Bit11 & Bit12 & Bit5)
                    _baudrate = "115200";

                return _baudrate;
            }
            set
            {
                _baudrate = value;
                switch (value)
                {
                    case "1200":
                        Bit5 = false;
                        Bit11 = false;
                        Bit12 = true;
                        break;
                    case "2400":
                        Bit5 = false;
                        Bit11 = true;
                        Bit12 = true;
                        break;
                    case "4800":
                        Bit5 = false;
                        Bit12 = false;
                        Bit11 = true;
                        break;
                    case "9600 (default)":
                        Bit5 = false;
                        Bit11 = false;
                        Bit12 = false;
                        break;
                    case "19200":
                        Bit12 = false;
                        Bit11 = false;
                        Bit5 = true;
                        break;
                    case "38400":
                        Bit12 = false;
                        Bit5 = true;
                        Bit11 = true;
                        break;
                    case "57600":
                        Bit11 = false;
                        Bit5 = true;
                        Bit12 = true;
                        break;
                    case "115200":
                        Bit5 = true;
                        Bit12 = true;
                        Bit11 = true;
                        break;
                }
            }
        }

        public List<string> BaudRates
        {
            get
            {
                var BaudRates = new List<string>
                {
                    "1200",
                    "2400",
                    "4800",
                    "9600 (default)",
                    "19200",
                    "38400",
                    "57600",
                    "115200"
                };
                return BaudRates;
            }
        }


        public bool Bit0 { get; set; }

        public bool Bit1 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }


        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit2 { get; set; }
        public bool Bit3 { get; set; }

        public bool Bit4 { get; set; }
        public bool Bit5 { get; set; }
        public bool Bit6 { get; set; }
        public bool Bit7 { get; set; }

        public bool Bit8 { get; set; }
        public bool Bit9 { get; set; }

        public string BootSystem
        {
            get
            {
                _bootsystem = "to bootstrap prompt";

                if (Bit0)
                    _bootsystem = "From Rom";
                if (Bit1)
                    _bootsystem = "From Flash";

                return _bootsystem;
            }
            set
            {
                _bootsystem = value;
                switch (value)
                {
                    case "From Flash":
                        Bit0 = false;
                        Bit1 = true;
                        break;
                    case "From Rom":
                        Bit0 = true;
                        Bit1 = false;
                        break;
                    case "to bootstrap prompt":
                        Bit0 = false;
                        Bit1 = false;
                        break;
                }
            }
        }

        public List<string> BootSystems
        {
            get
            {
                var BootSystems = new List<string> { "to bootstrap prompt", "From Rom", "From Flash" };
                return BootSystems;
            }
        }

        public string Description
        {
            get
            {
                _info = Bit6 ? "Config in NVRAM will be ignored\n" : "NVRAM config will be used\n";
                _info += Bit8 ? "Break key Disabled, after IOS load\n\n" : "Break key Enabled, after IOS load\n\n";

                _info += "Console Baud: ";


                _desciption = $"{_info}{Baudrate}";

                if (Bit15)
                    _desciption += "\nDiagnostics enable. NVRAM Ignored.";

                switch (Part4)
                {
                    case "0":
                        _desciption +=
                            "\n\nWill Stay at the system bootstrap prompt (ROM monitor) on a reload or power cycle.";
                        break;
                    case "1":
                        _desciption += "\n\nWill Boots the boot helper image as a system image.";
                        break;
                    case "2":
                        _desciption += "\n\nUse filename: cisco2-4000 for tftpboot (on 4000 series)";
                        break;
                    case "3":
                        _desciption += "\n\nUse filename: cisco3-4000 for tftpboot (on 4000 series)";
                        break;
                    case "4":
                        _desciption += "\n\nUse filename: cisco4-4000 for tftpboot (on 4000 series)";
                        break;
                    case "5":
                        _desciption += "\n\nUse filename: cisco5-4000 for tftpboot (on 4000 series)";
                        break;
                    case "6":
                        _desciption += "\n\nUse filename: cisco6-4000 for tftpboot (on 4000 series)";
                        break;
                    case "7":
                        _desciption += "\n\nUse filename: cisco7-4000 for tftpboot (on 4000 series)";
                        break;
                    case "8":
                        _desciption += "\n\nUse filename: cisco10-4000 for tftpboot (on 4000 series)";
                        break;
                    case "9":
                        _desciption += "\n\nUse filename: cisco11-4000 for tftpboot (on 4000 series)";
                        break;
                    case "A":
                        _desciption += "\n\nUse filename: cisco12-4000 for tftpboot (on 4000 series)";
                        break;
                    case "B":
                        _desciption += "\n\nUse filename: cisco13-4000 for tftpboot (on 4000 series)";
                        break;
                    case "C":
                        _desciption += "\n\nUse filename: cisco14-4000 for tftpboot (on 4000 series)";
                        break;
                    case "D":
                        _desciption += "\n\nUse filename: cisco15-4000 for tftpboot (on 4000 series)";
                        break;
                    case "E":
                        _desciption += "\n\nUse filename: cisco16-4000 for tftpboot (on 4000 series)";
                        break;
                    case "F":
                        _desciption += "\n\nUse filename: cisco17-4000 for tftpboot (on 4000 series)";
                        break;
                }


                return _desciption;
            }
            set { _desciption = value; }
        }


        public static ConfigRegister Instance
        {
            get { return _instance; }
        }


        public string Part1
        {
            get
            {
                int x = 0;
                if (Bit12)
                    x += (int)Registers.Bit12;
                if (Bit13)
                    x += (int)Registers.Bit13;
                if (Bit14)
                    x += (int)Registers.Bit14;
                if (Bit15)
                    x += (int)Registers.Bit15;
                return x.ToString("X");
            }

            set
            {
                Bit12 = Bit13 = Bit14 = Bit15 = false;
                switch (value)
                {
                    case "1":
                        Bit12 = true;
                        break;
                    case "2":
                        Bit13 = true;
                        break;
                    case "3":
                        Bit12 = Bit13 = true;
                        break;
                    case "4":
                        Bit14 = true;
                        break;
                    case "5":
                        Bit12 = Bit14 = true;
                        break;
                    case "6":
                        Bit13 = Bit14 = true;
                        break;
                    case "7":
                        Bit2 = Bit13 = Bit14 = true;
                        break;
                    case "8":
                        Bit15 = true;
                        break;
                    case "9":
                        Bit12 = Bit15 = true;
                        break;
                    case "A":
                    case "a":
                        Bit13 = Bit15 = true;
                        break;
                    case "B":
                    case "b":
                        Bit12 = Bit13 = Bit15 = true;
                        break;
                    case "C":
                    case "c":
                        Bit14 = Bit15 = true;
                        break;
                    case "D":
                    case "d":
                        Bit12 = Bit14 = Bit15 = true;
                        break;
                    case "E":
                    case "e":
                        Bit13 = Bit14 = Bit15 = true;
                        break;
                    case "F":
                    case "f":
                        Bit12 = Bit13 = Bit14 = Bit15 = true;
                        break;
                }
            }
        }

        public string Part2
        {
            get
            {
                int x = 0;
                if (Bit8)
                    x += (int)Registers.Bit8;
                if (Bit9)
                    x += (int)Registers.Bit9;
                if (Bit10)
                    x += (int)Registers.Bit10;
                if (Bit11)
                    x += (int)Registers.Bit11;

                return x.ToString("X");
            }
            set
            {
                Bit8 = Bit9 = Bit10 = Bit11 = false;
                switch (value)
                {
                    case "1":
                        Bit8 = true;
                        break;
                    case "2":
                        Bit9 = true;
                        break;
                    case "3":
                        Bit8 = Bit9 = true;
                        break;
                    case "4":
                        Bit10 = true;
                        break;
                    case "5":
                        Bit8 = Bit10 = true;
                        break;
                    case "6":
                        Bit9 = Bit10 = true;
                        break;
                    case "7":
                        Bit8 = Bit9 = Bit10 = true;
                        break;
                    case "8":
                        Bit11 = true;
                        break;
                    case "9":
                        Bit8 = Bit11 = true;
                        break;
                    case "A":
                    case "a":
                        Bit8 = Bit11 = true;
                        break;
                    case "B":
                    case "b":
                        Bit8 = Bit9 = Bit11 = true;
                        break;
                    case "C":
                    case "c":
                        Bit10 = Bit11 = true;
                        break;
                    case "D":
                    case "d":
                        Bit8 = Bit10 = Bit11 = true;
                        break;
                    case "E":
                    case "e":
                        Bit9 = Bit10 = Bit11 = true;
                        break;
                    case "F":
                    case "f":
                        Bit8 = Bit9 = Bit10 = Bit11 = true;
                        break;
                }
            }
        }

        public string Part3
        {
            get
            {
                int x = 0;
                if (Bit4)
                    x += (int)Registers.Bit4;
                if (Bit5)
                    x += (int)Registers.Bit5;
                if (Bit6)
                    x += (int)Registers.Bit6;
                if (Bit7)
                    x += (int)Registers.Bit7;

                return x.ToString("X");
            }
            set
            {
                Bit4 = Bit5 = Bit6 = Bit7 = false;
                switch (value)
                {
                    case "1":
                        Bit4 = true;
                        break;
                    case "2":
                        Bit5 = true;
                        break;
                    case "3":
                        Bit4 = Bit5 = true;
                        break;
                    case "4":
                        Bit6 = true;
                        break;
                    case "5":
                        Bit4 = Bit6 = true;
                        break;
                    case "6":
                        Bit5 = Bit6 = true;
                        break;
                    case "7":
                        Bit4 = Bit5 = Bit6 = true;
                        break;
                    case "8":
                        Bit7 = true;
                        break;
                    case "9":
                        Bit4 = Bit7 = true;
                        break;
                    case "A":
                    case "a":
                        Bit5 = Bit7 = true;
                        break;
                    case "B":
                    case "b":
                        Bit4 = Bit5 = Bit7 = true;
                        break;
                    case "C":
                    case "c":
                        Bit6 = Bit7 = true;
                        break;
                    case "D":
                    case "d":
                        Bit4 = Bit6 = Bit7 = true;
                        break;
                    case "E":
                    case "e":
                        Bit5 = Bit6 = Bit7 = true;
                        break;
                    case "F":
                    case "f":
                        Bit4 = Bit5 = Bit6 = Bit7 = true;
                        break;
                }
            }
        }


        public string Part4
        {
            get
            {
                int x = 0;
                if (Bit0)
                    x += (int)Registers.Bit0;
                if (Bit1)
                    x += (int)Registers.Bit1;
                if (Bit2)
                    x += (int)Registers.Bit2;
                if (Bit3)
                    x += (int)Registers.Bit3;

                return x.ToString("X");
            }
            set
            {
                Bit0 = Bit1 = Bit2 = Bit3 = false;
                switch (value)
                {
                    case "1":
                        Bit0 = true;
                        break;
                    case "2":
                        Bit1 = true;
                        break;
                    case "3":
                        Bit0 = Bit1 = true;
                        break;
                    case "4":
                        Bit2 = true;
                        break;
                    case "5":
                        Bit0 = Bit2 = true;
                        break;
                    case "6":
                        Bit1 = Bit2 = true;
                        break;
                    case "7":
                        Bit0 = Bit1 = Bit2 = true;
                        break;
                    case "8":
                        Bit3 = true;
                        break;
                    case "9":
                        Bit0 = Bit3 = true;
                        break;
                    case "A":
                    case "a":
                        Bit1 = Bit3 = true;
                        break;
                    case "B":
                    case "b":
                        Bit0 = Bit1 = Bit3 = true;
                        break;
                    case "C":
                    case "c":
                        Bit2 = Bit3 = true;
                        break;
                    case "D":
                    case "d":
                        Bit0 = Bit2 = Bit3 = true;
                        break;
                    case "E":
                    case "e":
                        Bit1 = Bit2 = Bit3 = true;
                        break;
                    case "F":
                    case "f":
                        Bit0 = Bit1 = Bit2 = Bit3 = true;
                        break;
                }
            }
        }


        public string Register
        {
            get
            {
                _register = $"{Part1}{Part2}{Part3}{Part4}";
                return _register;
            }

            set { _register = value; }
        }
    }

    public enum Registers
    {
        Bit0 = 1,
        Bit1 = 2,
        Bit2 = 4,
        Bit3 = 8,
        Bit4 = 1,
        Bit5 = 2,
        Bit6 = 4,
        Bit7 = 8,
        Bit8 = 1,
        Bit9 = 2,
        Bit10 = 4,
        Bit11 = 8,
        Bit12 = 1,
        Bit13 = 2,
        Bit14 = 4,
        Bit15 = 8
    }
}
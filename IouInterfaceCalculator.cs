using System;

namespace CiscoTools
{
    public class IouInterfaceCalculator
    {
        private readonly string _faNumber;

        public IouInterfaceCalculator(string faNumber)
        {
            _faNumber = faNumber;
        }

        public string EthernetNumber()
        {
            int num;

            if (int.TryParse(_faNumber, out num))
            {
                int remainder = Convert.ToInt32(_faNumber) % 4;
                if (remainder != 0)
                {
                    int num1 = Convert.ToInt32(_faNumber);
                    return $@"{Convert.ToString(num1 / 4)}/{Convert.ToString(num1 % 4)}";
                }
                return $@"{Convert.ToString(Convert.ToInt32(_faNumber) / 4)}/0";
            }
            return string.Empty;
        }
    }
}
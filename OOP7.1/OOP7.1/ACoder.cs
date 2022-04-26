using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7._1
{
    public class ACoder : ICoder
    {
        private readonly char[] _inputCharArray;

        public ACoder(string inputString)
        {
            _inputCharArray = inputString.ToCharArray();
        }

        public string Decode()
        {
            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                _inputCharArray[i] = (char)(_inputCharArray[i] - 1);
            }

            return string.Concat(_inputCharArray);
        }

        public string Encode()
        {
            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                _inputCharArray[i] = (char)(_inputCharArray[i] + 1);
            }

            return string.Concat(_inputCharArray);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7._1
{
    public class BCoder : ICoder
    {
        private readonly Dictionary<char, Tuple<int, int>> _letters = new Dictionary<char, Tuple<int, int>>();

        private readonly char[] _inputCharArray;

        private const int _rAlphabetLength = 32;
        private const int _eAlphabetLength = 26;

        public BCoder(string inputString)
        {
            _inputCharArray = inputString.ToCharArray();

            for (int i = 0; i < _rAlphabetLength; i++)
            {
                _letters.Add((char)(1072 + i), new Tuple<int, int>(1072, 1072 + _rAlphabetLength - 1));
                _letters.Add((char)(1040 + i), new Tuple<int, int>(1040, 1040 + _rAlphabetLength - 1));

                if (i < _eAlphabetLength)
                {
                    _letters.Add((char)(97 + i), new Tuple<int, int>(97, 97 + _eAlphabetLength - 1));
                    _letters.Add((char)(65 + i), new Tuple<int, int>(65, 65 + _eAlphabetLength - 1));
                }
            }
        }

        public string Encode()
        {
            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                if (_letters.ContainsKey(_inputCharArray[i]))
                {
                    var el = _letters[_inputCharArray[i]];
                    _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
                }
                else
                {
                    _inputCharArray[i] = _inputCharArray[i];
                }
            }
            return string.Concat(_inputCharArray);
        }
        public string Decode()
        {

            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                if (_letters.ContainsKey(_inputCharArray[i]))
                {
                    var el = _letters[_inputCharArray[i]];
                    _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
                }
                else
                {
                    _inputCharArray[i] = _inputCharArray[i];
                }

            }
            return string.Concat(_inputCharArray);
        }
    }
}


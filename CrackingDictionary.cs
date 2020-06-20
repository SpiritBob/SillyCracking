using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class CrackingArray
    {
        string _data;

        public CrackingArray(string key)
        {
            _data = key;
        }

        public char this[char data, int offset]
        {
            get
            {
                if (data == ' ')
                    return data;
                
                int elementIndex = _data.IndexOf(data);
                bool notOriginalOffSet = false;
                while (elementIndex + offset >= _data.Length)
                {
                    offset = elementIndex + offset - _data.Length;
                    notOriginalOffSet = true;
                }

                while (elementIndex + offset < 0)
                {
                    offset = elementIndex + offset + _data.Length;
                    notOriginalOffSet = true;
                }

                if (notOriginalOffSet)
                    return _data[offset];
                else
                    return _data[elementIndex + offset];
            }
        }
    }
}

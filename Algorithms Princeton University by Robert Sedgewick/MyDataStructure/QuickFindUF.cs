using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Princeton_University_by_Robert_Sedgewick.MyDataStructure
{
    public class QuickFindUF
    {
        private readonly int _n;
        private int[] _unionFindArray;
        public QuickFindUF()
        {
            _n = 0;
            _unionFindArray = [];
        }
        public QuickFindUF( int n)
        {
            _n = n;
            _unionFindArray = new int[n];
            for (int i = 0; i < _unionFindArray.Length; i++)
            {
                _unionFindArray[i] = i;
            }
        }

        public bool IsConnected(int p, int q)
        {
            if (_unionFindArray is null)
                return false;

            return _unionFindArray[p] == _unionFindArray[q];
        }

        public void Union(int p, int q)
        {
            int elementPid = _unionFindArray[p];
            int elementQid = _unionFindArray[q];

            for (int i = 0; i< _unionFindArray.Length; i++)
            {
                if ( _unionFindArray [i] == elementPid)
                    _unionFindArray[i] = elementQid;
            }
        }

        public void ShowArray()
        {
            string emptyArray = "Union Find array not created, array is empty!";
            string notEmptyArray = "Elements of our Union Find class are:";
            string initialMessage = _unionFindArray == null ? notEmptyArray : emptyArray;
            Console.WriteLine(initialMessage);

            for (int i = 0;i < _unionFindArray?.Length;i++)
            {
                Console.WriteLine(_unionFindArray[i]);
            }
        }
    }
}

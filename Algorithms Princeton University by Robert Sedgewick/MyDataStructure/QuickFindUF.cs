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
        private int[] _quickFindUFArray;

        public QuickFindUF()
        {
            _n = 0;
            _quickFindUFArray = [];
        }

        public QuickFindUF( int n)
        {
            _n = n;
            _quickFindUFArray = new int[n];
            for (int i = 0; i < _quickFindUFArray.Length; i++)
            {
                _quickFindUFArray[i] = i;
            }
        }

        public bool IsConnected(int p, int q)
        {
            if (_quickFindUFArray is null)
                return false;

            return _quickFindUFArray[p] == _quickFindUFArray[q];
        }

        public void Union(int p, int q)
        {
            int elementPid = _quickFindUFArray[p];
            int elementQid = _quickFindUFArray[q];

            for (int i = 0; i< _quickFindUFArray.Length; i++)
            {
                if ( _quickFindUFArray [i] == elementPid)
                    _quickFindUFArray[i] = elementQid;
            }
        }

        public void ShowArray()
        {
            string emptyArray = "Union Find array not created, array is empty!";
            string notEmptyArray = "Elements of our Union Find class are:";
            string initialMessage = _quickFindUFArray == null ? notEmptyArray : emptyArray;
            Console.WriteLine(initialMessage);

            for (int i = 0;i < _quickFindUFArray?.Length;i++)
            {
                Console.WriteLine(_quickFindUFArray[i]);
            }
        }
    }
}

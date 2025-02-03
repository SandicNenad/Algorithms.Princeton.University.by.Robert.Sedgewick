namespace Algorithms_Princeton_University_by_Robert_Sedgewick.MyDataStructure
{
    public class QuickUnionUF
    {
        private int[] _quickUnionUFArray;
        private int[] _sizeArray;

        public QuickUnionUF(int n)
        {
            _quickUnionUFArray = new int[n];
            _sizeArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                _quickUnionUFArray[i] = i;
                _sizeArray[i] = i;
            }   
        }

        private int root(int i)
        {
            while (i != _quickUnionUFArray[i])
            {
                _quickUnionUFArray[i] = _quickUnionUFArray[_quickUnionUFArray[i]];
                i = _quickUnionUFArray[i];
            }   

            return i;
        }

        public bool IsConnected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void Union(int p, int q)
        {
            int i = root(p);
            int j = root(q);
            // Quick Union
            //_quickUnionUFArray[i] = j;

            // Weighted Quick Union
            if (_sizeArray[i] < _sizeArray[j])
            {
                _quickUnionUFArray[i] = j;
                _sizeArray[j] += _sizeArray[i];
            }
            else
            {
                _quickUnionUFArray[j] = i;
                _sizeArray[i] += _sizeArray[j];
            }
        }

        public void ShowArray()
        {
            string emptyArray = "Union Find array not created, array is empty!";
            string notEmptyArray = "Elements of our Union Find class are:";
            string initialMessage = _quickUnionUFArray == null ? notEmptyArray : emptyArray;
            Console.WriteLine(initialMessage);

            for (int i = 0; i < _quickUnionUFArray?.Length; i++)
            {
                Console.WriteLine(_quickUnionUFArray[i]);
            }
        }
    }
}

namespace Algorithms_Princeton_University_by_Robert_Sedgewick.MyDataStructure
{
    public class QuickUnionUF
    {
        private int[] _quickUnionUFArray;

        public QuickUnionUF(int n)
        {
            _quickUnionUFArray = new int[n];
            for (int i = 0; i < n; i++)
                _quickUnionUFArray[i] = i;
        }

        private int root(int i)
        {
            while (i != _quickUnionUFArray[i])
                i = _quickUnionUFArray[i];

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
            _quickUnionUFArray[i] = j;
        }
    }
}

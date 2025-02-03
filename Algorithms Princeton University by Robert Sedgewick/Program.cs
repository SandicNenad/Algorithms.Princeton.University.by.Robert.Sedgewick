// See https://aka.ms/new-console-template for more information
using Algorithms_Princeton_University_by_Robert_Sedgewick.MyDataStructure;

Console.WriteLine("Hello, World!");

var quickFind = new QuickFindUF(10);
quickFind.ShowArray();

var quickUnion = new QuickUnionUF(10);
quickUnion.Union(4, 3);
quickUnion.IsConnected(3, 4);

Console.ReadLine();

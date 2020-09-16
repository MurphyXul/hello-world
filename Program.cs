using System;

namespace AlgorithmLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //double t = -((3.0 / 7) * Math.Log((3.0 / 7), 2) + (4.0 / 7) * Math.Log((4.0 / 7), 2));
            //double entropy1 = Entropy.CalEntropy(new double[] { (3.0 / 7), (4.0 / 7) }, 2);
            //double re = Math.Log(Math.E);
            //Console.WriteLine(entropy1);
            //Console.WriteLine(re);

            int[] preorder = new int[] { 3, 9, 20, 15, 7 }; 
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };

            BuildTreeClas buildTreeClas = new BuildTreeClas();
            var re = buildTreeClas.BuildTree(preorder, inorder);
            Console.ReadKey();
        }
    }
}

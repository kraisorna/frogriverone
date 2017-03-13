using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //int[] A = { 4,1,3,2 };
            int[] A = { 1, 3, 1,4,2,3,5,4 };
            Console.WriteLine(s.solution(A,5));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A,int X)
        {
            int N = A.Length;
            Dictionary<int, int> path = new Dictionary<int, int>();
            for (int i = 1; i <= X; i++) {
                path.Add(i, 1);
            }
            for (int i = 0; i < N; i++) {
                path.Remove(A[i]);
                if (path.Count == 0) return i;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesse_and_Cookies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int k = 7;
            //List<int> A = new List<int> { 1, 2, 3, 9, 10, 12 }; //2

            //int k = 9;
            //List<int> A = new List<int> { 2, 7, 3, 6, 4, 6 }; //4

            int k = 90;
            List<int> A = new List<int> { 13, 47, 74, 12, 89, 74, 18, 38 }; //5

            //int k = 10;
            //List<int> A = new List<int> { 1, 1, 1 }; //-1

            Console.WriteLine(cookies(k, A));
        }
        /*
         * Complete the 'cookies' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY A
         */

        public static int cookies(int k, List<int> A)
        {
            A.Sort();

            int result = 0;

            while (A[0] < k && A.Count >= 2)
            {
                A.Add(A[0] + (2 * A[1]));
                A.Sort();
                A.RemoveRange(0, 2);
                result++;
            }

            return A[0] >= k ? result : -1;
        }
    }
}

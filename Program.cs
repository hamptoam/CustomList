using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> listCustom = new CustomList<int>();

            listCustom.Add(0);
            listCustom.Add(1);
            listCustom.Add(2);
            listCustom.Remove(2);


        }
    }
}

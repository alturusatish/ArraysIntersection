using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    public class Intersection
    {
        /// <summary>
        ///  Assumption : Arrays are in sorted order, otherwise this logic would not work
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <param name="list3"></param>
        /// <returns></returns>
        public static List<int>  GetInterSectionElements(int[] list1, int[] list2, int[] list3)
        {
            List<int> resultList = new List<int>();

            int list1Index = 0, list2Index = 0, list3Index = 0;
            
            while(list1Index < list1.Length && list2Index < list2.Length && list3Index < list3.Length)
            {
                if (list1[list1Index] == list2[list2Index] && list2[list2Index] == list3[list3Index])
                {
                    resultList.Add(list1[list1Index]);
                    list1Index++;
                    list2Index++;
                    list3Index++;
                }
                else if (list1[list1Index] < list2[list2Index])
                    ++list1Index;
                else if (list2[list2Index] < list3[list3Index])
                    ++list2Index;
                else
                    ++list3Index;
                                             
            }

            Console.WriteLine("Intersection elements: ");
            foreach (int ele in resultList)
                Console.Write(ele + "\t");
            

            return resultList;
        }
    }
}

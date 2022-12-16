using System;

namespace LeetCode___First_bad_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int FirstBadVersion(int n) {

            int startIndex = 0;
            int endIndex = n - 1;
            while(startIndex <= endIndex){

                int midIndex = startIndex + (endIndex - startIndex) / 2;

                if(IsBadVersion(midIndex)){
                    endIndex = midIndex - 1;
                }
                else{
                    startIndex = midIndex + 1;
                }
            }

            return startIndex;
        }
    }
}
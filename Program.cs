using System;

namespace dotnet2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter national code");
            string a=Console.ReadLine();
            int m =check(a);
            int l=int.Parse(a.Substring(a.Length-1,1));
            if (m>1)
            { if (l==11-m)
            {
                System.Console.WriteLine(true);
            }else
            {System.Console.WriteLine(false);}
                
            }else
            {
               if (l==m)
            {
                System.Console.WriteLine(true);
            }else
            {System.Console.WriteLine(false);} 
            }
            
        }
        public static int check(string a)
        {
             int s=a.Length;
            int j=2;
            int sum=0;
            for (int i = s; i > 1; i--)
            {
                string c=a.Substring(i-2,1);
                sum=(int.Parse(c)*j)+sum;
                j++;
            }
            int m=sum%11;
            return m;
        }
    }
}

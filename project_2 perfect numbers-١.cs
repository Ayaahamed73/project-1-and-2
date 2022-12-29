using System;
class PerfectNumbers
{
  static void Main(string[] args)
  {

    Console.WriteLine("please enter n1");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("please enter n2");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("The perfect numbers between n1 ,n2:");
    
    int i, j ;

    for (i = n1; i <= n2; i++)
    {
      int sum=0;
          j=1;
          while(j<i)
          {
            if(i%j==0)
      sum=sum+j;
      j++;
}

        if(sum==i)
Console.WriteLine(i);
    }
    Console.ReadKey();
     
  }
}
 
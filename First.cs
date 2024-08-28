using System;


class First
{
    //factorial
    static void factorial(int x){
        int fact = 1;
        for(int k=x;k>0;k--){
            fact = fact * k;
        }
        Console.WriteLine(fact);
        // return fact;
    }




    //fibbonacci
    static void fibbonacci()                 //static function in C# only belongs to 
    {                                        //to class not form it's object
        int fst=0;
        int snd=1;
        Console.WriteLine("Enter range for fibbonacci");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Fibbonacci Series for " + n + " numbers");

        Console.WriteLine(fst);
        Console.WriteLine(snd);


        for(int k=0;k<(n-2);k++){
            int t = fst + snd;
            // Console.WriteLine(fst + "+" + snd + "=" + t);
            Console.WriteLine(t);
            fst = snd;
            snd = t;
        }

    }

    //reverse 
    static int reverse(){
        Console.WriteLine("Provide a Numeber");
        int d = Convert.ToInt32(Console.ReadLine());
        int rev = 0;
        while(d>0){
            int rem = d % 10;
            rev = rev * 10 + rem;
            d = d / 10;                     //as d is integer type variable hence floor div not required
            }
        return rev;

    }



    //n is prime
    static bool isPrime(int n){
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 2; i <n; i += 1){
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        // factorial(3);
        // int x = reverse();
        // Console.WriteLine(x);



        // Console.WriteLine("Enter Prime number");
        // int n = Convert.ToInt32(Console.ReadLine());
        // bool e = isPrime(n);
        // if (e){
        //     Console.WriteLine(n + " is prime");
        // }else{
        //     Console.WriteLine(n + " is not prime");
        // }




        // fibbonacci();


        

    }
}

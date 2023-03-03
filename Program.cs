using System;

class Program {
    static void Main(string[] args){
        Console.Write("Enter Number:");
        int nonpass = int.Parse(Console.ReadLine());
        Console.Write("Enter Codename:");
        string noncode = Console.ReadLine();
        int nonpass100000 = nonpass / 100000;
        int nonpass10000 = (nonpass / 10000) % 10;
        int nonpass1000 = (nonpass / 1000) % 10;
        int nonpass100 = (nonpass / 100) % 10;
        int nonpass10 = (nonpass / 10) % 10;
        int nonpass1 = nonpass % 10;
        if(noncode == "CIA"){
            if(nonpass1 % 3 == 0 && nonpass10 != 1 && nonpass10 != 3 && nonpass10 != 5 && nonpass1000 >= 6 && nonpass1000 != 8){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else if(noncode == "FBI"){
            if(nonpass100000 >= 4 && nonpass100000 <= 7 && nonpass100 % 2 == 0 && nonpass100 != 6 && nonpass10000 % 2 != 0){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else if(noncode == "NSA"){
            if((nonpass1 == 7 || nonpass10 == 7 || nonpass100 == 7 || nonpass1000 == 7 || nonpass10000 == 7 || nonpass100000 == 7) && 30 % nonpass1 == 0 && nonpass100 % 3 == 0 && nonpass % 2 != 0){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else{
                Console.WriteLine("False");
            }
    }
}
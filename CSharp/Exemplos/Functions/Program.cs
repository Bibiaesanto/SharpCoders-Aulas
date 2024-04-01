// See https://aka.ms/new-console-template for more information
namespace Functions;

public class Program {
    //f(x) = x + 2
    static double SomarDois(double x){
        return x + 2;
    }

    // void = vazio
    static void SayHello(){
        Console.WriteLine("Hello!");
        return;
    }

    static void SayHelloToSomeone(string name){
        Console.WriteLine($"Hello, {name}");
    }

    // boolean = prefixo Is e Has
    // even = Par
    static bool IsEven(int num){
        return num%2 ==0;
    }

    static bool HasInvalidCharacters(string username){
        // logica para validar se o username esta com caracteres invalidos
        return false;
    }
    static double Somar(double a, double b){
        return a + b;
    }
    public static void Main(){
        string username = Console.ReadLine();

        //legibilidade
        if(HasInvalidCharacters(username)){
            // fal algo com o username
            System.Console.WriteLine("Username invalido!");
        }else
        {
            System.Console.WriteLine("Username valido!");
        }
        Console.WriteLine(SomarDois(5));
    }
}
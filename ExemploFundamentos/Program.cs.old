using System.IO;
using System.Linq;
using System;

class Programa{

    static void Main(string[] args)
    {
        int qt = Convert.ToInt32(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        if(qt > 0){
            for (int i = 0; i < qt; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                if(v.Length < 2 && v.Length > 0 ){
                    Console.WriteLine("entre com dois valores separados por um espaço.");
                    v = Console.ReadLine().Split(' ');
                    string a = v[0];
                    string b = v[1];
                    Console.WriteLine(Encaixa(a, b));
                
                }else{
                    string a = v[0];
                    string b = v[1];
                    Console.WriteLine(Encaixa(a, b));
                }
            
                
            }
        }
    }

    static string Encaixa(string a, string b){
        if (a.EndsWith(b)){
            return "encaixa";
        }
        else{
            return "nao encaixa";
        }
    }
}
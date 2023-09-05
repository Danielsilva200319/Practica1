// bool check = true;
// Console.WriteLine(check ? "Activo" : "Inactivo");
// Console.WriteLine(false ? "Activo" : "Inactivo");
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         double d = 3D;
//         d = 4d;
//         d = 3.934_001;
//         Console.WriteLine(d);
//         float f = 3_000.5F;
//         f = 5.4f;
//         Console.WriteLine(f);
//         decimal myMoney = 3_000.5m;
//         myMoney = 400.75M;
//         Console.WriteLine(myMoney);
//     }
// }
using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string ? Palabra;
        int idx;
        ArrayList Materias = new ArrayList();
        ArrayList Cursos = new ArrayList();

        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo Tecnico");
        Materias.Add("Ingles");

        Console.WriteLine("Ingrese la materia a buscar: ");
        Palabra = Console.ReadLine();

        idx = Materias .LastIndexOf(Palabra);

        Console.WriteLine("La asignatura {0} se encontro en la ultima pos de idx {1}",Palabra,idx);        
    }
}
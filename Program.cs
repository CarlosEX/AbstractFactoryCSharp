using System;
using CSHARP.ConcretesFactory;
using CSHARP.Interfaces;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelemovel nokiaTelemovel = new Nokia();
            TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

            Console.WriteLine("*************** NOKIA ***************");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDeralhes());
            Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDeralhes());

            ITelemovel sansungTelemovel = new Sansung();
            TelemovelClient sansungClient = new TelemovelClient(sansungTelemovel);

            Console.WriteLine("*************** SANSUNG ***************");
            Console.WriteLine(sansungClient.BuscarSmartPhoneModeloDeralhes());
            Console.WriteLine(sansungClient.BuscarNormalPhoneModeloDeralhes());

            Console.ReadKey();
        }
    }
}

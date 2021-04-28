using CSHARP.Interfaces;

namespace CSHARP
{
    public class Nokia600 : INormalPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Nokia 600\nRam: NA\nCamera: NA\n";
        }
    }
}
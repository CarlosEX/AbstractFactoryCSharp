using CSHARP.Interfaces;

namespace CSHARP
{
    public class SansungGuru : INormalPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Sansung Gutu\nRam: NA\nCamera: NA\n";
        }
    }
}
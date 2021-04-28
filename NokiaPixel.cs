using CSHARP.Interfaces;

namespace CSHARP
{
    public class NokiaPixel : ISmartPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Nokia Pixel\nRam: 360\nCamera: 8MP\n";
        }
    }
}
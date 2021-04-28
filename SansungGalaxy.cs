using CSHARP.Interfaces;

namespace CSHARP
{
    public class SansungGalaxy : ISmartPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Sansung Galaxy\nRam: 2GB\nCamera: 13MP\n";
        }
    }
}
using CSHARP.Interfaces;

namespace CSHARP.ConcretesFactory
{
    
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
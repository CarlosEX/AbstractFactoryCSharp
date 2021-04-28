using CSHARP.Interfaces;

namespace CSHARP.ConcretesFactory
{
    public class Sansung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SansungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SansungGalaxy();
        }
    }
}
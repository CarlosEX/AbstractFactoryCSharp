using CSHARP.Interfaces;

namespace CSHARP
{
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            smartPhone = telemovelFactory.BuscarSmartPhone();
            normalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDeralhes(){
            return smartPhone.BuscaDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDeralhes(){
            return normalPhone.BuscaDetalhesModelo();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            // teste.MetodoPrivado();//não vai
            //teste.MetodoProtegido();//não vai
            teste.MetodoInterno();
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // visível fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            // visível apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            // visível apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            // visível apenas para o projeto ByteBank.Modelos
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoComercial
{
    class Veiculo
    {
        public enum Cores { Branca, Preta, Vermelha, Azul }

        protected int _Id;
        protected string _Marca;
        protected string _Modelo;
        protected int _Ano;
        protected Cores _Cor;

        #region Construtores
        public Veiculo()
        {
            _Id = 0;
            _Marca = "";
            _Modelo = "";
            _Ano = 0;
            _Cor = Cores.Branca;
        }
        public Veiculo(int Id, string marca, string modelo, int ano, Cores cor)
        {
            _Id = Id;
            _Marca = marca;
            _Modelo = modelo;
            _Ano = ano;
            _Cor = cor;
        }
        public Veiculo(string marca, string modelo, int ano, Cores cor)
        {
            _Id = 0;
            _Marca = marca;
            _Modelo = modelo;
            _Ano = ano;
            _Cor = cor;
        }

        #endregion


        #region Propriedades

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string Marca
        {
            set { _Marca = value; }
            get { return _Marca; }
        }

        public string Modelo
        {
            set { _Modelo = value; }
            get { return _Modelo; }
        }

        public int Ano
        {
            set { _Ano = value; }
            get { return _Ano; }
        }

       public Cores Cor
        {
            set { _Cor = value; }
            get { return _Cor; }
        }
        #endregion

  
    }
}

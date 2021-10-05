using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoComercial
{
    class Carro : Veiculo
    {
        static List<Carro> Carros = new List<Carro>();
        static int MaxId = 0;

        int _Portas;

        #region construtores
        public Carro()
        {
            _Portas = 0;
        }
        public Carro(int id, string marca, string modelo, int ano, Cores cor, int portas)
            : base(id, marca, modelo, ano, cor)
        {
            _Portas = portas;
        }
        public Carro(string marca, string modelo, int ano, Cores cor, int portas)
           : base(marca, modelo, ano, cor)
        {
            _Portas = portas;
        }

        public Carro(int id)
        {
            Carro tc =Carros.Find(c => c.Id == id);
            _Id = tc.Id;
            _Marca = tc.Marca;
            _Modelo = tc.Modelo;
            _Ano = tc.Ano;
            _Cor = tc.Cor;
            _Portas = tc.Portas;
        }
         


        #endregion

        #region Propriedades
        public int Portas
        {
            set { _Portas = value; }
            get { return _Portas; }
        }
        #endregion

        #region Acesso a Dados
        public void Incluir()
        {
            MaxId++;
            _Id = MaxId;
            Carros.Add(this);
        }

        public static  List<Carro> Consultar()
        {
            return Carros;
        }

        public static List<Carro> Consultar(string marca)
        {
            return Carros.FindAll(c => c.Marca.Contains(marca));
        }

        public void Alterar()
        {
            int i;
            i = Carros.FindIndex(c => c.Id == _Id);
            Carros[i].Marca = _Marca;
            Carros[i].Modelo = _Modelo;
            Carros[i].Ano = _Ano;
            Carros[i].Cor = _Cor;
            Carros[i].Portas = _Portas;
        }

        public static void Excluir(int id)
        {
            int i;
            i = Carros.FindIndex(c => c.Id == id);
            Carros.Remove(Carros[i]);
        }

        public static void Preencher()
        {
            Carro c;
            c = new Carro("Volkswagen", "Fusca", 1976, Cores.Branca, 2);
            c.Incluir();
            c = new Carro("Ford", "Corcel", 1980, Cores.Azul, 4);
            c.Incluir();
            c = new Carro("Fiat", "147", 1982, Cores.Vermelha, 2);
            c.Incluir();
            c = new Carro("Chevrolet", "Opala", 1992, Cores.Preta, 4);
            c.Incluir();
        }

        #endregion
    }

}

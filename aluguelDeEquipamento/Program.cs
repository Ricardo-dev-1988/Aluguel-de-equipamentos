using System;
using System.Globalization;

namespace aluguelDeEquipamento {
    public class Produto {
        private long codigo;
        private String nome;
        private double preco;

        public Produto(long Codigo, String Nome, double Preco) {
            this.codigo = Codigo;
            this.nome = Nome;
            this.preco = Preco;
        }
        public long Codigo {
            set { this.codigo = value; }
            get { return codigo; }
        }
        public String Nome {
            set { this.nome = value; }
            get { return nome; }
        }
        public double Preco {
            set { this.preco = value; }
            get { return preco; }
        }

    }

    class Quantidade : Produto {
        public int quantidade;
        public int mult = 0;
        public Quantidade(long Codigo, String Nome, double Preco, int Quantidade)
            : base(Codigo, Nome, Preco) {
            this.quantidade = Quantidade;
        }
        public void setTotal(double Preco, int quantidade) {
            this.Preco = Preco;
            this.quantidade = quantidade;
        }
        public double getMulti() {
            return Preco * quantidade;
        }
    }

    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Quantidade produto1 = new Quantidade(723156980, "Notebook", 425.00, 2);
            Quantidade produto2 = new Quantidade(8241567899, "Projetor Multimídia XGA 5.200", 495.00, 1);
            Quantidade produto3 = new Quantidade(3244556789, "SISTEMA DE P.A", 390.00, 1);
            Quantidade produto4 = new Quantidade(567568899, "CAIXA AMPLIFICADA", 120.00, 2);


            Console.WriteLine("Código: " + produto1.Codigo);
            Console.WriteLine("Nome: " + produto1.Nome);
            Console.WriteLine("Preço: R$" + produto1.getMulti().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + produto1.quantidade);
            Console.WriteLine();

            Console.WriteLine("Código: " + produto2.Codigo);
            Console.WriteLine("Nome: " + produto2.Nome);
            Console.WriteLine("Preço: R$" + produto2.getMulti().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + produto2.quantidade);
            Console.WriteLine();

            Console.WriteLine("Código: " + produto3.Codigo);
            Console.WriteLine("Nome: " + produto3.Nome);
            Console.WriteLine("Preço: R$" + produto3.getMulti().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + produto3.quantidade);
            Console.WriteLine();

            Console.WriteLine("Código: " + produto4.Codigo);
            Console.WriteLine("Nome: " + produto4.Nome);
            Console.WriteLine("Preço: R$" + produto4.getMulti().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + produto4.quantidade);

            Console.ReadKey();

        }
    }
}


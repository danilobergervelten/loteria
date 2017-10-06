using Loteria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            //MegaSena mega = new MegaSena(id: 1, numeros: new List<int> { 1, 2, 3, 4, 5, 6 }, data: DateTime.Now);
            List<MegaSena> lstApostas = new List<MegaSena>();
            int identificador = 0;

            int opcao;
            do
            {
                Console.WriteLine("[ 1 ] Inserir aposta de mega sena");
                Console.WriteLine("[ 2 ] Inserir surpresinha de mega sena");
                Console.WriteLine("[ 3 ] Realizar sorteio");
                Console.WriteLine("[ 0 ] Sair");
                Console.WriteLine("-----");
                Console.Write("Digite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        lstApostas = InserirAposta(identificador, lstApostas);
                        identificador = lstApostas.Last().Id;
                        break;
                    case 2:
                        //InserirSurpresinha(ref , ref);
                        break;
                    case 3:
                        RealizarSorteio(lstApostas);
                        break;
                    case 4:
                        //ConferirAposta();
                        break;
                    default:
                        //saiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
        }

        public static List<MegaSena> InserirAposta(int ident, List<MegaSena> lstApostas)
        {
            ident++;
            string aux = string.Empty;
            List<int> aux2 = new List<int>();
            //lstApostas.Add(mega);
            do
            {
                aux2 = ListaNum(aux2);
            } while (aux2.Count() <= 5);

            MegaSena mega = new MegaSena(id: ident, numeros: aux2, data: DateTime.Now);
            lstApostas.Add(mega);

            foreach (int numeros in mega.Numeros)
            {
                aux += " - " + numeros.ToString();
            }

            Console.Clear();
            Console.WriteLine("Identificador:" + mega.Id + "\n números:" + aux + " \n " + mega.Data.ToString());

            return lstApostas;
        }

        private static List<int> ListaNum(List<int> aux2)
        {


            for (int i = 0; i < 6; i++)
            {


                if (aux2.Count() < 6)
                {
                    Console.WriteLine("Digite valor de 01 a 60");

                    int num = Int32.Parse(Console.ReadLine());
                    bool verdade = false;

                    if (num <= 0 || num > 60)
                    {
                        Console.WriteLine("Favor informar um número valido!!!");
                    }
                    else
                    {
                        if (aux2.Count() == 0)
                        {
                            aux2.Add(num);
                        }
                        else
                        {

                            if (aux2.Contains(num))
                            {
                                verdade = true;
                            }

                            if (!verdade)
                            {
                                aux2.Add(num);
                            }
                            else
                            {
                                Console.WriteLine("Favor informar um número que não foi informado!!!");
                            }
                        }
                    }
                }
            }
            return aux2.ToList();
        }

        public static void RealizarSorteio(List<MegaSena> lstApostas)
        {
            Random ra = new Random();
            List<int> listNumSorteio = new List<int>();
            string numSorteio = string.Empty;
            string mensagem = string.Empty;
            int num = 0;

            for (int i = 0; i < 6; i++)
            {
                num = ra.Next(1, 60);

                if (i == 5)
                {
                    numSorteio += num;
                }
                else
                {
                    numSorteio += num.ToString() + "-";
                }

                listNumSorteio.Add(num);
            }

            string msgNumAposta = string.Empty;
            bool ExisteNumero = false;
            foreach (var item in lstApostas)
            {                
                msgNumAposta = string.Empty;
                ExisteNumero = false;

                foreach (var numero in item.Numeros)
                {
                    //mensagem
                    if (item.Numeros.Last() == numero)
                    {
                        msgNumAposta += numero;
                    }
                    else
                    {
                        msgNumAposta += numero + "-";                        
                    }

                    if (listNumSorteio.Contains(numero))
                    {
                        foreach (var itemNum in listNumSorteio)
                        {
                            if(itemNum == numero)
                            {
                                ExisteNumero = true;
                                item.Acertos++;
                            }
                        }
                        
                    }
                }

                if (ExisteNumero)
                {
                    mensagem += "ID:" + item.Id + " Numeros da sorte:" + msgNumAposta + "Data:" + item.Data + " Acertos:" + item.Acertos + "\n";
                }

            }

            Console.WriteLine("Números do Sorteio:" + numSorteio);

            Console.WriteLine(mensagem);

        }

        //private static List<int> NumeroSorteio()
        //{
        //    return listNumSorteio;
        //}
    }
}


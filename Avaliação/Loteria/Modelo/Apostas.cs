using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loteria.Modelo
{
    class Apostas
    {
        private Elemento primeiro_elemento;
        private Elemento ultimo_elemento;
        private String nome;

        public Apostas()
        {
            nome = "";
            primeiro_elemento = null;
            ultimo_elemento = null;
        }
        public Apostas(String nome_novo)
        {
            nome = nome_novo;
            primeiro_elemento = null;
            ultimo_elemento = null;
        }

        public void Inserir(int id, List<int> numeros, DateTime data)
        {
            if (primeiro_elemento == null)
            {
                ultimo_elemento = primeiro_elemento = new Elemento(id, numeros, data);
            }
            //else
            //{
            //    primeiro_elemento = new Elemento(novo_nome, novo_codigo, novo_preco, primeiro_elemento);
            //}
        }


        //public void ExcluirPrimeiro()
        //{
        //    if (primeiro_elemento == null)
        //    {
        //        Console.WriteLine("Lista vazia para excluir");
        //    }
        //    else
        //    {
        //        if (primeiro_elemento.Proximo == null)
        //        {
        //            primeiro_elemento = null;
        //            ultimo_elemento = null;
        //        }
        //        else
        //        {
        //            primeiro_elemento = primeiro_elemento.Proximo;
        //            primeiro_elemento.Anterior = null;
        //        }
        //    }
        //}

        //public void Listar1()
        //{
        //    if (primeiro_elemento == null)
        //    {
        //        Console.WriteLine("Lista vazia");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\tLista do Inicio" + nome);
        //        Console.WriteLine("+++");
        //        Elemento elemento_atual = primeiro_elemento;
        //        while (elemento_atual != null)
        //        {
        //            Console.Write(elemento_atual.P.Nome + "     ");
        //            Console.Write(elemento_atual.P.Codigo + "     ");
        //            Console.Write(elemento_atual.P.Preco + "     ");
        //            Console.Write("\n");
        //            elemento_atual = elemento_atual.Proximo;
        //        }
        //    }
        //}

        //public void Listar2()
        //{
        //    if (ultimo_elemento == null)
        //    {
        //        Console.WriteLine("Lista vazia");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\tLista do Fim" + nome);
        //        Console.WriteLine("++");
        //        Elemento elemento_atual = ultimo_elemento;
        //        while (elemento_atual != null)
        //        {
        //            Console.Write(elemento_atual.P.Nome + "     ");
        //            Console.Write(elemento_atual.P.Codigo + "     ");
        //            Console.Write(elemento_atual.P.Preco + "     ");
        //            Console.Write("\n");
        //            elemento_atual = elemento_atual.Anterior;
        //        }
        //    }
        //}
    }
}

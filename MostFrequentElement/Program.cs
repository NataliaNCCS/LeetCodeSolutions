using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -------------------- ATENÇÃO: ESSE EXERCÍCIO NÃO É DA PLATAFORMA LEETCODE --------------------
                Esse exercício é uma refatoração de um código feito durante um teste técnico para uma vaga de estágio.
                

                ENUNCIADO:
                Uma sorveteria fez uma pesquisa para descobrir qual dos cinco sabores que servem é o mais popular. 
                As opções de sabor são: flocos, chocolate, morango, creme e napolitano. 
                O seu trabalho é contabilizar qual é o sabor mais popular.
                Os sabores foram mapeados para códigos de acordo com a seguinte tabela:

                0 - Flocos
                1 - Chocolate
                2 - Morango
                3 - Creme
                4 - Napolitano

                Você deve escrever uma função que recebe como parâmetro um array contendo os votos de todos 
                os participantes identificados pelos respectivos códigos e retorna o código do sabor mais popular. 
                Se houver um empate, o menor código entre os empatados deve ser retornado.

                Exemplos:
                Entrada [ 0, 2, 3, 4, 4]
                Deve retornar 4, pois é o sabor com maior ocorrência

                Entrada [ 1, 1, 1, 3, 4, 4]
                Deve retornar 1, pois é o sabor com maior ocorrência

                Entrada [ 1, 1, 3, 0, 1, 4, 0, 0]
                Deve retornar 0, pois, apesar de ter o mesmo número de ocorrências que 1, esse código é menor.
             */


            int[] arr = { 10, 10, 20, 20, 2, 2, 2, 2, 2, 5 };

            Console.WriteLine(maisFrequente(arr));

            Console.ReadKey();


        }


        public static int maisFrequente(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }

            }

            map = map.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); //ToDictionary pega o resultado da consulta LINQ

            int maiorFreq = map.Last().Value; //pega a maior frequência

            var maisFreq = from x in map
                           where x.Value == maiorFreq
                           select x.Key; //pega a chave da maior frequência (ex num "1" teve frequencia "5" - a chave é 1 e o valor é 5)

            int res = maisFreq.Min(); //pega o menor valor dentre das chaves selecionadas pelo LINQ

            return res;
        }
    }
}

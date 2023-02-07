using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menù
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazioni

            string animale;
            string[] vet = new string[100];
            int indice = 0;
            int sceltamenù = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(" MENU': ");
                Console.WriteLine("1- AGGIUNTA: ");
                Console.WriteLine("2- CANCELLA: ");
                Console.WriteLine("3- ORDINE ALFABETICO: ");
                Console.WriteLine("4- RICERCA SEQUENZIALE ANIMALE: ");
                Console.WriteLine("5- VISUALIZZA ANIMALI RIPETUTI: ");
                Console.WriteLine("6- MODIFICA NOME: ");
                Console.WriteLine("7- VISUALIZZAZIONE ANIMALI");
                Console.WriteLine("8- RICERCA NOME PIU' LUNGO E PIU'");
                Console.WriteLine("9- CANCELLA TUTTI I NOMI UGUALI");

                sceltamenù = int.Parse(Console.ReadLine());


                switch (sceltamenù)
                {
                    case 1:
                        Console.WriteLine("inserisci animale: ");
                        animale = Console.ReadLine();


                        if (Aggiunta(vet, ref indice, animale) == true)
                        {

                        }
                        else
                        {
                            Console.WriteLine("L'array è pieno!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Inserisci il nome dell'animale da cancellare: ");
                        animale = Console.ReadLine();
                        Cancella(ref vet, animale);
                        break;

                    case 3:
                        OrdineAlfabetico(ref vet);
                        break;

                    case 4:
                        Console.WriteLine("Inserisci il nome di un animale da ricercare:");
                        animale = Console.ReadLine();
                        int ricseq = RicercaSequenziale(ref vet, animale);
                        if (ricseq == -1)
                        {
                            Console.WriteLine("la parola non è stata trovata!");

                        }
                        else
                        {
                            Console.WriteLine("la parola è stata trovata in posizion" + ricseq);
                        }
                        break;

                    case 5:

                        break;


                    case 6:
                        ModificaNome();
                        break;





                }

            } while (sceltamenù != 0);





        }
        static bool Aggiunta(string[] vet, ref int indice, string animale)
        {
            bool inserimento = true;
            if (indice < vet.Length)
            {
                vet[indice] = animale;
                indice++;
            }
            else
            {
                inserimento = false;
            }
            return inserimento;

        }
        static void Cancella(ref string[] vet, string animale)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == animale)
                {
                    int var = 1;
                    while (var < vet.Length - 1)
                    {
                        vet[i] = vet[var + 1];
                        var++;
                    }
                }
            }

        }
        static void OrdineAlfabetico(ref string[] vett)
        {
            int x, y;
            string temp;
            for (x = 0; x < vett.Length; x++)
            {
                for (y = 0; y < vett.Length - 1; y++)
                {
                    if (string.Compare(vett[y], vett[y + 1]) < 0)
                    {
                        temp = vett[y];
                        vett[y] = vett[y + 1];
                        vett[y + 1] = temp;
                    }

                }
            }
        }
        static int RicercaSequenziale(ref string[] vet, string animale)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i].Equals(animale))
                {
                    return i;
                }
            }
            return -1;

        }
        static void funzione5()
        {

        }
        static void ModificaNome(ref string[] vet, string animale, string parolaGiusta)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = parolaGiusta;
                break;
            }

        }
        static void VisualizzaAnimali(string[] a)
        {
            for(int i=0;i<99;i++)
            {
                if (a[i] == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void funzione8()
        {

        }
        static void funzione9()
        {

        }
    }
}


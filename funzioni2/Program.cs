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
                Console.WriteLine("8- RICERCA NOME PIU' LUNGO E PIU' CORTO ");
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
                        Console.WriteLine(funzione5(vet, lun));
                        break;


                    case 6:
                        ModificaNome(vet);
                        break;

                    case 7:
                        VisualizzaAnimali(vet);
                        break;

                    case 8:
                        Console.WriteLine(funzione8(vet, animale));
                        break;

                    case 9:
                        Console.WriteLine("Inserisci l'elemento da eliminare");
                        string el = Console.ReadLine();

                        funzione9(vet, el);
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
        static void funzione5(int lun, string[] vet)
        {
            int[] occorrenze = new int[lun];
            string[] uni = new string[lun];
            string outp = "";
            for (int i = 0; i < lun; i++)
            {
                uni[i] = vet[i];
            }
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++)
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(uni[y], uni[y + 1]);
                    if (comp == 1)
                    {
                        temp = uni[y];
                        uni[y] = uni[y + 1];
                        uni[y + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < lun; i++)
            {
                if (uni[i] != "")
                {
                    occorrenze[i] = 1;
                    for (int j = i + 1; j < lun; j++)
                    {
                        if (uni[i] == uni[j])
                        {
                            uni[j] = "";
                            occorrenze[i]++;
                        }
                    }
                    if (occorrenze[i] > 1)
                    {
                        outp += ($"{uni[i]}: {occorrenze[i]}");
                    }
                }
            }
            return outp;
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
        static void funzione8(string[]arr, int lun)
        {
            string lungo = arr[0], corto = arr[0];
            string outp = "";
            for(int i = 1; i < lun; i++)
            {
                if (arr[i].Length > lungo.Length)
                {
                    lungo = arr[i];
                }
                if (arr[i].Length < lungo.Length)
                {
                    corto = arr[i];
                }
            }         
            outp += ($"Il nome più lungo è:{lungo}\n il nome più corto è:{corto}");
            return outp;
        }
        static void funzione9(string[]a, string e)
        {
            for(int g=0;g<a.Length;g++)
            {
                if (a[g].ToLower() == e.ToLower())
                {
                    for(int j = g; j < 99; j++)
                    {
                        a[j] = a[j + 1];
                    }
                }
            }
        }
    }
}


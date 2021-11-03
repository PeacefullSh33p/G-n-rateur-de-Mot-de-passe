using System;

namespace Générateur_de_Mot_de_passe
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Choisissez le nombre de caractères souhaités pour le mot de passe (4 minimums).");
            Console.WriteLine("Vous voulez un mot de passe avec :");
            Console.WriteLine(" Tapez 1 pour des caractères en minuscule");
            Console.WriteLine("Tapez 2 pour des caractères Majuscules");
            Console.WriteLine("Tapez 3 pour des caractères et des chiffres");
            Console.WriteLine("Tapez 4 pour des caractères, chiffres, et caractères spéciaux");
            int Minuscule = 1;
            int Majuscule = 2;
            int chiffres = 3;
            int CaractèreSpéciaux = 4;
            int nombre_de_caractères ;
            




           
            

             while (!int.TryParse(Console.ReadLine(), out nombre_de_caractères) || nombre_de_caractères <= 3)
            {
                Console.Write("Seulement des chiffres au minimun  de 4");
            }
            Console.WriteLine("Le mot de passe fera " + nombre_de_caractères + " de longueur.");



            string réponse = Console.ReadLine();// saisi l'entrée du choix d'options
            
            int RP = int.Parse(réponse); // converti la string réponse en int RP

            
            
            if (RP == Minuscule)
            {
                int i2 = 0;
                while ( i2 < 10)// si i2 inférieur à 10
                {
                    
                    
                    int i = 0;
                    while (nombre_de_caractères > i)
                    {

                        Random rand = new Random();
                        int ascii_index = rand.Next(97, 122);
                        char MinusculeT = Convert.ToChar(ascii_index);
                        Console.Write(MinusculeT);
                        
                        i = i + 1;

                    }
                    i2 = i2 + 1;
                    Console.WriteLine("");
                }
                
                
                

            }
            
            else if (RP == Majuscule) 
            {
                int i2 = 0;
                while (i2 < 10) // tant que i2 inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(65, 90); // randomize les caractères ascii entre 65, 90
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }

                int i = 0;
                while (nombre_de_caractères > i)// tant que nombre_de_caractères supérieur à i
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(65, 90);
                    char MajusculeT = Convert.ToChar(ascii_index);
                    Console.Write("\r" + MajusculeT);
                    i = i + 1;
                }
            }
            
            
            else if (RP == chiffres)
            {

                int i2 = 0;
                while (i2 < 10)// tant que i2 est inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(30, 39);
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }


                int i = 0;
                while (nombre_de_caractères > i)// tant que nombre_de_caractères supérieur à i
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(30, 39);
                    char chiffres1 = Convert.ToChar(ascii_index);
                    Console.Write(chiffres1);
                    i = i + 1;
                }
            }

            else if (RP == CaractèreSpéciaux)
            {
                int i2 = 0;
                while (i2 < 10)// tant que i2 est inférieur à 10
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(32, 47);
                    char MinusculeT = Convert.ToChar(ascii_index);
                    Console.Write(MinusculeT);
                    i2 = i2 + 1;

                }

                int i = 0;
                while (nombre_de_caractères > i)// tant que nombre_de_caractères supérieur à i
                {
                    Random rand = new Random();
                    int ascii_index = rand.Next(32, 47);
                    char CaracSpé = Convert.ToChar(ascii_index);
                    Console.WriteLine(CaracSpé);
                    i = i + 1;
                }
            }
        }   

    }
}

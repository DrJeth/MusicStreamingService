using MusicLibraryBL;
using MusicStreamingModel;
using System;
//Jethro L. Sarmiento
namespace MusicStreamingServiceUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;
            MusicAlbum service = new MusicAlbum();

            while (isActive)
            {
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("Welcome!!! Please Enter your Artist");

                string choice;
                Console.WriteLine("1- Miley Cyrus");
                Console.WriteLine("2- Olivia Rodrigo");
                Console.WriteLine("3- Harry Styles");
                Console.WriteLine("4- Taylor Swift");
                Console.WriteLine("5- Ed Sheeran");
                Console.WriteLine("6- Charlie Puth");
                Console.WriteLine("7- Coldplay");
                Console.WriteLine("8- Lady Gaga");
                Console.WriteLine("9- Joji");
                Console.WriteLine("10- Stephen Sanchez");
                Console.WriteLine("----------------------------------------\n");
                Console.Write("Enter your Artist. Type 0 to exit: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        choice = "exit";
                        break;
                    case "1":
                        choice = "Miley Cyrus";
                        break;
                    case "2":
                        choice = "Olivia Rodrigo";
                        break;
                    case "3":
                        choice = "Harry Styles";
                        break;
                    case "4":
                        choice = "Taylor Swift";
                        break;
                    case "5":
                        choice = "Ed Sheeran";
                        break;
                    case "6":
                        choice = "Charlie Puth";
                        break;
                    case "7":
                        choice = "Coldplay";
                        break;
                    case "8":
                        choice = "Lady Gaga";
                        break;
                    case "9":
                        choice = "Joji";
                        break;
                    case "10":
                        choice = "Stephen Sanchez";
                        break;
                }

                Song result = service.GetSongByArtist(choice) ?? null;

                if (result != null && choice != "exit")
                {
                    DisplaySongInfo(result);
                }
                else
                {
                    if (choice == "exit")
                    {
                        Console.WriteLine("Thank you and goodbye!\n");
                        isActive = false;
                    }
                    else
                    {
                        Console.WriteLine("Artist Choice does not Exist :(\n");
                    }
                }
            }
        }
        public static void DisplaySongInfo(Song sound)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Song Title: " + sound.SongTitle);
            Console.WriteLine("Artist: " + sound.Artist);
            Console.WriteLine("Composer: " + sound.Composer);
            Console.WriteLine("Duration: " + sound.Duration);
            Console.WriteLine("Release Date: " + sound.ReleaseDate);
            Console.WriteLine("------------------------------------------\n");

        }
    }
}

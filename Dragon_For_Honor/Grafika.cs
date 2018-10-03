using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using System.IO;
namespace Dragon_For_Honor
{
    class Grafika
    {
        public const string adatok_hely= "Adatok/";
        public const string grafika_hely = "Adatok/Grafika/";
        public const string kepek = ".png";

        static Sprite[] spritok;
        static int sprite_darabszam;

        public static void Jatek_Betoltese()
        {
            Sprite_Ellenorzes();
        }

        public static void Render_Grafika()
        {
            Kep_Rajzolas();
        }
      /// <summary>
      /// kirajzolja a spritokat
      /// </summary>
      /// <param name="sprite"></param>
      /// <param name="hely"></param>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <param name="ax"></param>
      /// <param name="ay"></param>
      /// <param name="hossz"></param>
      /// <param name="magassag"></param>
        public static void Rendereles(Sprite sprite,RenderWindow hely,int x,int y,int ax,int ay,int hossz,int magassag)
        {
            
             sprite.TextureRect = new IntRect(ax,ay,hossz, magassag);
           
            sprite.Position = new SFML.System.Vector2f(x, y);
            hely.Draw(sprite);


        }
        public static void Kep_Rajzolas()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Rendereles(spritok[1], Program.Jatek_Window, (i * 100), (j * 100), 0, 0, 100, 100);
                }
            }
            
           
        }
        /// <summary>
        /// A pályát alkotó képeket betölti
        /// </summary>
        /// 
        static void Sprite_Ellenorzes()
        {
            Console.WriteLine("Pálya elemek betöltése...");
            sprite_darabszam = 1;
            while (File.Exists(grafika_hely+ "Palya_elemek/"+ sprite_darabszam+ kepek)) {
               
                sprite_darabszam++;
            }

            
            Array.Resize(ref spritok, sprite_darabszam);
            for (int i = 1; i < sprite_darabszam; i++)
            {
                 
                spritok[i] = new Sprite(new Texture(grafika_hely + "Palya_elemek/" + i + kepek));
            }
            Console.WriteLine("Betöltve");
        }

    }
}

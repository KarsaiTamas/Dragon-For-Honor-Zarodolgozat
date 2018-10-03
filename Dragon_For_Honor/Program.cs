using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
namespace Dragon_For_Honor
{
    class Program
    {
        /// <summary>
        /// Ez a játéknak az ablaka
        /// </summary>
        public static RenderWindow Jatek_Window;

        static void Main(string[] args)
        {
            Jatek_Window = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Dragon For Honor");

            Grafika.Jatek_Betoltese();

            Jatek();


        }
        static void Jatek()
        {
            while (Jatek_Window.IsOpen)
            {

                Jatek_Window.DispatchEvents();
                Jatek_Window.Clear(Color.Blue);

                Grafika.Render_Grafika();



                Jatek_Window.Display();
            }
        }
    }
}

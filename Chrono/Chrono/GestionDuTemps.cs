using System.Threading.Tasks;

namespace Chrono
{
    class GestionDuTemps
    {
    
        static public int sec = 0 ;
        static public int minutes = 0;
        static public bool stop = false;


        public static async Task LancerChrono()
        {
            stop = false;
  
            while (stop != true)
            {
                await Task.Delay(1000);
                sec++;
                if (sec == 60)
                {
                    sec = 0;
                    minutes++;
                }

            }

        }

        public static void arreterChrono()
        {
            stop = true;
        }

    }
}

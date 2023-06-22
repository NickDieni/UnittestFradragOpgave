using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fradrag
    {
        public float CalcFradrag(float km, int type)
        {
            try
            {
                if(km <= 24)
                {
                    return 0;
                }
                float pris = 2.16f;
                float penge = 0;

                if (km > 120)
                {
                    float temp = km - 120;
                    penge = temp * 1.08f;
                    km -= temp;
                }

                float bropenge = 0;
                if (type == 0)
                {
                    bropenge = 0;
                }
                else if (type == 1)
                {
                    bropenge = 50 * 2;
                }
                else if (type == 2)
                {
                    bropenge = 110 * 2;
                }

                penge += (km - 24) * pris + bropenge;

                return penge;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"CalcFradrag Error: {ex}");
                return -1;
            }
        }
        public float CalcFradragTog(float km, int type)
        {
            try
            {
                if (km <= 24)
                {
                    return 0;
                }
                float pris = 2.16f;
                float penge = 0;

                if (km > 120)
                {
                    float temp = km - 120;
                    penge = temp * 1.08f;
                    km -= temp;
                }

                float bropenge = 0;
                if (type == 0)
                {
                    bropenge = 0;
                }
                else if (type == 1)
                {
                    bropenge = 8 * 2;
                }
                else if (type == 2)
                {
                    bropenge = 15 * 2;
                }

                penge += (km - 24) * (pris + bropenge) ;

                return penge;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"CalcFradrag Error: {ex}");
                return -1;
            }
        }

        public float CalcKm(float km)
        {
            try
            {
                km *= 2;

                if (km <= 24)
                {
                    return 0;
                }

                return km;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"CalcKm Error: {ex}");
                return -1;
            }
        }

        public float Bro()
        {
            //Console.WriteLine("[0] Ingen bro\n[1] Storebælt\n[2] Øresund");
            int type = 0;//Convert.ToInt32(Console.ReadLine());

            if (type == 0)
            {
                return 0;
            }

            if (type == 1)
            {
                return 50 * 2;
            }

            return 110 * 2;
        }
    }

    public class Print
    {
        public float CalcSum()
        {
            //Console.Write("Kilometer til arbejde: ");
            float km = 0; //Convert.ToSingle(Console.ReadLine());
            int type = 0;

            Fradrag test = new Fradrag();
            float totalKm = test.CalcKm(km);

            float penge = test.CalcFradrag(totalKm, type);
            return penge;
        }

        public void PrintMoney(float penge)
        {
            float rounded = (float)Math.Round(penge, 3);
            //Console.WriteLine($"Penge tilbage: {rounded}kr");
        }

    }
}

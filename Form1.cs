using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.Common;

namespace NeuroNet
{
    public partial class Form1 : Form
    {
        /*   Neuru A0 ;
           Neuru A1 ;
           Neuru A2 ;
           Neuru A3;
           Neuru A4 ;
           Neuru A5 ;
           Neuru A6 ;
           Neuru A7 ;*/
        static int CountA = 768;
        static int CountB = 192;
        Neuru[] A_Massiv ;
        NeuruB[] B_Massiv;


        //  NeuruB B1Shops ;
        NeuruC C_Summ;

        double x0;
        double x1;
        double x2;
        double x3;
        double x4;
        double x5;
        double x6;
        double x7;
        double x8;
        double x9;
        double x10;
        double x11;
        double x12;
        double x13;
        double x14;
        double x15;



        public Form1()
        {
            InitializeComponent();
            A_Massiv = new Neuru[CountA];
             B_Massiv = new NeuruB[CountB];
            //            Parallel.For(1, 4, Factorial);

            //     Console.ReadLine();
            //    return;
            /*   A0 = new Neuru();
               A1 = new Neuru();
               A2 = new Neuru();
               A3 = new Neuru();
               A4 = new Neuru();
               A5 = new Neuru();
               A6 = new Neuru();
               A7 = new Neuru();
               */


            for (int k = 0; k <= CountA-1; k++)
            {
                A_Massiv[k] =new Neuru();


            }
            for (int k = 0; k <= CountB-1; k++)
            {
                B_Massiv[k] = new NeuruB();


            }

            //   B1Shops = new NeuruB();
               C_Summ = new NeuruC();

            Query();

        }

     
         void renewA(int x)
        {


            for (int k = (x-1)* (CountA / CountProc); k <= x*((CountA / CountProc))-1; k++)
            {
                A_Massiv[k].x0 = x0;
                A_Massiv[k].x1 = x1;
                A_Massiv[k].x2 = x2;
                A_Massiv[k].x3 = x3;
                A_Massiv[k].x4 = x4;
                A_Massiv[k].x5 = x5;
                A_Massiv[k].x6 = x6;
                A_Massiv[k].x7 = x7;
                A_Massiv[k].x8 = x8;
                A_Massiv[k].x9 = x9;
                A_Massiv[k].x10 = x10;
                A_Massiv[k].x11 = x11;
                A_Massiv[k].x12 = x12;
                A_Massiv[k].x13 = x13;
                A_Massiv[k].x14 = x14;
                A_Massiv[k].x15 = x15;

                double out_A_Massiv = A_Massiv[k].CalcOut();
                for (int n = 0; n <= CountB-1; n++)
                {
                    B_Massiv[n].x_massiv[k] = out_A_Massiv;
                }

            }
            //***





            

           // Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
          //  Console.WriteLine("Факториал числа {0} равен {1}", x, result);
            
        }
        int CountProc = 32;
        public void   RenewAll()
        {
            Parallel.For(1, CountProc+1, renewA);

         


            Parallel.For(1, CountProc + 1, renewB);
         /*   for (int n = 0; n <= 199; n++)
            {
                C_Summ.x_massiv[n] = B_Massiv[n].CalcOut();


            }
            */


            outCSumm = C_Summ.CalcOut();
            //   label2.Text = outB1Shops.ToString();



        }
        void renewB(int x)
        {


            for (int n = (x - 1) * (CountB / CountProc); n <= x * ((CountB / CountProc)) - 1; n++)
            {

                C_Summ.x_massiv[n] = B_Massiv[n].CalcOut();

            }

                        // Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
                        //  Console.WriteLine("Факториал числа {0} равен {1}", x, result);

                    }
        // double outB1Shops;
        double outCSumm;

        static Random rnd = new Random();
        public  class Neuru{
            double e = 2.718281828459045235360;
            public  Neuru()
            {                
                w0 = Convert.ToDouble(rnd.Next( 1000)) / 1000-0.5;
                w1 = Convert.ToDouble(rnd.Next( 1000)) / 1000 - 0.5;
                w2 = Convert.ToDouble(rnd.Next( 1000)) / 1000 - 0.5;
                w3 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w4 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w5 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w6 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w7 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w8 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w9 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w10 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w11 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w12 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w13 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w14 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
                w15 = Convert.ToDouble(rnd.Next(1000)) / 1000 - 0.5;
            }

            public double w0;
            public double w1;
            public double w2;
            public double w3;
            public double w4;
            public double w5;
            public double w6;
            public double w7;
            public double w8;
            public double w9;
            public double w10;
            public double w11;
            public double w12;
            public double w13;
            public double w14;
            public double w15;

            public double x0;
            public double x1 ;
            public double x2;
            public double x3;
            public double x4;
            public double x5;
            public double x6;
            public double x7;
            public double x8;
            public double x9;
            public double x10;
            public double x11;
            public double x12;
            public double x13;
            public double x14;
            public double x15;

            public double res1;
            public double res2;

            public double  CalcOut()
            {
                 res1 = (x0 * w0) + (x1 * w1) + (x2 * w2) + (x3 * w3) + (x4 * w4) + (x5 * w5) + (x6 * w6) + (x7 * w7) + (x8 * w8) + (x9 * w9) + (x10 * w10) + (x11 * w11) + (x12 * w12) + (x13 * w13) + (x14 * w14) + (x15 * w15);
                 res2 = 1 / (1 + Math.Pow(e, -res1));
                return res2;
            }



            };
        public partial class NeuruB
        {
            double e = 2.718281828459045235360;
            public  NeuruB(){

                //  Random rnd = new Random();


                /*   w0 = Convert.ToDouble(rnd.Next(0,1000))  / 1000;
                   w1 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w2 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w3 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w4 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w5 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w6 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w7 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   */

                for (int k = 0; k <= CountA-1; k++)
                {
                    w_massiv[k] = Convert.ToDouble(rnd.Next(0, 1000)) / 1000 - 0.5;

                }

                }


            public double[] w_massiv=new double[CountA];
            public double[] x_massiv = new double[CountA];

            /*  public double w0;
              public double w1;
              public double w2;
              public double w3;
              public double w4;
              public double w5;
              public double w6;
              public double w7;


              public double x0;
              public double x1;
              public double x2;
              public double x3;
              public double x4;
              public double x5;
              public double x6;
              public double x7;
  */
            public double res1;
            public double res2;

            public double CalcOut()
            {
                res1 = 0;
                for (int k = 0; k <= CountA-1; k++)
                {
                    res1 =res1+( w_massiv[k] * x_massiv[k]);

                }


              //  res1 = (x0 * w0) + (x1 * w1) + (x2 * w2) + (x3 * w3) + (x4 * w4) + (x5 * w5) + (x6 * w6) + (x7 * w7);
                 res2 = 1 / (1 + Math.Pow(e, -res1));
                return res2;
            }



        };
        public partial class NeuruC
        {
            double e = 2.718281828459045235360;
            public NeuruC()
            {

                //  Random rnd = new Random();


                /*   w0 = Convert.ToDouble(rnd.Next(0,1000))  / 1000;
                   w1 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w2 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w3 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w4 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w5 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w6 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   w7 = Convert.ToDouble(rnd.Next(0, 1000)) / 1000;
                   */

                for (int k = 0; k <= CountB-1; k++)
                {
                    w_massiv[k] = Convert.ToDouble(rnd.Next(0, 1000)) / 1000 - 0.5;

                }

            }


            public double[] w_massiv = new double[CountB];
            public double[] x_massiv = new double[CountB];

            /*  public double w0;
              public double w1;
              public double w2;
              public double w3;
              public double w4;
              public double w5;
              public double w6;
              public double w7;


              public double x0;
              public double x1;
              public double x2;
              public double x3;
              public double x4;
              public double x5;
              public double x6;
              public double x7;
  */
            public double res1;

            public double CalcOut()
            {
                res1 = 0;
                for (int k = 0; k <= CountB-1; k++)
                {
                    res1 = res1 + (w_massiv[k] * x_massiv[k]);

                }


                //  res1 = (x0 * w0) + (x1 * w1) + (x2 * w2) + (x3 * w3) + (x4 * w4) + (x5 * w5) + (x6 * w6) + (x7 * w7);
                double res2 = 1 / (1 + Math.Pow(e, -res1));
                return res2;
            }



        };

        private void button1_Click(object sender, EventArgs e)
        {
            
            chart1.ChartAreas[0].AxisX.Minimum = 365;
            chart1.ChartAreas[0].AxisX.Maximum = 365*10;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart2.ChartAreas[0].AxisX.Minimum = 365;
            chart2.ChartAreas[0].AxisX.Maximum = 365 * 10;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 1;

            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = 1;


            double[] x = new double[16*365];
            double[] y = new double[16*365];


            double[] x_ = new double[16 * 365];
            double[] y_ = new double[16 * 365];

            int z = 0;
            for (int k = 8; k <= 8; k++)
            {                
                for (int i = 0; i < 366; i++)
                {
                    //x0 = (k) / 15.0; /// запихиваем гол от 0 до 1


                    string DataStr = "";
                  
                        DataStr = "20" + (k+11);

                    

                    int Day = ((k * 365) + i);
                    

    
                            string DayStr=Convert.ToString(Day,2);
                            int h = (16 - DayStr.Length);
                            for (int d = 0; d < h; d++)
                            {
                                DayStr = "0" + DayStr;

                            }




                    //x0 = (Convert.ToInt16(DataStr) - 2010) / 15.0; /// запихиваем гол от 0 до 1
                    x15 = GetIn(Convert.ToInt16(DayStr.Substring(0, 1)));
                    x14 = GetIn(Convert.ToInt16(DayStr.Substring(1, 1)));
                    x13 = GetIn(Convert.ToInt16(DayStr.Substring(2, 1)));
                    x12 = GetIn(Convert.ToInt16(DayStr.Substring(3, 1)));
                    x11 = GetIn(Convert.ToInt16(DayStr.Substring(4, 1)));
                    x10 = GetIn(Convert.ToInt16(DayStr.Substring(5, 1)));
                    x9 = GetIn(Convert.ToInt16(DayStr.Substring(6, 1)));
                    x8 = GetIn(Convert.ToInt16(DayStr.Substring(7, 1)));
                    x7 = GetIn(Convert.ToInt16(DayStr.Substring(8, 1)));
                    x6 = GetIn(Convert.ToInt16(DayStr.Substring(9, 1)));
                    x5 = GetIn(Convert.ToInt16(DayStr.Substring(10, 1)));
                    x4 = GetIn(Convert.ToInt16(DayStr.Substring(11, 1)));
                    x3 = GetIn(Convert.ToInt16(DayStr.Substring(12, 1)));
                    x2 = GetIn(Convert.ToInt16(DayStr.Substring(13, 1)));
                    x1 = GetIn(Convert.ToInt16(DayStr.Substring(14, 1)));
                    x0 = GetIn(Convert.ToInt16(DayStr.Substring(15, 1)));




                    RenewAll();
                    x[z] = (k *365)+ i;
                    y[z] =outCSumm;

                    //*******************************
                           double summaPokupki = 0;
                          //  double ShopPokupki = 0;
                            DateTime date = new DateTime(Convert.ToInt16(DataStr), 1, 1);
                            DataStr = date.AddDays(i).ToString("d");



                            for (int n = 0; n < dtMassiv.Count; n++)
                            {
                                string DataStrInQuery = dtMassiv[n].ToString().Substring(0, 10);
                                if (DataStr == DataStrInQuery)
                                {

                                    summaPokupki = Convert.ToDouble(SummaMassiv[n]);
                                   // ShopPokupki = ShopIDMassiv[n];

                                    //    dtMassiv_Temp.RemoveAt(n);
                                    //    SummaMassiv_Temp.RemoveAt(n);
                                    //    ShopIDMassiv_Temp.RemoveAt(n);

                                    break;
                                };

                            };
                    x_[z] = (k * 365) + i;
                    y_[z] = summaPokupki/10000.0;
                    
                    //  y[z] = 10;

                    z++;

                }

            }

            chart1.Series[0].Points.DataBindXY(x, y);

            chart2.Series[0].Points.DataBindXY(x_, y_);


        }
        double TrueZnachShops;
        double TrueZnachSumm;
        double koefizient;
        double e = 2.718281828459045235360;
        //  double koefizient = .005;
        double mu = 0.35;


        double[] DeltaW_B_C_old=new double[CountB];
        double[,] DeltaW_A_B_old = new double[CountB, CountA];
        void TrainB(int x)
        {

            
            for (int k = (x - 1) * (CountB / CountProc); k <= x * ((CountB / CountProc)) - 1; k++)
            {


                double ErrorB = (ErrorCSumm * C_Summ.w_massiv[k]) * B_Massiv[k].res2 * (1 - B_Massiv[k].res2);
                ErrorBMassiv[k] = ErrorB;
                double DeltaW_B_C = C_Summ.x_massiv[k] * ErrorCSumm * koefizient;                
                C_Summ.w_massiv[k] = C_Summ.w_massiv[k] + DeltaW_B_C-mu* DeltaW_B_C_old[k];
                DeltaW_B_C_old[k] = DeltaW_B_C;
                //  if (ErrorA != 0)


                for (int n = 0; n <= CountA-1; n++)
                {
                    double DeltaW_A_B = B_Massiv[k].x_massiv[n] * ErrorB * koefizient;
                    B_Massiv[k].w_massiv[n] = B_Massiv[k].w_massiv[n] + DeltaW_A_B- mu*DeltaW_A_B_old[k,n];
                    DeltaW_A_B_old[k, n] = DeltaW_A_B;



                }

            }




            
            // Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            //  Console.WriteLine("Факториал числа {0} равен {1}", x, result);

        }
        double ErrorB;
        double DeltaW_B_C;
        double ErrorCSumm;
        double[] ErrorBMassiv;
        double ErrorA;
        private void train()
        {

            //обучаем по части магазинов
          //  double ErrorB1Shops = TrueZnachShops - outB1Shops;
             ErrorCSumm = TrueZnachSumm - outCSumm;
            //     ErrorB1Shops = ErrorB1Shops * (1 / (1 + Math.Pow(2.71828, -B1Shops.res1))) * (1 - (1 / (1 + Math.Pow(2.71828, -B1Shops.res1))));
            ErrorCSumm = ErrorCSumm * outCSumm * (1 - outCSumm);

            /*  double ErrorA0 = (ErrorB1Shops * B1Shops.w0 + ErrorB2Summ * B2Summ.w0) * A0.res2 * (1 - A0.res2);
              double ErrorA1 = (ErrorB1Shops * B1Shops.w1 + ErrorB2Summ * B2Summ.w1) * A1.res2 * (1 - A1.res2);
              double ErrorA2 = (ErrorB1Shops * B1Shops.w2 + ErrorB2Summ * B2Summ.w2) * A2.res2 * (1 - A2.res2);
              double ErrorA3 = (ErrorB1Shops * B1Shops.w3 + ErrorB2Summ * B2Summ.w3) * A3.res2 * (1 - A3.res2);
              double ErrorA4 = (ErrorB1Shops * B1Shops.w4 + ErrorB2Summ * B2Summ.w4) * A4.res2 * (1 - A4.res2);
              double ErrorA5 = (ErrorB1Shops * B1Shops.w5 + ErrorB2Summ * B2Summ.w5) * A5.res2 * (1 - A5.res2);
              double ErrorA6 = (ErrorB1Shops * B1Shops.w6 + ErrorB2Summ * B2Summ.w6) * A6.res2 * (1 - A6.res2);
              double ErrorA7 = (ErrorB1Shops * B1Shops.w7 + ErrorB2Summ * B2Summ.w7) * A7.res2 * (1 - A7.res2);
              */
            /*   double ErrorA0 = ( ErrorB2Summ * B2Summ.w0) * A0.res2 * (1 - A0.res2);
               double ErrorA1 = ( ErrorB2Summ * B2Summ.w1) * A1.res2 * (1 - A1.res2);
               double ErrorA2 = ( ErrorB2Summ * B2Summ.w2) * A2.res2 * (1 - A2.res2);
               double ErrorA3 = ( ErrorB2Summ * B2Summ.w3) * A3.res2 * (1 - A3.res2);
               double ErrorA4 = ( ErrorB2Summ * B2Summ.w4) * A4.res2 * (1 - A4.res2);
               double ErrorA5 = ( ErrorB2Summ * B2Summ.w5) * A5.res2 * (1 - A5.res2);
               double ErrorA6 = ( ErrorB2Summ * B2Summ.w6) * A6.res2 * (1 - A6.res2);
               double ErrorA7 = ( ErrorB2Summ * B2Summ.w7) * A7.res2 * (1 - A7.res2);
               */

            
             ErrorBMassiv=new double[CountB];
            
            
            Parallel.For(1, CountProc+1, TrainB);
            /*for (int k = 0; k <= 199; k++)
            {
         


                ErrorB = (ErrorCSumm * C_Summ.w_massiv[k]) * B_Massiv[k].res2 * (1 - B_Massiv[k].res2);
                ErrorBMassiv[k] = ErrorB;
                DeltaW_B_C = C_Summ.x_massiv[k] * ErrorCSumm * koefizient;
                C_Summ.w_massiv[k] = C_Summ.w_massiv[k] + DeltaW_B_C;
                //  if (ErrorA != 0)


                for (int n = 0; n <= 1999; n++)
                {
                    double DeltaW_A_B = B_Massiv[k].x_massiv[n] * ErrorB * koefizient;
                    B_Massiv[k].w_massiv[n] = B_Massiv[k].w_massiv[n] + DeltaW_A_B;



                }

                
            }*/
            Parallel.For(1, CountProc + 1, TrainA);
           

        }
        double[,] DeltaW_A_old = new double[16, CountA];
        void TrainA(int x)
        {


            for (int k = (x - 1) * (CountA / CountProc); k <= x * ((CountA / CountProc)) - 1; k++)
            {
                double ErrorA = 0;
                for (int m = 0; m <= CountB - 1; m++)
                {
                    ErrorA = ErrorA + ErrorBMassiv[m] * B_Massiv[m].w_massiv[k];

                }

                ErrorA = ErrorA * A_Massiv[k].res2 * (1 - A_Massiv[k].res2);


                //************
                double DeltaW_0_A = x0 * ErrorA * koefizient;
                double DeltaW_1_A = x1 * ErrorA * koefizient;
                double DeltaW_2_A = x2 * ErrorA * koefizient;
                double DeltaW_3_A = x3 * ErrorA * koefizient;
                double DeltaW_4_A = x4 * ErrorA * koefizient;
                double DeltaW_5_A = x5 * ErrorA * koefizient;
                double DeltaW_6_A = x6 * ErrorA * koefizient;
                double DeltaW_7_A = x7 * ErrorA * koefizient;
                double DeltaW_8_A = x8 * ErrorA * koefizient;
                double DeltaW_9_A = x9 * ErrorA * koefizient;
                double DeltaW_10_A = x10 * ErrorA * koefizient;
                double DeltaW_11_A = x11 * ErrorA * koefizient;
                double DeltaW_12_A = x12 * ErrorA * koefizient;
                double DeltaW_13_A = x13 * ErrorA * koefizient;
                double DeltaW_14_A = x14 * ErrorA * koefizient;
                double DeltaW_15_A = x15 * ErrorA * koefizient;




                A_Massiv[k].w0 = A_Massiv[k].w0 + DeltaW_0_A - mu * DeltaW_A_B_old[0, k];
                A_Massiv[k].w1 = A_Massiv[k].w1 + DeltaW_1_A - mu * DeltaW_A_B_old[1, k];
                A_Massiv[k].w2 = A_Massiv[k].w2 + DeltaW_2_A - mu * DeltaW_A_B_old[2, k];
                A_Massiv[k].w3 = A_Massiv[k].w3 + DeltaW_3_A - mu * DeltaW_A_B_old[3, k];
                A_Massiv[k].w4 = A_Massiv[k].w4 + DeltaW_4_A - mu * DeltaW_A_B_old[4, k];
                A_Massiv[k].w5 = A_Massiv[k].w5 + DeltaW_5_A - mu * DeltaW_A_B_old[5, k];
                A_Massiv[k].w6 = A_Massiv[k].w6 + DeltaW_6_A - mu * DeltaW_A_B_old[6, k];
                A_Massiv[k].w7 = A_Massiv[k].w7 + DeltaW_7_A - mu * DeltaW_A_B_old[7, k];
                A_Massiv[k].w8 = A_Massiv[k].w8 + DeltaW_8_A - mu * DeltaW_A_B_old[8, k];
                A_Massiv[k].w9 = A_Massiv[k].w9 + DeltaW_9_A - mu * DeltaW_A_B_old[9, k];
                A_Massiv[k].w10 = A_Massiv[k].w10 + DeltaW_10_A - mu * DeltaW_A_B_old[10, k];
                A_Massiv[k].w11 = A_Massiv[k].w11 + DeltaW_11_A - mu * DeltaW_A_B_old[11, k];
                A_Massiv[k].w12 = A_Massiv[k].w12 + DeltaW_12_A - mu * DeltaW_A_B_old[12, k];
                A_Massiv[k].w13 = A_Massiv[k].w13 + DeltaW_13_A - mu * DeltaW_A_B_old[13, k];
                A_Massiv[k].w14 = A_Massiv[k].w14 + DeltaW_14_A - mu * DeltaW_A_B_old[14, k];
                A_Massiv[k].w15 = A_Massiv[k].w15 + DeltaW_15_A - mu * DeltaW_A_B_old[15, k];

                DeltaW_A_B_old[0, k] = DeltaW_0_A;
                DeltaW_A_B_old[1, k] = DeltaW_1_A;
                DeltaW_A_B_old[2, k] = DeltaW_2_A;
                DeltaW_A_B_old[3, k] = DeltaW_3_A;
                DeltaW_A_B_old[4, k] = DeltaW_4_A;
                DeltaW_A_B_old[5, k] = DeltaW_5_A;
                DeltaW_A_B_old[6, k] = DeltaW_6_A;
                DeltaW_A_B_old[7, k] = DeltaW_7_A;
                DeltaW_A_B_old[8, k] = DeltaW_8_A;
                DeltaW_A_B_old[9, k] = DeltaW_9_A;
                DeltaW_A_B_old[10, k] = DeltaW_10_A;
                DeltaW_A_B_old[11, k] = DeltaW_11_A;
                DeltaW_A_B_old[12, k] = DeltaW_12_A;
                DeltaW_A_B_old[13, k] = DeltaW_13_A;
                DeltaW_A_B_old[14, k] = DeltaW_14_A;
                DeltaW_A_B_old[15, k] = DeltaW_15_A;

            }


           

            
            // Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            //  Console.WriteLine("Факториал числа {0} равен {1}", x, result);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            for (int k = 0; k < 10000; k++)
            {
                double Error=0;
                for (int i = 0; i < 8; i++)
                {
                    string str = Convert.ToString(i, 2);

                    if (str.Length == 2)
                    {
                        str = "0" + str;

                    }
                    if (str.Length == 1)
                    {
                        str = "00" + str;

                    }



                    x0 = Convert.ToInt16(str.Substring(0, 1));
                    x1 = Convert.ToInt16(str.Substring(1, 1));
                    x2 = Convert.ToInt16(str.Substring(2, 1));

                    if (i == 0) { TrueZnach = 1; };
                    if (i == 1) { TrueZnach = 0; };
                    if (i == 2) { TrueZnach = 1; };
                    if (i == 3) { TrueZnach = 0; };
                    if (i == 4) { TrueZnach = 1; };
                    if (i == 5) { TrueZnach = 0; };
                    if (i == 6) { TrueZnach = 1; };
                    if (i == 7) { TrueZnach = 0; };


                    RenewAll();

                     Error =Error+ (TrueZnach - outB1Shops)* (TrueZnach - outB1Shops);


                    if ( ( (i != 4)&(i!= 5) & (i != 6) & (i != 7)))
                    {

                        train();
                    }

               //     Thread.Sleep(1);
                }
                Error = Error / 8;
                Console.WriteLine("error "+Error);
            }
            */






            //  Query();

            for (int m = 0; m < 100000; m++)
            {
                if (m <20)
                { koefizient = 0.4; }
                else {
                    try
                    {
                        koefizient = Convert.ToDouble(textBox1.Text);
                    }
                    catch { };

                };
                try
                {
                    double ErrorAll = 0;

                    // dtMassiv_Temp = dtMassiv;
                    //   SummaMassiv_Temp = SummaMassiv;
                    //  ShopIDMassiv_Temp = ShopIDMassiv;

                    for (int k = 11; k <= 19; k++)
                    {
                        double Error = 0;
                        for (int i = 0; i < 366; i++)
                        {



                            string DataStr = "";
                            if (k < 10)
                            {
                                DataStr = "200" + k;
                            }
                            else
                            {
                                DataStr = "20" + k;

                            };


                            int Day = (k - 11) * 365 + i;

                            string DayStr=Convert.ToString(Day, 2);
                            int h = (16 - DayStr.Length);
                            for (int d = 0; d < h; d++)
                            {
                                DayStr = "0" + DayStr;

                            }



                            
                            //x0 = (Convert.ToInt16(DataStr) - 2010) / 15.0; /// запихиваем гол от 0 до 1
                            x15 = GetIn(Convert.ToInt16(DayStr.Substring(0, 1)));
                            x14 = GetIn( Convert.ToInt16(DayStr.Substring(1, 1)));
                            x13 = GetIn( Convert.ToInt16(DayStr.Substring(2, 1)));
                            x12 = GetIn(Convert.ToInt16(DayStr.Substring(3, 1)));
                            x11 = GetIn(Convert.ToInt16(DayStr.Substring(4, 1)));
                            x10 = GetIn(Convert.ToInt16(DayStr.Substring(5, 1)));
                            x9 = GetIn(Convert.ToInt16(DayStr.Substring(6, 1)));
                            x8 = GetIn(Convert.ToInt16(DayStr.Substring(7, 1)));
                            x7 = GetIn(Convert.ToInt16(DayStr.Substring(8, 1)));
                            x6 = GetIn(Convert.ToInt16(DayStr.Substring(9, 1)));
                            x5 = GetIn(Convert.ToInt16(DayStr.Substring(10, 1)));
                            x4 = GetIn(Convert.ToInt16(DayStr.Substring(11, 1)));
                            x3 = GetIn(Convert.ToInt16(DayStr.Substring(12, 1)));
                            x2 = GetIn(Convert.ToInt16(DayStr.Substring(13, 1)));
                            x1 = GetIn(Convert.ToInt16(DayStr.Substring(14, 1)));
                            x0 = GetIn(Convert.ToInt16(DayStr.Substring(15, 1)));









                            double summaPokupki = 0;
                          //  double ShopPokupki = 0;
                            DateTime date = new DateTime(Convert.ToInt16(DataStr), 1, 1);
                            DataStr = date.AddDays(i).ToString("d");



                            for (int n = 0; n < dtMassiv.Count; n++)
                            {
                                string DataStrInQuery = dtMassiv[n].ToString().Substring(0, 10);
                                if (DataStr == DataStrInQuery)
                                {

                                    summaPokupki = Convert.ToDouble(SummaMassiv[n]);
                                   // ShopPokupki = ShopIDMassiv[n];

                                    //    dtMassiv_Temp.RemoveAt(n);
                                    //    SummaMassiv_Temp.RemoveAt(n);
                                    //    ShopIDMassiv_Temp.RemoveAt(n);

                                    break;
                                };

                            };

                           // TrueZnachShops = ShopPokupki / 120;
                          //  TrueZnachShops = 0;
                            TrueZnachSumm = summaPokupki / 10000.0;
                            RenewAll();
                            
                            //Error = Error + ((TrueZnachShops - outB1Shops) * (TrueZnachShops - outB1Shops)) + ((TrueZnachSumm - outB2Summ) * (TrueZnachSumm - outB2Summ));
                            Error = Error + ((TrueZnachSumm - outCSumm) * (TrueZnachSumm - outCSumm));
                            train();

                        }
                        Error = Error / 365;
                        ErrorAll = ErrorAll + Error;

                    }
                    if (Convert.ToInt16(m / 50.0) == m / 50.0)
                    {
                   //     Invoke((MethodInvoker)delegate
                     //   {
                            button1_Click(null, null);
                            Application.DoEvents();
                    //    });
                    }

                    Console.WriteLine("error " + ErrorAll + " " + koefizient + " " + m);
                    label2.Text = "error " + ErrorAll + " " + koefizient + " " + m;
                    Application.DoEvents();
                }
                catch { };
            }
                
        
            
        }
        public double GetIn(double input)
        {
            double o=0.1;
            if (input == 1.0)
            {
                o = 1;
            }
            else {
                o = 0.001;
            }


            return o;
        }


        class DBUtils
        {
            public static SqlConnection GetDBConnection()
            {
                string datasource = @"10.57.0.11";

                string database = "Discounts";
                string username = "sa";
                string password = "cW0Az4c5";

                return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
            }
        }
        class DBSQLServerUtils
        {

            public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
            {
                //
                // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
                //
                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                            + database + ";Persist Security Info=True;User ID=" + "sa" + ";Password=" + "cW0Az4c5";

                SqlConnection conn = new SqlConnection(connString);

                return conn;
            }


        }
     //   List<string> dtMassiv_Temp = new List<string>();
    //    List<decimal> SummaMassiv_Temp = new List<decimal>();
     //   List<int> ShopIDMassiv_Temp = new List<int>();

        List<string> dtMassiv = new List<string>();
        List<decimal> SummaMassiv = new List<decimal>();
        List<int> ShopIDMassiv = new List<int>();

        private string Query()
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
           // DateTime[] dtMassiv;
           // DateTime[] SummaMassiv;
            //DateTime[] ShopIDMassiv;
            dtMassiv=new List<string>();
           SummaMassiv= new List<decimal>();
            ShopIDMassiv= new List<int>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CONVERT(VARCHAR(10),DocDate,104),sum(Amount),(SELECT top 1 (SELECT  code FROM ref_shops as b where b.ID= a.ShopID) shopid From doc_sales as a where CardID=(SELECT [id]FROM [Discounts].[dbo].[Reg_Cards] as a where pin='370123027')and CONVERT(VARCHAR(10),DocDate,104)= CONVERT(VARCHAR(10),c.DocDate,104)) From doc_sales as c where CardID=(SELECT [id]FROM [Discounts].[dbo].[Reg_Cards] as a where pin='370123027') group by  CONVERT(VARCHAR(10),DocDate,104)", conn);


                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {                        
                        while (reader.Read())
                        {
                            string datetime = reader.GetString(0);
                            dtMassiv.Add(datetime);
                            decimal summa = reader.GetDecimal(1);
                            SummaMassiv.Add(summa);
                            int shopid= reader.GetInt16(2);
                            ShopIDMassiv.Add(shopid);

                         //   return "";
                         //     break;
                        }


                    }
                    else
                    {
                     //   textBox1.Clear();
                    }
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Р-Р°РєС_С<С'С_ С_Р_РчР_РёР_РчР_РёРч.
                conn.Close();
                // Р Р°Р·С_С_С_РёС'С_ Р_Р+С_РчРєС', Р_С_Р_Р_Р+Р_Р_РёС'С_ С_РчС_С_С_С_.
                conn.Dispose();
            }





            return "";
        }

    }
}

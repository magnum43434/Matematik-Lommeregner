using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Matematik_Lommeregner
{
    class Program
    {
        [MTAThread]
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Matematik lommeregner\n");
            Console.WriteLine("1: Lineær funktion");
            Console.WriteLine("2: Eksponentielle funktion");
            Console.WriteLine("3: Potens funktion");
            Console.WriteLine("4: Procent Regning");
            Console.WriteLine("5: Kapitalfremskrivning");
            Console.WriteLine("6: Pythagoras");
            Console.WriteLine("7: Trigonometri");
            double Valg = double.Parse(Console.ReadLine());

            switch (Valg)
            {
                case 1:
                    LineærFunktion();
                    break;
                case 2:
                    EksponentielleFunktion();
                    break;
                case 3:
                    PotensFunktion();
                    break;
                case 4:
                    ProcentRegning();
                    break;
                case 5:
                    Kapitalfremskrivning();
                    break;
                case 6:
                    Pythagoras();
                    break;
                case 7:
                    Trigonometri();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
        }

        private static void LineærFunktion()
        {
            Console.Clear();
            Console.WriteLine("1: Delta X eller Delta Y");
            Console.WriteLine("2: Find a");
            Console.WriteLine("3: Find b");
            Console.WriteLine("4: Funktion ud fra 2 punkter");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.WriteLine("X eller Y");
                    string Valg1 = Console.ReadLine().ToUpper();
                    if (Valg1 == "X")
                    {
                       Console.WriteLine("Input X1");
                       double X1 = double.Parse(Console.ReadLine());
                       Console.WriteLine("Input X2");
                       double X2 = double.Parse(Console.ReadLine());
                        double DeltaX = (X2) - (X1);
                        Console.WriteLine("Delta X er:" + DeltaX);
                        Console.ReadLine();
                        LineærFunktion();
                    }

                    else if (Valg1 == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine("Input Y1");
                        double Y1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input Y2");
                        double Y2 = double.Parse(Console.ReadLine());
                        double DeltaY = (Y2) - (Y1);
                        Console.Clear();
                        Console.WriteLine("Delta Y er:" + DeltaY);
                        Console.ReadLine();
                        LineærFunktion();
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double XX1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double XX2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double YY1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double YY2 = double.Parse(Console.ReadLine());
                    double deltax = (XX2) - (XX1);
                    double deltay = (YY2) - (YY1);
                    if (deltax == 0 || deltay == 0)
                    {
                        double resultata = 0;
                        Console.Clear();
                        Console.WriteLine(resultata);
                        Console.ReadLine();
                        LineærFunktion();
                    }
                    else
                    {
                        double resultata = deltay / deltax;
                        Console.Clear();
                        Console.WriteLine(resultata);
                        Console.ReadLine();
                        LineærFunktion();
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Kender du a? (ja/nej)");
                    string Valg2 = Console.ReadLine().ToLower();
                    if (Valg2 == "ja")
                    {
                        Console.Clear();
                        Console.WriteLine("Input X1");
                        double XXX1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input Y1");
                        double YYY1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input a");
                        double a = double.Parse(Console.ReadLine());
                        double resultatb = (YYY1) - (a) * (XXX1);
                        Console.Clear();
                        Console.WriteLine(resultatb);
                        Console.ReadLine();
                        LineærFunktion();
                    }
                    else if (Valg2 == "nej")
                    {
                        Console.Clear();
                        Console.WriteLine("Input X1");
                        double XXX1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input X2");
                        double XXX2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input Y1");
                        double YYY1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input Y2");
                        double YYY2 = double.Parse(Console.ReadLine());
                        double deltax1 = (XXX2) - (XXX1);
                        double deltay1 = (YYY2) - (YYY1);
                        if (deltay1 == 0 || deltax1 == 0)
                        {
                            double a = 0;
                            double resultatb = (YYY1) - (a) * (XXX1);
                            Console.Clear();
                            Console.WriteLine(resultatb);
                            Console.ReadLine();
                            LineærFunktion();
                        }
                        else
                        {
                            double a = deltay1 / deltax1;
                            double resultatb = (YYY1) - (a) * (XXX1);
                            Console.Clear();
                            Console.WriteLine(resultatb);
                            Console.ReadLine();
                            LineærFunktion();
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double XXXX1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double XXXX2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double YYYY1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double YYYY2 = double.Parse(Console.ReadLine());
                    double deltaxx1 = (XXXX2) - (XXXX1);
                    double deltayy1 = (YYYY2) - (YYYY1);
                    if (deltaxx1 == 0 || deltayy1 == 0)
                    {
                        double a1 = 0;
                        double b = (YYYY1) - (a1) * (XXXX1);
                        Console.Clear();
                        string funktion = "f(x)=" + a1 + "x+" + b;
                        Console.WriteLine(funktion);
                        Console.WriteLine("Ønsker du at Kopiere funktionen? (ja/nej");
                        string ja = Console.ReadLine();
                        if (ja == "ja")
                        {
                            Clipboard.SetDataObject(funktion);
                            Console.ReadLine();
                            LineærFunktion();
                        }
                        else if (ja == "nej")
                        {
                            Console.ReadLine();
                            LineærFunktion();
                        }
                        else
                        {
                            Console.ReadLine();
                            LineærFunktion();
                        }
                    }
                    else
                    {
                        double a1 = deltayy1 / deltaxx1;
                        double b = (YYYY1) - (a1) * (XXXX1);
                        Console.Clear();
                        string funktion = "f(x)=" + a1 + "x+" + b;
                        Console.WriteLine(funktion);
                        Console.WriteLine("Ønsker du at Kopiere funktionen? (ja/nej");
                        string nej = Console.ReadLine();
                        if (nej == "ja")
                        {
                            Clipboard.SetDataObject(funktion);
                            Console.ReadLine();
                            LineærFunktion();
                        }
                        else if (nej == "nej")
                        {

                            Console.ReadLine();
                            LineærFunktion();
                        }
                        else
                        {
                            Console.ReadLine();
                            LineærFunktion();
                        }
                    }
                    break;
                case 0:
                    Main();
                    break;
                default:
                    Console.Clear();
                    LineærFunktion();
                    break;
            }
        }
        private static void ProcentRegning()
        {
            Console.Clear();
            Console.WriteLine("1: Find Slutnings værdien");
            Console.WriteLine("2: Find Begyndelses værdien");
            Console.WriteLine("3: Find Fremskringnings faktor");
            Console.WriteLine("4: FInd Vækstrate");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1: Læg til");
                    Console.WriteLine("2: Træk fra");
                    double Valg1 = double.Parse(Console.ReadLine());
                    if (Valg1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Input Begyndelses værdien");
                        double B = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Input procent");
                        double rf = double.Parse(Console.ReadLine());
                        double r = rf / 100;
                        double S = B * (1 + r);
                        Console.Clear();
                        Console.WriteLine(S);
                        Console.ReadLine();
                        ProcentRegning();
                    }
                    else if (Valg1 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Input Begyndelses værdien");
                        double B = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Input procent");
                        double rf = double.Parse(Console.ReadLine());
                        double r = rf / 100;
                        double S = B * (1 - r);
                        Console.Clear();
                        Console.WriteLine(S);
                        Console.ReadLine();
                        ProcentRegning();
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("1: Steget");
                    Console.WriteLine("2: Faldet");
                    double Valg2 = double.Parse(Console.ReadLine());
                    if (Valg2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Input Slutnings værdien");
                        double S2 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Input procent");
                        double rf2 = double.Parse(Console.ReadLine());
                        double r2 = rf2 / 100;
                        double B2 = S2 / (1 + r2);
                        Console.Clear();
                        Console.WriteLine(B2);
                        Console.ReadLine();
                        ProcentRegning();
                    }
                    else if (Valg2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Input Slutnings værdien");
                        double S2 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Input procent");
                        double rf2 = double.Parse(Console.ReadLine());
                        double r2 = rf2 / 100;
                        double B2 = S2 / (1 - r2);
                        Console.Clear();
                        Console.WriteLine(B2);
                        Console.ReadLine();
                        ProcentRegning();
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Input Slutnings værdien");
                    double S3 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Begyndelses værdien");
                    double B3 = double.Parse(Console.ReadLine());
                    double r3 = S3 / B3;
                    Console.Clear();
                    Console.WriteLine(r3);
                    Console.ReadLine();
                    ProcentRegning();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Input Slutnings værdien");
                    double S4 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Begyndelses værdien");
                    double B4 = double.Parse(Console.ReadLine());
                    double r4 = S4 / B4 - 1;
                    double rf4 = r4 * 100;
                    Console.Clear();
                    Console.WriteLine(rf4);
                    Console.ReadLine();
                    ProcentRegning();
                    break;
                case 0:
                    Main();
                    break;
                default:
                    Console.Clear();
                    ProcentRegning();
                    break;
            }
        }
        private static void Kapitalfremskrivning()
        {
            Console.Clear();
            Console.WriteLine("1: Find Slutkapitalen");
            Console.WriteLine("2: Find Startkapitalen");
            Console.WriteLine("3: Find Renten");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input Startkapitalen");
                    double K = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input antal terminer");
                    double n = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input procent");
                    double rf = double.Parse(Console.ReadLine());
                    double r = rf / 100;
                    double Kn = K * Math.Pow(1 + r, n);
                    Console.Clear();
                    Console.WriteLine(Kn);
                    Console.ReadLine();
                    Kapitalfremskrivning();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Input Slutkapitalen");
                    double Kn2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input antal terminer");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input procent");
                    double rf2 = double.Parse(Console.ReadLine());
                    double r2 = rf2 / 100;
                    double K2 = Kn2 / Math.Pow(1 + r2, n2);
                    Console.Clear();
                    Console.WriteLine(K2);
                    Console.ReadLine();
                    Kapitalfremskrivning();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Input Startkapitalen");
                    double K3 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Slutkapitalen");
                    double Kn3 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input antal terminer");
                    double n3 = double.Parse(Console.ReadLine());
                    double nf = 1/n3;
                    double Knf = K3 / Kn3;
                    double rf3 = Math.Pow(Knf,nf) - 1;
                    double r3 = rf3 * 100;
                    Console.Clear();
                    Console.WriteLine(r3);
                    Console.ReadLine();
                    Kapitalfremskrivning();
                    break;
                case 0:
                    Main();
                    break;
                default:
                    Console.Clear();
                    Kapitalfremskrivning();
                    break;
            }
        }
        private static void Pythagoras()
        {
            Console.Clear();
            Console.WriteLine("1: Find a");
            Console.WriteLine("2: Find b");
            Console.WriteLine("3: Find c");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input b");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input c");
                    double c1 = double.Parse(Console.ReadLine());
                    double a1 = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(b1, 2));
                    Console.Clear();
                    Console.WriteLine(a1);
                    Console.ReadLine();
                    Pythagoras();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Input a");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input c");
                    double c2 = double.Parse(Console.ReadLine());
                    double b2 = Math.Sqrt(Math.Pow(c2, 2) + Math.Pow(a2, 2));
                    Console.Clear();
                    Console.WriteLine(b2);
                    Console.ReadLine();
                    Pythagoras();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Input a");
                    double a3= double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input b");
                    double b3 = double.Parse(Console.ReadLine());
                    double c3 = Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(b3, 2));
                    Console.Clear();
                    Console.WriteLine(c3);
                    Console.ReadLine();
                    Pythagoras();
                    break;
                case 0:
                    Main();
                    break;
                default:
                    Console.Clear();
                    Pythagoras();
                    break;
            }
        }
        private static void Trigonometri()
        {
            Console.Clear();
            Console.WriteLine("Hvad er kendt?\n");
            Console.WriteLine("1: Siden a og c");
            Console.WriteLine("2: Siden a og b");
            Console.WriteLine("3: Siden b og c");
            Console.WriteLine("4: Vinkel A og siden a");
            Console.WriteLine("5: Vinkel A og siden b");
            Console.WriteLine("6: Vinkel A og siden c");
            Console.WriteLine("7: Vinkel B og siden a");
            Console.WriteLine("8: Vinkel B og siden b");
            Console.WriteLine("9: Vinkel B og siden c");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden c");
                    double c1 = double.Parse(Console.ReadLine());
                    double b1 = Math.Sqrt(Math.Pow(c1, 2) - Math.Pow(a1, 2));
                    double A1 = Math.Asin(a1 / c1) * (180 / Math.PI);
                    double B1 = Math.Acos(a1 / c1) * (180 / Math.PI);
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(b1);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A1);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(B1);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden c");
                    double b2 = double.Parse(Console.ReadLine());
                    double c2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2));
                    double A2 = Math.Atan(a2 / b2) * (180 / Math.PI);
                    double B2 = Math.Atan(b2 / a2) * (180 / Math.PI);
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden c:");
                    Console.WriteLine(c2);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A2);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(B2);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Input Siden b");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden c");
                    double c3 = double.Parse(Console.ReadLine());
                    double a3 = Math.Sqrt(Math.Pow(c3, 2) - Math.Pow(b3, 2));
                    double A3 = Math.Acos(b3 / c3) * (180 / Math.PI);
                    double B3 = Math.Asin(b3 / c3) * (180 / Math.PI);
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden a:");
                    Console.WriteLine(a3);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A3);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(B3);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel A");
                    double A4 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double a4 = double.Parse(Console.ReadLine());
                    double c4 = a4 / Math.Sin(A4) * (180 / Math.PI);
                    double b4 = a4 / Math.Tan(A4) * (180 / Math.PI);
                    double B4 = 90 - A4;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden c:");
                    Console.WriteLine(c4);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(b4);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(b4);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel A");
                    double A5 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden b");
                    double b5 = double.Parse(Console.ReadLine());
                    double c5 = b5 / Math.Cos(A5) * (180 / Math.PI);
                    double a5 = b5 * Math.Tan(A5) * (180 / Math.PI);
                    double B5 = 90 - A5;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(c5);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(a5);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(A5);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel A");
                    double A6 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden c");
                    double c6 = double.Parse(Console.ReadLine());
                    double a6 = c6 * Math.Sin(A6) * (180 / Math.PI);
                    double b6 = c6 * Math.Cos(A6) * (180 / Math.PI);
                    double B6 = 90 - A6;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden a:");
                    Console.WriteLine(a6);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(b6);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel B:");
                    Console.WriteLine(B6);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel B");
                    double B7 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double a7 = double.Parse(Console.ReadLine());
                    double c7 = a7 / Math.Cos(B7) * (180 / Math.PI);
                    double b7 = a7 * Math.Tan(B7) * (180 / Math.PI);
                    double A7 = 90 - B7;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden c:");
                    Console.WriteLine(c7);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(b7);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A7);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel B");
                    double B8 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double b8 = double.Parse(Console.ReadLine());
                    double c8 = b8 / Math.Sin(B8) * (180 / Math.PI);
                    double a8 = b8 / Math.Tan(B8) * (180 / Math.PI);
                    double A8 = 90 - B8;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden c:");
                    Console.WriteLine(c8);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for siden a:");
                    Console.WriteLine(a8);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A8);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Input Vinkel A");
                    double B9 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Input Siden a");
                    double c9 = double.Parse(Console.ReadLine());
                    double a9 = c9 * Math.Cos(B9) * (180 / Math.PI);
                    double b9 = c9 * Math.Sin(B9) * (180 / Math.PI);
                    double A9 = 90 - B9;
                    Console.Clear();
                    Console.WriteLine("Her er værdien for siden a:");
                    Console.WriteLine(a9);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for siden b:");
                    Console.WriteLine(b9);
                    Console.WriteLine("");
                    Console.WriteLine("Her er værdien for Vinkel A:");
                    Console.WriteLine(A9);
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    Trigonometri();
                    break;
                case 0:
                    Main();
                    break;
                default:
                    Console.Clear();
                    Trigonometri();
                    break;
            }
        }
        private static void PotensFunktion()
        {
            Console.Clear();
            Console.WriteLine("1: Find a");
            Console.WriteLine("2: Find b");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double X1_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double X2_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double Y1_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double Y2_1 = double.Parse(Console.ReadLine());
                    double a1 = Math.Log(Y2_1 / Y1_1) / Math.Log(X2_1 / X1_1);
                    Console.Clear();
                    Console.WriteLine(a1);
                    Console.ReadLine();
                    PotensFunktion();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double X1_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double X2_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double Y1_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double Y2_2 = double.Parse(Console.ReadLine());
                    double a2 = Math.Log(Y2_2 / Y1_2) / Math.Log(X2_2 / X1_2);
                    double b = Y1_2 / Math.Pow(X1_2, a2);
                    Console.Clear();
                    Console.WriteLine(b);
                    Console.ReadLine();
                    PotensFunktion();
                    break;
            }
        }
        private static void EksponentielleFunktion()
        {
            Console.Clear();
            Console.WriteLine("1: Find a");
            Console.WriteLine("2: Find b");
            double Valg = double.Parse(Console.ReadLine());
            switch (Valg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double X1_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double X2_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double Y1_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double Y2_1 = double.Parse(Console.ReadLine());
                    //double a1 = Math.Sqrt((Y2_1 / Y1_1),X2_1 - X1_1);
                    Console.Clear();
                    Console.WriteLine();
                    Console.ReadLine();
                    PotensFunktion();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Input X1");
                    double X1_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input X2");
                    double X2_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y1");
                    double Y1_2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input Y2");
                    double Y2_2 = double.Parse(Console.ReadLine());
                    double a2 = Math.Log(Y2_2 / Y1_2) / Math.Log(X2_2 / X1_2);
                    double b = Y1_2 / Math.Pow(X1_2, a2);
                    Console.Clear();
                    Console.WriteLine(b);
                    Console.ReadLine();
                    PotensFunktion();
                    break;
            }
        } //Kan ikke laves færdig endnu begrund af mere undersøgelse iforhold til Math.Sqrt.
    }
}

using System;

namespace TareaJess
{
    class Program
    {
        static void Main(string[] args)// punto de entrada 
        {
        
            ShowInstructions();
            UserSelection();
            ShowEnd();
        }
        private static void UserSelection()
        {
            try
            {
                char respuesta = Convert.ToChar(Console.ReadLine());
                RunSelection(respuesta);
                ShowEnd();

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.InnerException);
            }
        }
        // Elegir si volver a ejecutar programa o cerrar
        private static void ShowEnd() 
        {
            System.Console.WriteLine("Quieres hacer una nueva operación? y/n ");
            var response = Console.ReadLine();
            if (response == "y") 
            {
                ShowInstructions();
                UserSelection();
            }
            else if (response == "n") 
            {
                System.Console.WriteLine("Hasta luego.");
            }
        }
        // Encargado de correr la lógica del programa seleccionado por el usuario
        private static void RunSelection(char response)
        {
            
            switch (response)
            {
                case '1':
                    Case1();
                    break;

                case '2':
                    Case2();
                    break;

                case '3':
                    Case3();

                    break;
                case '4':
                    Case4();
                    break;
                case '5':
                    Case5();
                    break;
                case '6':
                    Case6();
                    break;
                case '7':
                    Case7();
                    break;
                case '8':
                    Case8();
                    break;
                case '9':
                    Case9();
                    break;
                case 'A':
                    CaseA();
                    break;
                case 'B':
                    CaseB();
                    break;
                case 'C':
                    CaseC();
                    break;
                case 'D':
                    CaseD();
                    break;
                case 'E':
                    CaseE();
                    break;
                case 'F':
                    CaseF();
                    break;
                case 'G':
                    CaseG();
                    break;
                case 'H':
                    CaseH();
                    break;
                case 'I':
                    CaseI();
                    break;
                case 'J':
                    CaseJ();
                    break;
                case 'K':
                    CaseK();
                    break;
                case 'L':
                    CaseL();
                    break;
                case 'M':
                    CaseM();
                    break;
                case 'N':
                    CaseN();
                    break;
                case 'O':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado1 = Convert.ToDouble(System.Console.ReadLine());
                    double presion4 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb1 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'P':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb, Grados API");
                    double ViscosidaddelAceiteSaturado2 = Convert.ToDouble(System.Console.ReadLine());
                    double presion5 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb2 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI8 = Convert.ToDouble(System.Console.ReadLine());

                    break;
                case 'Q':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado3 = Convert.ToDouble(System.Console.ReadLine());
                    double presion6 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb3 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'R':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado4 = Convert.ToDouble(System.Console.ReadLine());
                    double presion7 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb4 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'S':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas8 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI9 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs12 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura11 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'T':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas9 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI10 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs13 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura12 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'U':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Densidad Relativa del Gas, Grados API, Rs, Temperatura, Densidad Relativa del Aceite, Viscosidad del Aceite Saturado");
                    double densidadrelativadelgas10 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI11 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs14 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura13 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelaceite1 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteSaturado5 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'V':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas11 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI13 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs15 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura14 = Convert.ToDouble(System.Console.ReadLine());
                    break;
            }
        }

        private static void CaseN()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
            double ViscosidaddelAceiteSaturado = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            double Pb = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteBajosturadoVazquez(ViscosidaddelAceiteSaturado, Presion, Pb);
        }

        private static void CaseM()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteSaturadoPetrosky(Rs, ViscosidaddelAceiteMuerto);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseL()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteSaturadoDeGuetto(Rs, ViscosidaddelAceiteMuerto);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseK()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteSaturadoGuetto(Rs, ViscosidaddelAceiteMuerto);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseJ()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteSaturadoKartoadmodjo(Rs, ViscosidaddelAceiteMuerto);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseI()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteSaturadoBeggs(Rs, ViscosidaddelAceiteMuerto);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseH()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteMuertoPetrosky(gradosAPI, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseG()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura, Rs");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteMuertoKartoadmodjo(gradosAPI, Presion, densidadrelativadelgas, Temperatura,Rs);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseF()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteMuertoGlaso(gradosAPI, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseE()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerViscosidaddelAceiteMuertoBeggs(gradosAPI, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseD()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura, Rs");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerCoVazquez(gradosAPI, Presion, densidadrelativadelgas, Temperatura, Rs);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseC()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Densidad Relativa del Aceite, Temperatura, Densidad Relativa del Gas");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerBoPetrosky(Rs, densidadrelativadelaceite, Temperatura, densidadrelativadelgas);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseB()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite, Rs");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerBoKartoadmodjo(gradosAPI, densidadrelativadelgas, Temperatura, densidadrelativadelaceite,Rs);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void CaseA()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite, Rs");
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerBoGlaso(densidadrelativadelgas, Temperatura, densidadrelativadelaceite, Rs);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case9()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Temperatura, Rs");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerBoVazquez(Rs, gradosAPI, densidadrelativadelgas, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case8()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite");
            double Rs = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerBoStanding(Rs, densidadrelativadelaceite, Temperatura, densidadrelativadelgas);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case7()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsPetrosky(gradosAPI, Presion, densidadrelativadelgas, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case6()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsKartoadmodjo(gradosAPI, densidadrelativadelgas);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case5()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsGlasovolatiles(gradosAPI, densidadrelativadelgas, Presion);
            System.Console.WriteLine($"Resultado {resultado}");
        }
        private static void Case4()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double Presion = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsGlasopesados(gradosAPI, densidadrelativadelgas,Presion);
            System.Console.WriteLine($"Resultado {resultado}");
        }
        private static void Case3()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Aceite, ");
            double gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsLasater(gradosAPI, densidadrelativadelaceite);
            System.Console.WriteLine($"Resultado {resultado}");
        }
        
        private static void Case2()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion, Temperatura");
            var gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            var densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var presion = Convert.ToDouble(System.Console.ReadLine());
            var Temperatura = Convert.ToDouble(System.Console.ReadLine());

            var resultado = ExtraerRsVazquez(gradosAPI, densidadrelativadelgas, presion, Temperatura);
            System.Console.WriteLine($"Resultado {resultado}");
        }

        private static void Case1()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del gas, grados API, Temperatura, Presion");

            var densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            var Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var Presion = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsStanding(densidadrelativadelgas, gradosAPI, Temperatura, Presion);
            System.Console.WriteLine($"Resultado {resultado}");

        }

        private static void ShowInstructions()
        {
            System.Console.WriteLine("Programa que calcula correlaciones PVT");
            System.Console.WriteLine("Elige la ecuacion a realizar");
            System.Console.WriteLine("1.- Rs Standing");
            System.Console.WriteLine("2.- Rs Vazquez y Beggs");
            System.Console.WriteLine("3.- Rs Lasater");
            System.Console.WriteLine("4.- Rs Glaso aceites pesados");
            System.Console.WriteLine("5.- Rs Glaso aceites volatiles");
            System.Console.WriteLine("6.- Rs Kartoadmodjo Schmidt");
            System.Console.WriteLine("7.- Rs Petrosky y Farshad");
            System.Console.WriteLine("8.- Bo Standing");
            System.Console.WriteLine("9.- Bo Vazquez y Beggs");
            System.Console.WriteLine("A.- Bo Glaso");
            System.Console.WriteLine("B.- Bo Kartoadmodjo");
            System.Console.WriteLine("C.- Bo Petrosky");
            System.Console.WriteLine("D.- Co Vazquez");
            System.Console.WriteLine("E.- Viscosidad del Aceite Muerto Beggs y Robinson");
            System.Console.WriteLine("F.- Viscosidad del Aceite Muerto Glaso");
            System.Console.WriteLine("G.- Viscosidad del Aceite Muerto Kartoadmodjo");
            System.Console.WriteLine("H.- Viscosidad del Aceite Muerto Petrosky");
            System.Console.WriteLine("I.- Viscosidad del Aceite Saturado Beggs y Robinson");
            System.Console.WriteLine("J.- Viscosidad del Aceite Saturado Kartoadmodjo");
            System.Console.WriteLine("K.- Viscosidad del Aceite Saturado De Guetto 10 < °API <= 33.1");
            System.Console.WriteLine("L.- Viscosidad del Aceite Saturado De Guetto °API > 31.1");
            System.Console.WriteLine("M.- Viscosidad del Aceite Saturado Petrosky");
            System.Console.WriteLine("N.- Viscosidad del Aceite Bajosaturado Vazquez y Beggs");
            System.Console.WriteLine("O.- Viscosidad del Aceite Bajosaturado Kartoadmodjo");
            System.Console.WriteLine("P.- Viscosidad del Aceite Bajosaturado De Guetto °API <= 10");
            System.Console.WriteLine("Q.- Viscosidad del Aceite Bajosaturado De Guetto °API > 10");
            System.Console.WriteLine("R.- Viscosidad del Aceite Bajosaturado Petrosky");
            System.Console.WriteLine("S.- Presion de Burbuja Standing");
            System.Console.WriteLine("T.- Presion de Burbuja Vazquez");
            System.Console.WriteLine("U.- Presion de Burbuja Lasater");
            System.Console.WriteLine("V.- Presion de Burbuja Glaso");
        }

        //Standing (1947)
        static double ExtraerRsStanding(double _densidadRelativaCondicionesEstandard, double _gradosAPI, double _gradosFarenheit, double _presion) 
        {
            var resultado = _densidadRelativaCondicionesEstandard * Math.Pow((Math.Pow(10, (0.0125 * _gradosAPI) - (0.00091 * _gradosFarenheit)) * ((_presion / 18.2) + 1.4)), 1.2048);
            return resultado;
        }
        //Vazquez y Beggs (1980 )
        static double ExtraerRsVazquez(double _gradosAPI, double _densidadrelativadelgas, double _p, double _gradosFarenheit)
        {
            double c1 =0,c2 =0, c3=0;
            if (_gradosAPI > 30)
            {
                c1 = 0.0178;
                c2 = 1.1870;
                c3 = 23.931;
            } 
            else if (_gradosAPI <= 30)
            {
                c1 = 0.0362;
                c2 = 1.0937;
                c3 = 25.724;
            }
            var  densidadrelativadelgas = (_densidadrelativadelgas*(1 + (Math.Pow (5.912 * 10,-5)*(_gradosAPI * _gradosFarenheit)*(Math.Log (_p + 14.7 /114.7)))));
            double resultado = c1 * densidadrelativadelgas * Math.Pow(_p, c2) * Math.Exp(c3 * _gradosAPI / _gradosFarenheit+ 460);
            return resultado;
        } 
        //Lasater (Rs)
        static double ExtraerRsLasater(double _gradosAPI, double _densidadrelativaaceite)
        {
            var parametroyg = ( (0.359*(Math.Log(((1.473 * 1920 * 0.85)/176 + 460)+0.476))));
            var parametroMo = ((630 - 10 *(_gradosAPI)));
            var resultado = (132.755*(_densidadrelativaaceite))/(280)*(1-0.5259);
            return resultado;
        }
        //Glaso (Rs)(1980 aceites pesados)
        static double ExtraerRsGlasopesados(double _gradosAPI, double _densidadrelativadelgas, double _p)
        {
            var a = 0.172;
            var resultado = _densidadrelativadelgas * (Math.Pow (Math.Pow(10, 2.8869 - (Math.Pow(14.1811 -3.3093* Math.Log(_p),0.5)))*(Math.Pow (_gradosAPI, 0.989)/Math.Pow(_densidadrelativadelgas, a)), 1.2255));
            return resultado; 
        }
        // Glaso (Rs aceites volatiles)
        static double ExtraerRsGlasovolatiles(double _gradosAPI, double _densidadrelativadelgas, double _p)
        {
            var a = 0.172;
            var resultado = _densidadrelativadelgas * (Math.Pow (Math.Pow(10, 2.8869 - (Math.Pow(14.1811 -3.3093* Math.Log(_p),0.5)))*(Math.Pow (_gradosAPI, 0.989)/Math.Pow(_densidadrelativadelgas, a)), 1.2255));
            return resultado; 
        }
        //Kartoatmodjo y Schmidt (Rs)(1994)
        static double ExtraerRsKartoadmodjo(double _gradosAPI, double _densidadrelativadelgas)
        {
            var c1 = 0.03150;
            var c2 = 0.7587;
            var c3 = 11.2895;
            var c4 = 0.9143;
            var resultado = _densidadrelativadelgas*(c1*(Math.Pow(_gradosAPI, c2)*(Math.Pow(1920, 1/c4)*(Math.Pow(10, c3*(_gradosAPI)/176 + 460)))));
            return resultado; 
        }
        //Petrosky y Farshad (Rs)(1993)
        static double ExtraerRsPetrosky(double _gradosAPI, double _p, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var x= 7.916 * Math.Pow(10, -4) * Math.Pow(_gradosAPI, 1.541) - 4.561 * Math.Pow(10, -5) * Math.Pow(_gradosFarenheit, 1.3911);
            var resultado = Math.Pow((_p / 112.727 + 12.34) * Math.Pow(_densidadrelativadelgas, 0.8439) * Math.Pow(10, x), 1.73184);
            return resultado;
        }
        //Standing (Bo)
        static double ExtraerBoStanding(double _Rs, double _densidadrelativadelgas, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 0.9759 + 0.00012 *(Math.Pow(_Rs*(Math.Pow(_densidadrelativadelgas/_densidadrelativadelgas, 0.5) + 1.25*(_gradosFarenheit)),1.2));
            return resultado;
        }
        //Vazquez y Beggs (Bo) (1980)
        static double ExtraerBoVazquez(double _Rs, double _gradosAPI, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var c1 = 0.0004677;
            var c2 = 0.000011;
            var c3 = 0.000000001337;
            var resultado = 1 + c1*(_Rs) + c2*(_gradosFarenheit-60)*(_gradosAPI/_densidadrelativadelgas) + c3*(_Rs)*(_gradosFarenheit-60)*(_gradosAPI/_densidadrelativadelgas);
            return resultado;
        }
        //Glaso (Bo)
        static double ExtraerBoGlaso(double _Rs, double _densidadrelativaaceite, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var Bob = _Rs *(Math.Pow(_densidadrelativaaceite / _densidadrelativadelgas, 0.526) + 0.968*(_gradosFarenheit));
            var resultado = 1 + (Math.Pow(10, -6.58511 + 2.91329 *(Math.Log(Bob) - 0.27683 *(Math.Pow(Math.Log(Bob), 2))))); 
            return resultado;
        }
        //Kartoadmodjo (Bo)
        static double ExtraerBoKartoadmodjo(double _gradosAPI, double _densidadrelativadelgas, double _Rs, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 0.98496 + 0.0001 *(Math.Pow(Math.Pow(_Rs, 0.755)* Math.Pow(_densidadrelativadelgas, 0.25)* Math.Pow(_densidadrelativaaceite, -1.5) + 0.45 * _gradosFarenheit, 1.5));
            return resultado;
        }
        //Pettrosky (Bo)
        static double ExtraerBoPetrosky(double _Rs, double _densidadrelativadelgas, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 1.0113 + 7.2046 *(Math.Pow(10, -5))* Math.Pow(Math.Pow(_Rs, 0.3738) * (Math.Pow(_densidadrelativadelgas, 0.2914)/Math.Pow(_densidadrelativaaceite, 0.6265))+ 0.24626 * Math.Pow(_densidadrelativaaceite, 0.5371), 3.0936);
            return resultado; 
        }
        //Vazquez (Co)
        static double ExtraerCoVazquez(double _Rs, double _densidadrelativadelgas, double _gradosAPI, double _gradosFarenheit, double _p)
        {
            var resultado = (-1433 + 5 * _Rs + 17.2 * _gradosFarenheit -  1180 * _densidadrelativadelgas +  12.61 * _gradosAPI) / _p * (Math.Pow(10, 5)); 
            return resultado;
        }
        //Beggs y Robinson (Viscosidad del Aceite muerto)
        static double ExtraerViscosidaddelAceiteMuertoBeggs(double _gradosAPI, double _gradosFarenheit)
        {
            var x = (Math.Pow(10, 3.0324 - 0.02023 * _gradosAPI))*(Math.Pow(_gradosFarenheit, -1.163));
            var resultado = (Math.Pow(10, x)) - 1; 
            return resultado; 
        }
        //Glaso (Viscosidad del Aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoGlaso(double _gradosFarenheit, double _gradosAPI)
        {
            var a = 10.313 * (Math.Log(_gradosFarenheit)) - 36.447; 
            var resultado = 3.141 * (Math.Pow(10, 10)) * (Math.Pow(_gradosFarenheit, -3.444))*(Math.Pow(Math.Log(_gradosAPI), a));
            return resultado;
        }
        //Kartoadmodjo (Viscosidad del aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoKartoadmodjo(double _gradosAPI, double _gradosFarenheit, double _Rs, double _densidadrelativadelgas, double _p)
        {
            var resultado = (6.8257 * Math.Pow(_Rs, 0.5002) * Math.Pow(_gradosAPI, 0.3613) * Math.Pow(_gradosFarenheit, 0.76606) * Math.Pow(_densidadrelativadelgas, 0.35505)) / _p * Math.Pow(10, 6);
            return resultado;
        }
        //Petroskky (Viscosidad del Aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoPetrosky(double _gradosAPI, double _gradosFarenheit)
        {
            var X = (4.59388)*(Math.Log(_gradosFarenheit)) - 22.82792;
            var resultado = 2.3511*(Math.Pow(10, 7))*(Math.Pow(_gradosFarenheit, -2.10255))*(Math.Pow(Math.Log(_gradosAPI),X));
            return resultado;
        }
        //Beggs y Robinson (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturadoBeggs(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var b = 5.44*(Math.Pow(_Rs + 150, -0.338));
            var resultado = (10.715*(Math.Pow(_Rs + 100, 0.515)))*(Math.Pow(_ViscosidaddelAceiteMuerto, b));
            return resultado; 
        }
        //Kartoadmosjo (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturadoKartoadmodjo(double _ViscosidaddelAceiteMuerto, double _Rs)
        {
            var B = 0.43 + 0.5165*(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2001 + 0.8428*(Math.Pow(10, -0.000845*_Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.06821 + 0.9824 * A + 0.0004034 *(Math.Pow(A, 2));
            return resultado; 
        }
        //De Guetto (Viscosidad del Aceite Saturado para 10 < °API <= 22.3)
        static double ExtraerViscosidaddelAceiteSaturadoGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.4731 + 0.5158 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2478 + 0.6114 *(Math.Pow(10, -0.000845 * _Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.6311 + 1.078 * A - 0.003653 * (Math.Pow(A, 2));
            return resultado;
        }
        //De Guetto (Viscosidad del Aceite Saturado para 22.3 < °API <=33.1)
        static double ExtraerViscosidaddelAceiteSaturadoDeGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.3855 + 0.56664 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2038 + 0.8591*(Math.Pow(10, -0.000845 * _Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = 0.0132 + 0.9281 * A - 0.005215 * (Math.Pow(A, 2));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Saturado para °API > 31.1)
        static double ExtraerViscosidaddelAceiteSaturadodeGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var A = 2.7516*(Math.Pow(_Rs + 150, -0.2135));
            var resultado = (25.1921*(Math.Pow(_Rs + 100, -0.6487)))*(Math.Pow(_ViscosidaddelAceiteMuerto, A));
            return resultado; 
        }
        // Petrosky y Fashard (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturadoPetrosky(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.43 + 0.5165 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2001 + 0.8428*(Math.Pow(10, -0.000845 * _Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.06821 + 0.9824 * A + 0.0004034 *(Math.Pow(A, 2));
            return resultado; 
        }
        //Vazquez y Beggs (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturadoVazquez(double _ViscosidaddelAceiteSaturado, double  _p, double _pb)
        {
            var a = -(3.9*(Math.Pow(10, -5)))*(Math.Pow(_p, -5));
            var m = 2.6 *(Math.Pow(_p, 1.187))*(Math.Exp(a));
            var resultado = _ViscosidaddelAceiteSaturado*(Math.Pow ((_p / _pb), m));
            return resultado;
        }
        // Kartoadmodjo y Schmidt (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturadoKartoadmodjo(double _p, double _pb, double _ViscosidaddelAceiteSaturado)
        {
            var resultado = 1.00081 * _ViscosidaddelAceiteSaturado + 0.001127 *(_p - _pb)*(-0.006517*(Math.Pow (_ViscosidaddelAceiteSaturado, 1.8148)) + 0.038 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.59)));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Bajosaturado para °API <= 10)
        static double ExtraerViscosidaddelAceiteBajosturado(double _ViscosidaddelAceiteSaturado, double _p, double _pb, double _gradosAPI)
        {
            var resultado = _ViscosidaddelAceiteSaturado - (1 - _p/_pb)*(((Math.Pow(10, -2.19))*(Math.Pow(_ViscosidaddelAceiteSaturado, 1.055))*(Math.Pow(_pb, 0.3132))) / (Math.Pow (10, 0.00099 * _gradosAPI)));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Bajosaturado para °API > 10)
        static double ExtraerViscosidaddelAceiteBajosturadoGuetto(double _p, double _pb, double _ViscosidaddelAceiteSaturado)
        {
            var resultado = 0.9886 * _ViscosidaddelAceiteSaturado + 0.002763 *(_p - _pb)*(-0.01153 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.7933)) + 0.0316 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.5939)));
            return resultado; 
        }
        // Petrosky y Farshad (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturadoPetrosky(double _ViscosidaddelAceiteSaturado, double _p, double _pb)
        {
            var A = -1.0146 + 1.3322 *(Math.Log (_ViscosidaddelAceiteSaturado)) - 0.4876 *(Math.Log (Math.Pow(_ViscosidaddelAceiteSaturado, 2))) - 1.15036 *(Math.Pow(_ViscosidaddelAceiteSaturado, 3));
            var resultado = _ViscosidaddelAceiteSaturado + 1.3322 *(Math.Pow(10, -3))*(_p - _pb)*(Math.Pow(10, A));
            return resultado; 
        }
        // Standing (Presion de Buruja)
        static double ExtraerPresiondeBurbuja(double _densidadrelativadelgas, double _gradosAPI, double _Rs, double _T)
        {
            var resultado = 18.2 * ((Math.Pow(_Rs / _densidadrelativadelgas, 0.83))* Math.Pow(10, 0.00091 * _T - 0.0125 * _gradosAPI)- 1.4);
            return resultado; 
        }
        //Vazquez (Presion de Burbuja)
       static double ExtraerPresiondeBurbujaVazquez(double _gradosAPI, double _Rs, double _densidadrelativadelgas, double _Tsep, double _psep, double _gradosFarenheit)
        {
            double c1 = 0, c2 = 0, c3 = 0;
            if (_gradosAPI > 30)
            {
                c1 = 0.0178;
                c2 = 1.1870;
                c3 = 23.931;
            } 
            else if (_gradosAPI <= 30)
            {
                c1 = 0.0362;
                c2 = 1.0937;
                c3 = 25.724;
            }
            var Yg100 = _densidadrelativadelgas * (1 + 5.912 * Math.Pow(10, -5)* _gradosAPI * _Tsep* Math.Log(_psep / 114.7));
            var resultado = Math.Pow(_Rs / c1 * _densidadrelativadelgas * Math.Exp(c3 * _gradosAPI / _gradosFarenheit +460), 1 / c2);
            return resultado;
        } 
        // Lasater (Presion de Burbuja)
            static double ExtraerPresiondeBurbujaLasater(double _Yg, double _densidadrelativadelgas, double _gradosFarenheit, double _Rs, double _densidadRelativaAceite, double _gradosAPI, double _ViscosidaddelAceiteSaturado)
        {
            double Mo = 0;
            if (_gradosAPI <= 40)
            {
                Mo = 630 - 10 * _gradosAPI;
            } 
            else if (_gradosAPI > 40)
            {
                Mo =73110 * Math.Pow(_gradosAPI, -1.562);
            }   
            double Pb = 0;
            if (_Yg > 60)
            {
                Pb = (8.26 * Math.Pow(_densidadrelativadelgas, 3.56) + 1.95) * (_gradosFarenheit + 460);
            } 
            else if (_Yg <= 60)
            {
                Pb = ((0.679 * Math.Exp(2.786 * _densidadrelativadelgas) - 0.323) * (_gradosFarenheit + 460)) / _densidadrelativadelgas;
            }
            var Yg = (_Rs / 379.3) / ((_Rs /379.3) + (350 * _densidadRelativaAceite/ Mo));
            var resultado = (Pb * (_gradosFarenheit + 460)) / _densidadrelativadelgas;
            return resultado;

        }
        // Glaso (Presion de Burbuja aceites pesados)
        static double ExtraerPresiondeBurbujaGlaso(bool _Aceitespesados, bool _Aceitesvolatiles, double _gradosFarenheit, double _gradosAPI, double _densidadrelativadelgas, double _Rs)
        {
            double a = 0;
            if (_Aceitespesados)
            {
                a = 0.172;
            } 
            else if (_Aceitesvolatiles)
            {
                a = 0.130;
            }
            var Pb = Math.Pow( _Rs / _densidadrelativadelgas, 0.816) * (Math.Pow(_gradosFarenheit, a) / Math.Pow(_gradosAPI,0.989));
            var resultado = Math.Pow(10, 1.7669 + 1.7447 * Math.Log(Pb) - 0.30218 * Math.Pow(Math.Log(Pb), 2));
            return resultado; 
        }
        // 1 libra = 454 gramos * (30.48cm3 / 1 pie)3
        static double ExtraerDensidadAceite(double _densidadAceiteGr) 
        {
            var resultado =  (_densidadAceiteGr * 1 / 454) * ( Math.Pow( 30.48 / 1,  3)) ;
            return resultado;
            
        }
        static double ExtraerDensidadRelativaAceite(double _densidadAceiteLb) 
        {
            const double densidadAgua = 62.4;
            return _densidadAceiteLb / densidadAgua;
        }
        static double ConvertirCelsiusFareheit(double _gradosCelsius) 
        {
            var resultado = (_gradosCelsius * (1.8)) + 32;    
            return resultado;
        }
        static double ExtraerGradosAPI(double _densidadRelativaAceite) 
        {
            var resultado = (141.5 / _densidadRelativaAceite) - 131.5; 
            return resultado;
            
        }

        
    }
}


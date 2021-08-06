using System;

namespace TareaJess
{
    class Program
    {
        static void Main(string[] args)// punto de entrada 
        {
            ShowInstructions();
            UserSelection();
            MostrarFinal();
        }
        private static void UserSelection()
        {
            try
            {
                char respuesta = Convert.ToChar(Console.ReadLine());
                RunSelection(respuesta);
                MostrarFinal();

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.InnerException);
            }
        }
        // Elegir si volver a ejecutar programa o cerrar
        private static void MostrarFinal() 
        {
            System.Console.WriteLine("Quieres hacer una nueva operación? y/n ");
            var respuesta = Console.ReadLine();
            if (respuesta == "y") 
            {
                ShowInstructions();
                UserSelection();
            }
            else if (respuesta == "n") 
            {
            
            }
        }
        // Encargado de correr la lógica del programa seleccionado por el usuario
        private static void RunSelection(char response)
        {
            
            switch (response)
            {
                case '1':
                    ExtractRsStanding();
                    break;

                case '2':
                    ExtractRs();
                    break;

                case '3':
                    ExtractOilRelativedDensity();

                    break;
                case '4':
                    Case3();
                    break;
                case '5':
                    Case5();
                    break;
                case '6':
                    Case6();
                    break;
                case '7':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura");
                    double GRadosAPI = Convert.ToDouble(System.Console.ReadLine());
                    double PRESIion = Convert.ToDouble(System.Console.ReadLine());
                    double dEnsidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
                    double TEmperatura = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case '8':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite");
                    double Rs = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas1 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura1 = Convert.ToDouble(System.Console.ReadLine());
                    double _densidadrelativaaceite = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case '9':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Temperatura, Rs");
                    double Rs1 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI1 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas2 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura2 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'A':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite, Rs");
                    double densidadrelativadelgas3 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura3 = Convert.ToDouble(System.Console.ReadLine());
                    double _densidadRelativaAceite = Convert.ToDouble(System.Console.ReadLine());
                    double Rs2 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'B':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Temperatura, Densidad Relativa del Aceite, Rs");
                    double gradosAPI2 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas4 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura4 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadRelativaAceite1 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs3 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'C':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Densidad Relativa del Aceite, Temperatura, Densidad Relativa del Gas");
                    double Rs4 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelaceite = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura5 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas5 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'D':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura, Rs");
                    double gradosAPI3 = Convert.ToDouble(System.Console.ReadLine());
                    double Presion1 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas6 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura6 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs5 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'E':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
                    double gradosAPI4 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura7 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'F':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
                    double gradosAPI5 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura8 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'G':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Presion, Densidad Relativa del Gas, Temperatura, Rs");
                    double gradosAPI6 = Convert.ToDouble(System.Console.ReadLine());
                    double presion2 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelgas7 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura9 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs6 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'H':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Temperatura");
                    double gradosAPI7 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura10 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'I':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
                    double Rs7 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteMuerto = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'J':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
                    double Rs8 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteMuerto1 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'K':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
                    double Rs9 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteMuerto2 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'L':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
                    double Rs10 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteMuerto3 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'M':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Rs, Viscosidad del Aceite Muerto");
                    double Rs11 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteMuerto4 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'N':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado = Convert.ToDouble(System.Console.ReadLine());
                    double presion3 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'O':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado1 = Convert.ToDouble(System.Console.ReadLine());
                    double presion4 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb1 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'P':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb, Grados API");
                    double ViscosidaddelAceiteSaturado2 = Convert.ToDouble(System.Console.ReadLine());
                    double presion5 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb2 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI8 = Convert.ToDouble(System.Console.ReadLine());

                    break;
                case 'Q':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado3 = Convert.ToDouble(System.Console.ReadLine());
                    double presion6 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb3 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'R':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Viscosidad del Aceite Saturado, Presion, Pb");
                    double ViscosidaddelAceiteSaturado4 = Convert.ToDouble(System.Console.ReadLine());
                    double presion7 = Convert.ToDouble(System.Console.ReadLine());
                    double Pb4 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'S':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas8 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI9 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs12 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura11 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'T':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas9 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI10 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs13 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura12 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'U':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos:Densidad Relativa del Gas, Grados API, Rs, Temperatura, Densidad Relativa del Aceite, Viscosidad del Aceite Saturado");
                    double densidadrelativadelgas10 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI11 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs14 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura13 = Convert.ToDouble(System.Console.ReadLine());
                    double densidadrelativadelaceite1 = Convert.ToDouble(System.Console.ReadLine());
                    double ViscosidaddelAceiteSaturado5 = Convert.ToDouble(System.Console.ReadLine());
                    break;
                case 'V':
                    System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del Gas, Grados API, Rs, Temperatura");
                    double densidadrelativadelgas11 = Convert.ToDouble(System.Console.ReadLine());
                    double gradosAPI13 = Convert.ToDouble(System.Console.ReadLine());
                    double Rs15 = Convert.ToDouble(System.Console.ReadLine());
                    double temperatura14 = Convert.ToDouble(System.Console.ReadLine());
                    break;
            }
        }

        private static void Case6()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas");
            double Gradosapi = Convert.ToDouble(System.Console.ReadLine());
            double DEnsidadRelativadelGas = Convert.ToDouble(System.Console.ReadLine());

            var response = ExtraerViscosidaddelAceiteBajosturadoKartoadmodjo();
            System.Console.WriteLine(response);
        }

()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion");
            double GradosApi = Convert.ToDouble(System.Console.ReadLine());
            double DensidadRelativadelGas = Convert.ToDouble(System.Console.ReadLine());
            double PREsion = Convert.ToDouble(System.Console.ReadLine());

            var response = ExtraerBoGlaso(parametros, ParamArrayAttribute, x, ,d f, f, );
            System.Console.WriteLine(response);
        }
        private static void Case5
        private static void Case3()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion");
            double GradosAPi = Convert.ToDouble(System.Console.ReadLine());
            double DensidadRelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            double PResion = Convert.ToDouble(System.Console.ReadLine());

            var response = ExtraerRsLasater();
            System.Console.WriteLine(response);
        }

        private static void ExtractOilRelativedDensity()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Aceite, ");
            double GradosAPI = Convert.ToDouble(System.Console.ReadLine());
            double ExtraerDensidadRelativaAceite = Convert.ToDouble(System.Console.ReadLine());
            var _densidadrelativaaceite = 1;
            var response = ExtraerRsLasater(GradosAPI, _densidadrelativaaceite);
        }
        
        private static void ExtractRs()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Grados API, Densidad Relativa del Gas, Presion, Temperatura");
            var gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            var densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var presion = Convert.ToDouble(System.Console.ReadLine());
            var Temperatura = Convert.ToDouble(System.Console.ReadLine());

            var resultado = ExtraerRs(gradosAPI, densidadrelativadelgas, presion, temperatura);
        }

        private static void ExtractRsStanding()
        {
            System.Console.WriteLine("Para realizar la operacion son necesarios los siguientes datos: Densidad Relativa del gas, grados API, Temperatura, Presion");

            var densidadrelativadelgas = Convert.ToDouble(System.Console.ReadLine());
            var gradosAPI = Convert.ToDouble(System.Console.ReadLine());
            var Temperatura = Convert.ToDouble(System.Console.ReadLine());
            var Presion = Convert.ToDouble(System.Console.ReadLine());
            var resultado = ExtraerRsStanding(densidadrelativadelgas, gradosAPI, Temperatura, Presion);
            System.Console.WriteLine($"Resultado {resultado}");

        }

        private static void ShowInstructions()
        {
            System.Console.WriteLine("Programa que calcula correlaciones PVT");
            System.Console.WriteLine("Elige la ecuacion a realizar");
            System.Console.WriteLine("1.- Rs Standing");
            System.Console.WriteLine("2.- Rs Vazquez y Beggs");
            System.Console.WriteLine("3.- Rs Lasater");
            System.Console.WriteLine("4.- Rs Glaso aceites pesados");
            System.Console.WriteLine("5.- Rs Glaso aceites volatiles");
            System.Console.WriteLine("6.- Rs Kartoadmodjo Schmidt");
            System.Console.WriteLine("7.- Rs Petrosky y Farshad");
            System.Console.WriteLine("8.- Bo Standing");
            System.Console.WriteLine("9.- Bo Vazquez y Beggs");
            System.Console.WriteLine("A.- Bo Glaso");
            System.Console.WriteLine("B.- Bo Kartoadmodjo");
            System.Console.WriteLine("C.- Bo Petrosky");
            System.Console.WriteLine("D.- Co Vazquez");
            System.Console.WriteLine("E.- Viscosidad del Aceite Muerto Beggs y Robinson");
            System.Console.WriteLine("F.- Viscosidad del Aceite Muerto Glaso");
            System.Console.WriteLine("G.- Viscosidad del Aceite Muerto Kartoadmodjo");
            System.Console.WriteLine("H.- Viscosidad del Aceite Muerto Petrosky");
            System.Console.WriteLine("I.- Viscosidad del Aceite Saturado Beggs y Robinson");
            System.Console.WriteLine("J.- Viscosidad del Aceite Saturado Kartoadmodjo");
            System.Console.WriteLine("K.- Viscosidad del Aceite Saturado De Guetto 10 < °API <= 33.1");
            System.Console.WriteLine("L.- Viscosidad del Aceite Saturado De Guetto °API > 31.1");
            System.Console.WriteLine("M.- Viscosidad del Aceite Saturado Petrosky");
            System.Console.WriteLine("N.- Viscosidad del Aceite Bajosaturado Vazquez y Beggs");
            System.Console.WriteLine("O.- Viscosidad del Aceite Bajosaturado Kartoadmodjo");
            System.Console.WriteLine("P.- Viscosidad del Aceite Bajosaturado De Guetto °API <= 10");
            System.Console.WriteLine("Q.- Viscosidad del Aceite Bajosaturado De Guetto °API > 10");
            System.Console.WriteLine("R.- Viscosidad del Aceite Bajosaturado Petrosky");
            System.Console.WriteLine("S.- Presion de Burbuja Standing");
            System.Console.WriteLine("T.- Presion de Burbuja Vazquez");
            System.Console.WriteLine("U.- Presion de Burbuja Lasater");
            System.Console.WriteLine("V.- Presion de Burbuja Glaso");
        }




        
    }
}
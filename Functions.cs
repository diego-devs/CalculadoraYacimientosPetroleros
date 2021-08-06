namespace TareaJess 
{
    public class Functions 
    {
        public const double hldskfjhsadf = 0.4731;

        // todas las constantes
        static double ExtraerViscosidaddelAceiteSaturadoGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = hldskfjhsadf + 0.5158 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2478 + 0.6114 (Math.Pow(10, -0.000845 * _Rs)))(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.6311 + 1.078 * A - 0.003653 * (Math.Pow(A, 2));
            return resultado;
        }
                //Standing (1947)
        static double ExtraerRsStanding(double _densidadRelativaCondicionesEstandard, double _gradosAPI, double _gradosFarenheit, double _presion) 
        {
            var resultado = _densidadRelativaCondicionesEstandard * Math.Pow((Math.Pow(10, (0.0125 * _gradosAPI) - (0.00091 * _gradosFarenheit)) * ((_presion / 18.2) + 1.4)), 1.2048);
            return resultado;
        }
        //Vazquez y Beggs (1980 )
        static double ExtraerRs(double _gradosAPI, double _densidadrelativadelgas, double _p, double _gradosFarenheit)
        {
            double c1 =0,c2 =0, c3=0;
            if (_gradosAPI > 30)
            {
                c1 = 0.0178;
                c2 = 1.1870;
                c3 = 23.931;
            } 
            else if (_gradosAPI <= 30)
            {
                c1 = 0.0362;
                c2 = 1.0937;
                c3 = 25.724;
            }
            var  densidadrelativadelgas = (_densidadrelativadelgas*(1 + (Math.Pow (5.912 * 10,-5)(_gradosAPI * _gradosFarenheit)(Math.Log (_p + 14.7 /114.7)))));
            double resultado = c1 * densidadrelativadelgas * Math.Pow(_p, c2) * Math.Exp(c3 * _gradosAPI / _gradosFarenheit+ 460);
            return resultado;
        } 
        //Lasater (Rs)
        static double ExtraerRsLasater(double _gradosAPI, double _densidadrelativaaceite, double _parametroyg, double _parametroMo)
        {
            var parametroyg = (_parametroyg (0.359(Math.Log(((1.473 * 1920 * 0.85)/176 + 460)+0.476))));
            var parametroMo = (_parametroMo *(630 - 10 *(_gradosAPI)));
            var resultado = (132.755*(_densidadrelativaaceite)(_parametroyg))/(280)(1-0.5259);
            return resultado;
        }
        //Glaso (Rs)(1980 aceites pesados)
        static double ExtraerRs(double _gradosAPI, double _densidadrelativadelgas, double _p)
        {
            var a = 0.172;
            var resultado = _densidadrelativadelgas * (Math.Pow (Math.Pow(10, 2.8869 - (Math.Pow(14.1811 -3.3093* Math.Log(_p),0.5)))*(Math.Pow (_gradosAPI, 0.989)/Math.Pow(_densidadrelativadelgas, a)), 1.2255));
            return resultado; 
        }
        // Glaso (Rs aceites volatiles)
        static double ExtraerRsGlaso(double _gradosAPI, double _densidadrelativadelgas, double _p)
        {
            var a = 0.172;
            var resultado = _densidadrelativadelgas * (Math.Pow (Math.Pow(10, 2.8869 - (Math.Pow(14.1811 -3.3093* Math.Log(_p),0.5)))*(Math.Pow (_gradosAPI, 0.989)/Math.Pow(_densidadrelativadelgas, a)), 1.2255));
            return resultado; 
        }
        //Kartoatmodjo y Schmidt (Rs)(1994)
        static double ExtraeRs(double _gradosAPI, double _densidadrelativadelgas)
        {
            var c1 = 0.03150;
            var c2 = 0.7587;
            var c3 = 11.2895;
            var c4 = 0.9143;
            var resultado = _densidadrelativadelgas*(c1*(Math.Pow(_gradosAPI, c2)(Math.Pow(1920, 1/c4)(Math.Pow(10, c3*(_gradosAPI)/176 + 460)))));
            
            return resultado; 
        }
        //Petrosky y Farshad (Rs)(1993)
        static double ExtraerRsPetrosky(double _gradosAPI, double _p, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var x= 7.916 * Math.Pow(10, -4) * Math.Pow(_gradosAPI, 1.541) - 4.561 * Math.Pow(10, -5) * Math.Pow(_gradosFarenheit, 1.3911);
            var resultado = Math.Pow((_p / 112.727 + 12.34) * Math.Pow(_densidadrelativadelgas, 0.8439) * Math.Pow(10, x), 1.73184);
            return resultado;
        }
        //Standing (Bo)
        static double ExtraerBo(double _Rs, double _densidadrelativadelgas, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 0.9759 + 0.00012 (Math.Pow(_Rs(Math.Pow(_densidadrelativadelgas/_densidadrelativadelgas, 0.5) + 1.25*(_gradosFarenheit)),1.2));
            return resultado;
        }
        //Vazquez y Beggs (Bo) (1980)
        static double ExtraerBoVazquez(double _Rs, double _gradosAPI, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var c1 = 0.0004677;
            var c2 = 0.000011;
            var c3 = 0.000000001337;
            var resultado = 1 + c1*(_Rs) + c2*(_gradosFarenheit-60)(_gradosAPI/_densidadrelativadelgas) + c3(_Rs)(_gradosFarenheit-60)(_gradosAPI/_densidadrelativadelgas);
            return resultado;
        }
        //Glaso (Bo)
        static double ExtraerBoGlaso(double _Rs, double _densidadrelativaaceite, double _densidadrelativadelgas, double _gradosFarenheit)
        {
            var Bob = _Rs (Math.Pow(_densidadrelativaaceite / _densidadrelativadelgas, 0.526) + 0.968(_gradosFarenheit));
            var resultado = 1 + (Math.Pow(10, -6.58511 + 2.91329 *(Math.Log(Bob) - 0.27683 *(Math.Pow(Math.Log(Bob), 2))))); 
            return resultado;
        }
        //Kartoadmodjo (Bo)
        static double ExtraerBo(double _gradosAPI, double _densidadrelativadelgas, double _Rs, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 0.98496 + 0.0001 (Math.Pow(Math.Pow(_Rs, 0.755) Math.Pow(_densidadrelativadelgas, 0.25)* Math.Pow(_densidadrelativaaceite, -1.5) + 0.45 * _gradosFarenheit, 1.5));
            return resultado;
        }
        //Pettrosky (Bo)
        static double ExtraerBoPetrosky(double _Rs, double _densidadrelativadelgas, double _densidadrelativaaceite, double _gradosFarenheit)
        {
            var resultado = 1.0113 + 7.2046 (Math.Pow(10, -5)) Math.Pow(Math.Pow(_Rs, 0.3738) * (Math.Pow(_densidadrelativadelgas, 0.2914)/Math.Pow(_densidadrelativaaceite, 0.6265))+ 0.24626 * Math.Pow(_densidadrelativaaceite, 0.5371), 3.0936);
            return resultado; 
        }
        //Vazquez (Co)
        static double ExtraerBoVazquez(double _Rs, double _densidadrelativadelgas, double _gradosAPI, double _gradosFarenheit, double _p)
        {
            var resultado = (-1433 + 5 * _Rs + 17.2 * _gradosFarenheit -  1180 * _densidadrelativadelgas +  12.61 * _gradosAPI) / _p * (Math.Pow(10, 5)); 
            return resultado;
        }
        //Beggs y Robinson (Viscosidad del Aceite muerto)
        static double ExtraerViscosidaddelAceiteMuerto()
        {
            var x = (Math.Pow(10, 3.0324 - 0.02023 * _gradosAPI))*(Math.Pow(_gradosFarenheit, -1.163));
            var resultado = (Math.Pow(10, x)) - 1; 
            return resultado; 
        }
        //Glaso (Viscosidad del Aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoGlaso(double _gradosFarenheit, double _gradosAPI)
        {
            var a = 10.313 * (Math.Log(_gradosFarenheit)) - 36.447; 
            var resultado = 3.141 * (Math.Pow(10, 10)) * (Math.Pow(_gradosFarenheit, -3.444))*(Math.Pow(Math.Log(_gradosAPI), a));
            return resultado;
        }
        //Kartoadmodjo (Viscosidad del aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoKartoadmodjo(double _gradosAPI, double _gradosFarenheit, double _Rs, double _densidadrelativadelgas, double _p)
        {
            var resultado = (6.8257 * Math.Pow(_Rs, 0.5002) * Math.Pow(_gradosAPI, 0.3613) * Math.Pow(_gradosFarenheit, 0.76606) * Math.Pow(_densidadrelativadelgas, 0.35505)) / _p * Math.Pow(10, 6);
            return resultado;
        }
        //Petroskky (Viscosidad del Aceite Muerto)
        static double ExtraerViscosidaddelAceiteMuertoPetrosky(double _gradosAPI, double _gradosFarenheit)
        {
            var X = (4.59388)*(Math.Log(_gradosFarenheit)) - 22.82792;
            var resultado = 2.3511*(Math.Pow(10, 7))(Math.Pow(_gradosFarenheit, -2.10255))(Math.Pow(Math.Log(_gradosAPI),X));
            return resultado;
        }
        //Beggs y Robinson (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturado(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var b = 5.44*(Math.Pow(_Rs + 150, -0.338));
            var resultado = (10.715*(Math.Pow(_Rs + 100, 0.515)))*(Math.Pow(_ViscosidaddelAceiteMuerto, b));
            return resultado; 
        }
        //Kartoadmosjo (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturadoKartoadmodjo(double _ViscosidaddelAceiteMuerto, double _Rs)
        {
            var B = 0.43 + 0.5165*(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2001 + 0.8428*(Math.Pow(10, -0.000845*_Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.06821 + 0.9824 * A + 0.0004034 *(Math.Pow(A, 2));
            return resultado; 
        }
        //De Guetto (Viscosidad del Aceite Saturado para 10 < °API <= 22.3)
        static double ExtraerViscosidaddelAceiteSaturadoGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.4731 + 0.5158 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2478 + 0.6114 (Math.Pow(10, -0.000845 * _Rs)))(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.6311 + 1.078 * A - 0.003653 * (Math.Pow(A, 2));
            return resultado;
        }
        //De Guetto (Viscosidad del Aceite Saturado para 22.3 < °API <=33.1)
        static double ExtraerViscosidaddelAceiteSaturadoDeGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.3855 + 0.56664 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2038 + 0.8591*(Math.Pow(10, -0.000845 * _Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = 0.0132 + 0.9281 * A - 0.005215 * (Math.Pow(A, 2));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Saturado para °API > 31.1)
        static double ExtraerViscosidaddelAceiteSaturadodeGuetto(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var A = 2.7516*(Math.Pow(_Rs + 150, -0.2135));
            var resultado = (25.1921*(Math.Pow(_Rs + 100, -0.6487)))*(Math.Pow(_ViscosidaddelAceiteMuerto, A));
            return resultado; 
        }
        // Petrosky y Fashard (Viscosidad del Aceite Saturado)
        static double ExtraerViscosidaddelAceiteSaturadoPetrosky(double _Rs, double _ViscosidaddelAceiteMuerto)
        {
            var B = 0.43 + 0.5165 *(Math.Pow(10, -0.00081 * _Rs));
            var A = (0.2001 + 0.8428*(Math.Pow(10, -0.000845 * _Rs)))*(Math.Pow(_ViscosidaddelAceiteMuerto, B));
            var resultado = -0.06821 + 0.9824 * A + 0.0004034 *(Math.Pow(A, 2));
            return resultado; 
        }
        //Vazquez y Beggs (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturado(double _ViscosidaddelAceiteSaturado, double  _p, double _pb)
        {
            var a = -(3.9*(Math.Pow(10, -5)))*(Math.Pow(_p, -5));
            var m = 2.6 (Math.Pow(_p, 1.187))(Math.Exp(a));
            var resultado = _ViscosidaddelAceiteSaturado*(Math.Pow ((_p / _pb), m));
            return resultado;
        }
        // Kartoadmodjo y Schmidt (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturadoKartoadmodjo(double _p, double _pb, double _ViscosidaddelAceiteSaturado)
        {
            var resultado = 1.00081 * _ViscosidaddelAceiteSaturado + 0.001127 (_p - _pb)(-0.006517*(Math.Pow (_ViscosidaddelAceiteSaturado, 1.8148)) + 0.038 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.59)));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Bajosaturado para °API <= 10)
        static double ExtraerViscosidaddelAceiteBajosturado(double _ViscosidaddelAceiteSaturado, double _p, double _pb, double _gradosAPI)
        {
            var resultado = _ViscosidaddelAceiteSaturado - (1 - _p/_pb)(((Math.Pow(10, -2.19))(Math.Pow(_ViscosidaddelAceiteSaturado, 1.055))*(Math.Pow(_pb, 0.3132))) / (Math.Pow (10, 0.00099 * _gradosAPI)));
            return resultado; 
        }
        // De Guetto (Viscosidad del Aceite Bajosaturado para °API > 10)
        static double ExtraerViscosidaddelAceiteBajosturadoGuetto(double _p, double _pb, double _ViscosidaddelAceiteSaturado)
        {
            var resultado = 0.9886 * _ViscosidaddelAceiteSaturado + 0.002763 (_p - _pb)(-0.01153 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.7933)) + 0.0316 *(Math.Pow(_ViscosidaddelAceiteSaturado, 1.5939)));
            return resultado; 
        }
        // Petrosky y Farshad (Viscosidad del Aceite Bajosaturado)
        static double ExtraerViscosidaddelAceiteBajosturadoPetrosky(double _ViscosidaddelAceiteSaturado, double _p, double _pb)
        {
            var A = -1.0146 + 1.3322 *(Math.Log (_ViscosidaddelAceiteSaturado)) - 0.4876 *(Math.Log (Math.Pow(_ViscosidaddelAceiteSaturado, 2))) - 1.15036 *(Math.Pow(_ViscosidaddelAceiteSaturado, 3));
            var resultado = _ViscosidaddelAceiteSaturado + 1.3322 (Math.Pow(10, -3))(_p - _pb)*(Math.Pow(10, A));
            return resultado; 
        }
        // Standing (Presion de Buruja)
        static double ExtraerPresiondeBurbuja(double _densidadrelativadelgas, double _gradosAPI, double _Rs, double _T)
        {
            var resultado = 18.2 * ((Math.Pow(_Rs / _densidadrelativadelgas, 0.83))* Math.Pow(10, 0.00091 * _T - 0.0125 * _gradosAPI)- 1.4);
            return resultado; 
        }
        //Vazquez (Presion de Burbuja)
       static double ExtraerPresiondeBurbujaVazquez(double _gradosAPI, double _Rs, double _densidadrelativadelgas, double _Tsep, double _psep, double _gradosFarenheit)
        {
            double c1 = 0, c2 = 0, c3 = 0;
            if (_gradosAPI > 30)
            {
                c1 = 0.0178;
                c2 = 1.1870;
                c3 = 23.931;
            } 
            else if (_gradosAPI <= 30)
            {
                c1 = 0.0362;
                c2 = 1.0937;
                c3 = 25.724;
            }
            var Yg100 = _densidadrelativadelgas * (1 + 5.912 * Math.Pow(10, -5)* _gradosAPI * _Tsep* Math.Log(_psep / 114.7));
            var resultado = Math.Pow(_Rs / c1 * _densidadrelativadelgas * Math.Exp(c3 * _gradosAPI / _gradosFarenheit +460), 1 / c2);
            return resultado;
        } 
        // Lasater (Presion de Burbuja)
            static double ExtraerPresiondeBurbujaLasater(double _Yg, double _densidadrelativadelgas, double _gradosFarenheit, double _Rs, double _densidadRelativaAceite, double _gradosAPI, double _ViscosidaddelAceiteSaturado)
        {
            double Mo = 0;
            if (_gradosAPI <= 40)
            {
                Mo = 630 - 10 * _gradosAPI;
            } 
            else if (_gradosAPI > 40)
            {
                Mo =73110 * Math.Pow(_gradosAPI, -1.562);
            }   
            double Pb = 0;
            if (_Yg > 60)
            {
                Pb = (8.26 * Math.Pow(_densidadrelativadelgas, 3.56) + 1.95) * (_gradosFarenheit + 460);
            } 
            else if (_Yg <= 60)
            {
                Pb = ((0.679 * Math.Exp(2.786 * _densidadrelativadelgas) - 0.323) * (_gradosFarenheit + 460)) / _densidadrelativadelgas;
            }
            var Yg = (_Rs / 379.3) / ((_Rs /379.3) + (350 * _densidadRelativaAceite/ Mo));
            var resultado = (Pb * (_gradosFarenheit + 460)) / _densidadrelativadelgas;
            return resultado;

        }
        // Glaso (Presion de Burbuja aceites pesados)
        static double ExtraerPresiondeBurbujaGlaso(bool _Aceitespesados, bool _Aceitesvolatiles, double _gradosFarenheit, double _gradosAPI, double _densidadrelativadelgas, double _Rs)
        {
            double a = 0;
            if (_Aceitespesados)
            {
                a = 0.172;
            } 
            else if (_Aceitesvolatiles)
            {
                a = 0.130;
            }
            var Pb = Math.Pow( _Rs / _densidadrelativadelgas, 0.816) * (Math.Pow(_gradosFarenheit, a) / Math.Pow(_gradosAPI,0.989));
            var resultado = Math.Pow(10, 1.7669 + 1.7447 * Math.Log(Pb) - 0.30218 * Math.Pow(Math.Log(Pb), 2));
            return resultado; 
        }
        // 1 libra = 454 gramos * (30.48cm3 / 1 pie)3
        static double ExtraerDensidadAceite(double _densidadAceiteGr) 
        {
            var resultado =  (_densidadAceiteGr * 1 / 454) * ( Math.Pow( 30.48 / 1,  3)) ;
            return resultado;
            
        }
        static double ExtraerDensidadRelativaAceite(double _densidadAceiteLb) 
        {
            const double densidadAgua = 62.4;
            return _densidadAceiteLb / densidadAgua;
        }
        static double ConvertirCelsiusFareheit(double _gradosCelsius) 
        {
            var resultado = (_gradosCelsius * (1.8)) + 32;    
            return resultado;
        }
        static double ExtraerGradosAPI(double _densidadRelativaAceite) 
        {
            var resultado = (141.5 / _densidadRelativaAceite) - 131.5; 
            return resultado;
            
        }
    }
}
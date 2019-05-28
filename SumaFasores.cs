using System;
using System.IO;
namespace MatematicaSuperiorGrupo7
{
    public class SumaFasores
    {
        private String functionType;
        private Double angularFrequency_1;
        private Double initialPhase_1;
        private Double amplitude_1;
        private String functionType_2;
        private Double angularFrequency_2;
        private Double initialPhase_2;
        private Double amplitude_2;
        private Double a_1;//parte real binaria
        private Double a_2;//parte real binaria
        private Double b_1;//parte imaginaria binaria
        private Double b_2;//parte imaginaria binaria
        private Double resultReal;
        private Double resultImaginare;
        private Double resultAmplitude;
        private Double resultPhase;
        public SumaFasores(){

        }
        public void implementation (){
            Console.WriteLine("Ingrese los datos del primer Fasor: ");
            Console.WriteLine("Seleccione el valor correspondiente al tipo de fasor que va a ingresar para el primer fasor");
            Console.WriteLine("Es una función Senoidal (S) o Cosenoidal (C): ");
            functionType = Console.ReadLine();
            if (functionType == "C" || functionType == "c" || functionType == "S" || functionType == "s"){
                Console.WriteLine("Ingrese la amplitud de la onda");
                amplitude_1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la frecuencia angular");
                angularFrequency_1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la fase inicial en radianes");
                initialPhase_1 = Convert.ToDouble(Console.ReadLine());
                if (functionType == "S" || functionType == "s"){
                    initialPhase_1 += 0.5; //Sumo pi/2 si es una funcion senoidal para pasar trabajarlo como cosenoidal
                }
            }else{
                Console.WriteLine("Formato invalido para el primer fasor");
            }
            Console.WriteLine("Seleccione el valor correspondiente al tipo de fasor que va a ingresar para el segundo fasor");
            Console.WriteLine("Es una función Senoidal (S) o Cosenoidal (C): ");
            functionType = Console.ReadLine();
            if (functionType == "C" || functionType == "c" || functionType == "S" || functionType == "s"){
                Console.WriteLine("Ingrese la amplitud de la onda");
                amplitude_2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la frecuencia angular");
                angularFrequency_2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la fase inicial en radianes");
                initialPhase_2 = Convert.ToDouble(Console.ReadLine());
                if (functionType == "S" || functionType == "s"){
                    initialPhase_2 += 0.5; //Sumo pi/2 si es una funcion senoidal para pasar trabajarlo como cosenoidal
                }
            }else {
                Console.WriteLine("Formato invalido para el segundo fasor");
            }
            if (angularFrequency_1 == angularFrequency_2){
                a_1 = amplitude_1 * Math.Cos(initialPhase_1);
                b_1 = amplitude_1 * Math.Sin(initialPhase_1);
                a_2 = amplitude_2 * Math.Cos(initialPhase_2);
                b_2 = amplitude_2 * Math.Sin(initialPhase_2);
                resultReal = a_1 + a_2;
                resultImaginare = b_2 + b_1;
                resultAmplitude = Math.Sqrt(Math.Pow(resultReal,2) + Math.Pow(resultImaginare,2));
                resultPhase = Math.Atan(resultReal/resultImaginare);
                Console.WriteLine("La señal resultante es: "+resultAmplitude+" Cos( "+angularFrequency_1+" * t + "+ resultPhase+" )" );
            }else{
                Console.WriteLine("Las frecuencias angualares no noinciden");
            }
        }
    }
}
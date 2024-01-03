using System.Numerics;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

namespace Teste_xunity
{
public class IMC
{

 public double peso;
 public double altura;
 public double imc;
 public String categoria;
 
 public void Calcular_IMC() 
 {
    imc= peso / Math.Pow(altura,2);
    imc= Math.Round(imc,2);
 }

 public void Classificar_IMC()
{
if(imc< 18.5)

   categoria= "Abaixo do peso";

if(imc >=18.5 && imc < 30)

   categoria="Peso Normal";

if(imc >= 25 && imc < 35)

   categoria="Sobrepeso";

if(imc >= 30 && imc <35)

   categoria="Obesidade Grau 1";

if(imc >= 35 && imc <40)

   categoria="Obesidade Grau 2";

if(imc >= 40)

   categoria="Obesidade Grau 3";
}
}
}

double peso, altura, imc;

Console.WriteLine("-- Calculadora de IMC --");

Console.Write("Digite seu peso em kg...:");
peso = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite sua altura em m..:");
altura = Convert.ToDouble(Console.ReadLine()!);

imc = peso / (altura * altura);

Console.WriteLine($"Seu IMC é {imc:N2} kg/m².");

if (imc < 17)
{
    Console.WriteLine("Diagnóstico: Muito abaixo do peso" );
}
else if (imc < 18.50 )
{
    Console.WriteLine("Diagnóstico: Abaixo do peso" );
}
else if ( imc < 25)
{
    Console.WriteLine("Diagnóstico: Peso normal" );
}
else if (imc < 30)
{
    Console.WriteLine("Diagnóstico: Acima do peso" );
}
else if (imc < 35)
{
    Console.WriteLine("Diagnóstico: Obesidade |" );
}
else if (imc < 40)
{   
    Console.WriteLine("Diagnóstico: Obesidade ||(severa)" );
}
else if (imc > 40)
{
    Console.WriteLine("Diagnóstico: Obesidade |||(mórbida)" );
}
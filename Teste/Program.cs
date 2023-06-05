try
{
    Console.WriteLine("DIVISÃO");
    Console.Write("Informe o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Informe o segundo valor: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine($"\nResultado = {result}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"\nNão é permitido divisão por zero! {ex.Message}");
}
catch(InvalidCastException ex)
{
    Console.WriteLine($"\nConversão de string para letra não é permitida! {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"\nErro! {ex.Message}");
}
finally
{
    Console.WriteLine("\nObrigada por usar meu programa! XD");
}
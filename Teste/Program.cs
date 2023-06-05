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
catch(Exception ex)
{
    Console.WriteLine($"\nErro! {ex.Message}");
}
finally
{
    Console.WriteLine("\nObrigada por usar meu programa! XD");
}
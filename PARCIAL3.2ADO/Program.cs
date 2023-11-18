using PARCIAL3._2ADO;

using (var contextdb = new Context())
{
    foreach (var evalua in contextdb.notas)
    {
        Console.WriteLine(
            $"  nombre  {evalua.estudiante}, " +
            $"parciales: {evalua.parciales}," +
            $" laboratorio: {evalua.laboratorios}, " +
            $"final: {evalua.final}");
    }
}
Console.WriteLine("ingrese los datos de sus respectivas pruebas:");

Console.Write(" ingrese sus Nombres: ");
string nombre = Console.ReadLine();

Console.Write(" ingrese su nota de parciales: ");
double parciales = Convert.ToSingle(Console.ReadLine());

Console.Write(" ingrese nota de sus laboratorios: ");
double laboratorios = Convert.ToSingle(Console.ReadLine());

double final = parciales + laboratorios; 

using (var contextdb = new Context())
{
    contextdb.Database.EnsureCreated();

    var nuevaEvaluacion = new notas()
    {
        estudiante = nombre,
        parciales = parciales,
        laboratorios = laboratorios,
        final = final
    };

    contextdb.Add(nuevaEvaluacion);
    contextdb.SaveChanges();
}

Console.WriteLine("Dato final");

using (var contextdb = new Context())
{
    foreach (var evalua in contextdb.notas)
    {
        Console.WriteLine(
            $" nombre   {evalua.estudiante}," +
            $" parciales:   {evalua.parciales}, " +
            $"laboratorio:   {evalua.laboratorios}," +
            $" final:  {evalua.final}");
    }
}
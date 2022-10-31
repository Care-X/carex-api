var properties = GetProperties(SymptomAnalyzer.Models.SymptomModel);

foreach (var p in properties)
{
    string name = p.Name;
    var value = p.GetValue(SymptomAnalyzer.Models.SymptomModel, null);
    Console.WriteLine(name);
    Console.WriteLine(value);
    //await File.WriteAllTextAsync("json.txt", "{");
}

static PropertyInfo[] GetProperties(object obj)
{
    return obj.GetType().GetProperties();
}
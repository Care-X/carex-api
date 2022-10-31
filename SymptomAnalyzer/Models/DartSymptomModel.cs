using Microsoft.ML.Data;
using Newtonsoft.Json;
using System.Reflection;

namespace SymptomAnalyzer.Models
{
    public class DartSymptomModel
    {
        public string symptomId { get; set; }
        public string symptomName { get; set; }
        public bool isSelected { get; set; } = false;

        public static List<DartSymptomModel> SymptomsList()
        {
            StreamReader readJson = new("./Helper/symptomList.json");

            string json = readJson.ReadToEnd();
            List<DartSymptomModel> items = JsonConvert.DeserializeObject<List<DartSymptomModel>>(json);

            foreach (DartSymptomModel item in items)
            {
                Console.WriteLine(item.symptomName);
            }
            return items;

        }
    }
}
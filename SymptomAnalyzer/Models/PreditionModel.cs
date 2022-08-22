using Microsoft.ML.Data;

namespace SymptomAnalyzer.Models
{
    public class PreditionModel
    {
        [ColumnName("PredictedLabel")]
        public string? Prediction { get; set; }

        public float[]? Score { get; set; }
    }
}

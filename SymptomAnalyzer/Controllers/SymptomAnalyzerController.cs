using Microsoft.ML;
using SymptomAnalyzer.Models;
using Microsoft.AspNetCore.Mvc;

namespace SymptomAnalyzer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SymptomAnalyzerController : ControllerBase
    {
        public static readonly Lazy<PredictionEngine<SymptomModel, PreditionModel>> PredictEngine = new(() => CreatePredictEngine(), true);

        [Route("predict")]
        [HttpPost]
        public PreditionModel Predict(SymptomModel input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<SymptomModel, PreditionModel> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load("./Assets/MLModel.zip", out var _);
            return mlContext.Model.CreatePredictionEngine<SymptomModel, PreditionModel>(mlModel);
        }
    }
}

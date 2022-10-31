using Microsoft.ML;
using SymptomAnalyzer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SymptomAnalyzer.Helper;
using Newtonsoft.Json;
using System.IO;

namespace SymptomAnalyzer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SymptomAnalyzerController : ControllerBase
    {
        public static readonly Lazy<PredictionEngine<SymptomModel, PreditionModel>> PredictEngine = new(() => CreatePredictEngine(), true);

        [Route("authenticate/uid={uid:minlength(20)}")]
        [HttpGet]
        public IActionResult Authenticate(string uid)
        {
            if (string.IsNullOrEmpty(uid) || string.IsNullOrWhiteSpace(uid))
            {
                return BadRequest();
            }
            else
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(Constants.Key);
                SymmetricSecurityKey securityKey = new(keyBytes);
                SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha512);

                var claims = new[]
                {
                    new Claim("uid", uid)
                };

                var token = new JwtSecurityToken(
                    Constants.Audiance,
                    Constants.Issuer,
                    claims,
                    notBefore: DateTime.Now,
                    expires: DateTime.Now.AddHours(1),
                    credentials
                    );

                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { accessToken = tokenString });
            }
        }

        [Route("tips")]
        [HttpGet]
        public IActionResult Tips()
        {
            string path = "./Helper/healthTips.json";
            Random random = new();
            string[] lines = System.IO.File.ReadAllLines(path);
            int lineCount = 6;
            return Ok(lines[random.Next(0, lineCount)]);
        }

        [Route("symptoms")]
        [HttpGet]
        [Authorize]
        public IActionResult Symptoms()
        {
            return Ok(DartSymptomModel.SymptomsList());
        }

        [Route("predict")]
        [HttpPost]
        [Authorize]
        public IActionResult Predict(SymptomModel input)
        {
            var predEngine = PredictEngine.Value;
            return Ok(predEngine.Predict(input));
        }

        private static PredictionEngine<SymptomModel, PreditionModel> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load("./SymptomAnalyzerMLModel.zip", out var _);
            return mlContext.Model.CreatePredictionEngine<SymptomModel, PreditionModel>(mlModel);
        }
    }
}

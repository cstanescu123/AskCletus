using System.Text.Json.Serialization;

namespace AskCletus_BackEnd.Services.Models
{
    public class GithubToken
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        public string Scope { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}

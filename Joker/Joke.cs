using System.Text.Json.Serialization;

namespace Joker
{
    public class Joke
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("setup")]
        public string Setup { get; set; }

        [JsonPropertyName("punchline")]
        public string Punchline { get; set; }

        public Joke(string type, string setup, string punchline) {
            Type = type;
            Setup = setup;
            Punchline = punchline;
        }
    }
}

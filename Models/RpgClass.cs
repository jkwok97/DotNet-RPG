using System.Text.Json.Serialization;

namespace DotNet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Machine,
        Wizard,
        Robot,
        God
    }
}

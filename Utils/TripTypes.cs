using System.Text.Json.Serialization;

namespace data_balk.Utils

{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TripTypes
    {
        National_trip = 200,
        Local_trip = 100
    }
}
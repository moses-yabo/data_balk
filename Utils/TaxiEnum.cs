using System.Text.Json.Serialization;

namespace data_balk.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaxiRoles
    {
        Taxi_owner = 1,
        Taxi_driver = 2,
        Taxi_passenger = 3,
        Trailer_owner = 4
    }
}
using Newtonsoft.Json;
using System;

namespace SharpScript.POC
{
    public partial class CoronaData
    {
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("city_ibge_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? CityIbgeCode { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("epidemiological_week", NullValueHandling = NullValueHandling.Ignore)]
        public long? EpidemiologicalWeek { get; set; }

        [JsonProperty("estimated_population_2019", NullValueHandling = NullValueHandling.Ignore)]
        public long? EstimatedPopulation2019 { get; set; }

        [JsonProperty("is_last", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLast { get; set; }

        [JsonProperty("is_repeated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRepeated { get; set; }

        [JsonProperty("last_available_confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastAvailableConfirmed { get; set; }

        [JsonProperty("last_available_confirmed_per_100k_inhabitants", NullValueHandling = NullValueHandling.Ignore)]
        public double? LastAvailableConfirmedPer100KInhabitants { get; set; }

        [JsonProperty("last_available_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastAvailableDate { get; set; }

        [JsonProperty("last_available_death_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? LastAvailableDeathRate { get; set; }

        [JsonProperty("last_available_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastAvailableDeaths { get; set; }

        [JsonProperty("new_confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewConfirmed { get; set; }

        [JsonProperty("new_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewDeaths { get; set; }

        [JsonProperty("order_for_place", NullValueHandling = NullValueHandling.Ignore)]
        public long? OrderForPlace { get; set; }

        [JsonProperty("place_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceType { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }
    }
}

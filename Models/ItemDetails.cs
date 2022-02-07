using System.Text.Json.Serialization;


namespace CollectionApp.Models;
public class ItemDetails{
   [JsonPropertyName("name")]
   public string? Name{get;set;}

   [JsonPropertyName("condition")]
   public string? Condition{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("volume")]
   public int? Volume{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("sealed")]
   public bool? Sealed{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("hasCase")]
   public bool? HasCase{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("platform")]
   public string? Platform{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("genres")]
   public List<string?>? Genres{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("publisher")]
   public string? Publisher{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("author")]
   public string? Author{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("releaseDate")]
   public string? ReleaseDate{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("mediaType")]
   public string? MediaType{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("limitedEdition")]
   public bool? LimitedEdition{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("type")]
   public string? Type{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("from")]
   public string? From{get;set;}

   [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
   [JsonPropertyName("ageRestricted")]
   public bool? AgeRestricted{get;set;}
}
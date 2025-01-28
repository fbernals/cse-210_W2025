using System.Text.Json;
using System.Text.Json.Serialization;

// Class to represent the API response
public class QuoteResponse
{
    [JsonPropertyName("quote")]
    public string Quote { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }
}

public class QuoteFetcher
{
    private const string _apiUrl = "https://api.api-ninjas.com/v1/quotes";
    private const string _apiKey = "6wslCwq55lCkNTKIs+Tchg==hrIC2RF7XOecxVfL";

    public async Task<string> GetRandomQuoteAsync()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-Api-Key", _apiKey);

            try
            {
                HttpResponseMessage response = await client.GetAsync(_apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var quotes = JsonSerializer.Deserialize<QuoteResponse[]>(responseBody);

                if (quotes != null && quotes.Length > 0)
                {
                    var quote = quotes[0];
                    return $"\"{quote.Quote}\" - {quote.Author} (Category: {quote.Category})";
                }

                return "No quotes found.";
            }
            catch (Exception ex)
            {
                return $"Error fetching quote: {ex.Message}";
            }
        }
    }
}
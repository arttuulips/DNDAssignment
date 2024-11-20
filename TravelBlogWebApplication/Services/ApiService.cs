using System.Net.Http;
using System.Threading.Tasks;
using TravelBlogWebApplication.Models;
public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<User[]> GetItemsAsync()
    {
        var users = await _httpClient.GetFromJsonAsync<User[]>("api/Users");
        return users ?? Array.Empty<User>();
    }
}
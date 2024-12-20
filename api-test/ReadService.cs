using System.Text.Json;

namespace api_test;

public interface IReadService
{
    Task<IEnumerable<Model>> Read();
}

public class ReadService : IReadService
{
    public async Task<IEnumerable<Model>> Read()
    {
        await using var file = File.Open("../large_sample_data.json", FileMode.Open);

        using var content = new StreamReader(file);

        return await JsonSerializer.DeserializeAsync<IEnumerable<Model>>(content.BaseStream);
    }
}
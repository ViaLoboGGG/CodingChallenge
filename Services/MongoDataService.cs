using CodingTestBlazor.Models;
using MongoDB.Driver;

public class MongoDataService
{
    private readonly IMongoCollection<Person> _collection;

    public MongoDataService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("InterviewDB");
        _collection = database.GetCollection<Person>("People");
    }

    public async Task<List<Person>> GetPeopleAsync()
    {
        // Candidate should complete the logic to fetch data from MongoDB.
        return new List<Person>(); // Placeholder
    }
}
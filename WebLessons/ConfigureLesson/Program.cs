using System.Text;
using Microsoft.Extensions.Options;

string[] commandLineArgs = { "name=Sam", "age=33" };


var builder = WebApplication.CreateBuilder();



builder.Configuration.AddJsonFile("person.json");
builder.Services.Configure<Person>(builder.Configuration);

var app = builder.Build();
//app.Map("/", (IConfiguration appConfig) => GetSectionContent(appConfig.GetSection("projectConfig")));

app.Map("/", (IOptions<Person> options) =>
{
    var person = options.Value;
    return person;
});


app.Run();

string GetSectionContent(IConfiguration configSection)
{
    var contentBuilder = new StringBuilder();

    foreach (var section in configSection.GetChildren())
    {
        contentBuilder.Append($"\"{section.Key}\":");
        if (section.Value == null)
        {
            string subSectionContent = GetSectionContent(section);
            contentBuilder.Append($"{{\n{subSectionContent}}},\n");
        }
        else
        {
            contentBuilder.Append($"\"{section.Value}\",\n");
        }
    }
    return contentBuilder.ToString();
}

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public List<string> Languages { get; set; } = new();
    public Company? Company { get; set; }
}
public class Company
{
    public string Title { get; set; } = "";
    public string Country { get; set; } = "";
}
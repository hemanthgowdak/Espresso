using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.OracleClient;
using TestAPI.Database;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        
    string queryString =
        @"INSERT INTO customers  
                        (customer_id, customer_name,city)  
                        VALUES  
                        (51, 'Oracle', 'Mumbai')";

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IDapperManager _dapperManager;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, 
                                        IDapperManager dapperManager)
    {
        _logger = logger;
        _dapperManager = dapperManager;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
       // InsertRow();

        DynamicParameters dynamicParameters = new DynamicParameters(new {
                customer_id = 1,
                customer_name = "Thor",
                city = "in_esrb_rating"
            });

          string queryString =
        @"INSERT INTO customers  
                        (customer_id, customer_name,city)  
                        VALUES  
                        (:customer_id, :customer_name, :city)";
       _dapperManager.Insert(queryString, dynamicParameters);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    public void InsertRow()
{

    string connectionString=@"User Id=system;Password=root;Data Source=ORCL";
    string queryString =
        @"INSERT INTO customers  
                        (customer_id, customer_name,city)  
                        VALUES  
                        (51, 'Oracle', 'Mumbai')";
    using (OracleConnection connection = new OracleConnection(connectionString))
    {
        OracleCommand command = new OracleCommand(queryString);
        command.Connection = connection;
        try
        {
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}

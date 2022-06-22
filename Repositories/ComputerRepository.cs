using LabManager.Models;
using LabManager.Database;
using Microsoft.Data.Sqlite;
using Dapper;


namespace LabManager.Repositories;

class ComputerRepository
{
    private DatabaseConfig databaseConfig;
    public ComputerRepository(DatabaseConfig databaseConfig) => this.databaseConfig = databaseConfig;

    public  IEnumerable<Computer> GetAll()
    {
        using var connection = new SqliteConnection(databaseConfig.ConnectionString);
        var computers = connection.Query<Computer>("SELECT * FROM Computers").ToList();

        return computers;
    }

    public Computer GetById (int id)
    {
        using var connection = new SqliteConnection(databaseConfig.ConnectionString);
        var computer = connection.QuerySingle<Computer>("SELECT * FROM Computers WHERE (id = @Id)", new { Id = id });

        return computer;
    }

    public bool existsById(int id)
    {
        var connection = new SqliteConnection(databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT count(id) FROM Computers WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", id);

        var result = Convert.ToBoolean(command.ExecuteScalar());

        return result;
    }

    private Computer readerToComputer(SqliteDataReader reader)
    {
        var computer = new Computer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

        return computer;
    }

    public Computer Save(Computer computer)
    {
        using var connection = new SqliteConnection(databaseConfig.ConnectionString);
        connection.Execute("INSERT INTO Computers VALUES(@id, @ram, @processor)", computer);

        return computer;
    }

    public Computer Update(Computer computer)
    {
        using var connection = new SqliteConnection(databaseConfig.ConnectionString);

        connection.Execute("UPDATE Computers SET ram = @Ram, processor = @Processor WHERE (id = @Id)", computer);

        return computer;
    }

    public void Delete(int id)
    {
        using var connection = new SqliteConnection(databaseConfig.ConnectionString);

        connection.Execute("DELETE FROM Computers WHERE id = $id", new { Id = id });


    }
}

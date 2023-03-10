using Npgsql;

internal class Program
{
    private static void Main(string[] args)
    {
        var cs = "Host=localhost;Username=postgres;Password=ramji;Database=csharpdb";

        using var con = new NpgsqlConnection(cs);
        con.Open();

        while (true)
        {
            Console.WriteLine("Enter 1 for insert the data \nEnter 2 to retrive the data \nEnter 3 for delete the data \nEnter 4 for Update the data \nEnter 'exit' to terminate");

            var inp1 = Console.ReadLine();

            if (inp1 == "exit")
            {
                Console.WriteLine("Good, Bye!");
                break;
            }

            bool isint;

            isint = int.TryParse(inp1, out int inp);

            if (!isint || inp > 4)
            {
                Console.WriteLine("Please Enter the required input");
                continue;
            }
            if (inp == 1)
            {
                var sql = "INSERT INTO students(name, points) VALUES(@name, @points)";
                string? name;
                int points;
                while (true)
                {
                    System.Console.WriteLine("Please Enter Name of student!");
                    name = Console.ReadLine();
                    System.Console.WriteLine("Please Enter Points Scored!");
                    if (!int.TryParse(Console.ReadLine(), out points))
                    {
                        System.Console.WriteLine("Points must be integer");
                        continue;
                    }
                    if (name == null)
                    {
                        System.Console.WriteLine("Name  can't be null");
                        continue;
                    }
                    break;
                }
                using var cmd = new NpgsqlCommand(sql, con);

                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("points", points);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Data inserted");
            }
            if (inp == 2)
            {
                var sql = "SELECT * FROM students";

                using var cmd = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10}");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetInt32(0),-4} {rdr.GetString(1),-10} {rdr.GetInt32(2),10}");
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            if (inp == 3)
            {
                var sql = "DELETE FROM students WHERE id = (@p)";

                System.Console.WriteLine("Please enter the id");

                int id;

                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    System.Console.WriteLine("Not a int");
                }


                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("p", id);
                cmd.ExecuteNonQuery();
            }
            if (inp == 4)
            {
                var sql = "UPDATE students SET name = @name, points = @points WHERE id = @id";
                Console.WriteLine("Please enter the id");

                int id;

                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    System.Console.WriteLine("Not a int");
                }
                string? name;
                int points;
                while (true)
                {
                    System.Console.WriteLine("Please Enter Name of student!");
                    name = Console.ReadLine();
                    System.Console.WriteLine("Please Enter Points Scored!");
                    if (!int.TryParse(Console.ReadLine(), out points))
                    {
                        System.Console.WriteLine("Points must be integer");
                        continue;
                    }
                    if (name == null)
                    {
                        System.Console.WriteLine("Name  can't be null");
                        continue;
                    }
                    break;
                }
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("points", points);

                cmd.ExecuteNonQuery();
                System.Console.WriteLine("Updated Successfully");
            }
        }
    }
}




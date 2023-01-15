namespace EmartWebApi.DAL;
using EmartWebApi.Model;
using MySql.Data.MySqlClient;
public class ProductManager
{
    public static string conString = @"server=localhost;port=3306;user=root;password=swanand@123;database=emart";

    public static List<Product> GetAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string query = @"select * from product";
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["pid"].ToString());

                string name = reader["pname"].ToString();

                double price = double.Parse(reader["price"].ToString());

                Product product = new Product(id, name, price);

                allProducts.Add(product);

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return allProducts;


    }

    public static Product GetProductById(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string query = @"select * from product where pid=" + id;

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int pid = int.Parse(reader["pid"].ToString());

                string name = reader["pname"].ToString();

                double price = double.Parse(reader["price"].ToString());

                Product product = new Product(pid, name, price);

                return product;


            }


        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
        finally
        {
            con.Close();
        }
        return null;

    }

    public static void SaveProduct(Product product)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string str = $"insert into product values('{product.Id}','{product.Name}','{product.Price}')";
            cmd.CommandText = str;

            MySqlDataReader reader = cmd.ExecuteReader();


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static void DeleteProduct(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string str = @"delete from product where pid=" + id;
            cmd.CommandText = str;

            MySqlDataReader reader = cmd.ExecuteReader();

        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
        finally
        {
            con.Close();
        }
    }







}


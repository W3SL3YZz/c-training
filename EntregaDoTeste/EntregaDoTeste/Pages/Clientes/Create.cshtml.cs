using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace EntregaDoTeste.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        public ClientInfo ClientInfo = new ClientInfo();
        public string errorMessage = "";
        public string sucessMessage = "";


        public void OnGet()
        {
        }


        public void OnPost()
        {
            ClientInfo.name = Request.Form["name"];
            ClientInfo.email = Request.Form["email"];
            ClientInfo.phone = Request.Form["phone"];
            ClientInfo.address = Request.Form["address"];

            if (ClientInfo.name.Length == 0 || ClientInfo.email.Length == 0 || ClientInfo.phone.Length == 0 || ClientInfo.address.Length == 0)
            {
                errorMessage = "Preencha todos os campos.";
                return;
            }

            // Salvando o cliente na base

            try
            {
                string connectionString = "Data Source=.\\SQLSERVER;Initial Catalog=EntregaFinal;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients " +
                        "(name, email, phone, address) VALUES " +
                        "(@name, @email, @phone, @address);";
                    
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", ClientInfo.name);
                        command.Parameters.AddWithValue("@email", ClientInfo.email);   
                        command.Parameters.AddWithValue("@phone", ClientInfo.phone);
                        command.Parameters.AddWithValue("@address", ClientInfo.address);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            ClientInfo.name = "";
            ClientInfo.email = "";
            ClientInfo.phone = "";
            ClientInfo.address = "";

            sucessMessage = "Cliente adicionado com sucesso!";

            Response.Redirect("/Clientes/Index");
        }
    }
}

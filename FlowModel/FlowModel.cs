using System;
using System.Windows.Forms;
using Npgsql;

namespace FlowModel
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            string connString = @"Host=127.0.0.1;Username=postgres;Password=IFSP;Database=FLOWMODEL";
            
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nome = "Entidade";
                    int x = 100, y = 100;

                    cmd.CommandText = "INSERT INTO Entidade VALUES(@nome, @x, @y)";

                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("x", x);
                    cmd.Parameters.AddWithValue("y", y);

                    cmd.ExecuteNonQuery();
                }
            } 
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaDeLoad());
            Application.Run(new EditPanel());

        }
    }
}

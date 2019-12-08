using Npgsql;
using System.Collections.Generic;

namespace FlowModel.Classes
{
    class Banco
    {
        public static bool SalvarProjeto(List<Desenho> figuras, string nomeProjeto)
        {
            List<Entidade> entidades = new List<Entidade>();
            List<Relacionamento> relacionamentos = new List<Relacionamento>();
            List<Atributo> atributos = new List<Atributo>();
            List<Padronizacao> padronizacaos = new List<Padronizacao>();
            List<Especializacao> especializacaos = new List<Especializacao>();

            foreach (Desenho i in figuras)
            {
                switch (i.QuemSou())
                {
                    case "Entidade":
                        entidades.Add((Entidade)i);
                        break;
                    case "Relacionamento":
                        relacionamentos.Add((Relacionamento)i);
                        break;
                    case "Atributo":
                        atributos.Add((Atributo)i);
                        break;
                    case "Padronizacao":
                        padronizacaos.Add((Padronizacao)i);
                        break;
                    case "Especializacao":
                        especializacaos.Add((Especializacao)i);
                        break;
                }
            }
            string connString = @"Host=127.0.0.1;Username=postgres;Password=230276;Database=Interdiciplinar";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nomeProject = nomeProjeto;
                    cmd.CommandText = "Drop table PROJETO CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Entidade CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Relacionamento CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Cardinalidade CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Atributo CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Padronizacao CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Drop table Especializacao CASCADE";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "COMMIT;";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE PROJETO" +
                    "(" +
                    "	nome varchar(255)" +
                    ");" +
                    "CREATE TABLE Entidade(" +
                    "    	ID serial Primary Key," +
                    "    	Nome varchar(255) NOT NULL," +
                    "    	x integer NOT NULL," +
                    "    	y integer NOT NULL," +
                    "		qtdAtributos integer NOT NULL" +
                    ");" +
                    "" +
                    "CREATE TABLE Relacionamento(" +
                    "    	ID serial Primary Key," +
                    "    	Nome varchar(255) NOT NULL," +
                    "	x integer NOT NULL," +
                    "	y integer NOT NULL," +
                    "	qtdAtributos integer NOT NULL," +
                    "	qtdEnv integer NOT NULL," +
                    "	idEntidade1 integer NOT NULL," +
                    "	idEntidade2 integer," +
                    "	idEntidade3 integer" +
                    ");" +
                    "" +
                    "CREATE TABLE Cardinalidade(" +
                    "    	ID serial Primary Key," +
                    "    	cardMin varchar(1) NOT NULL," +
                    "	cardMax varchar(1) NOT NULL," +
                    "	x integer NOT NULL," +
                    "	y integer NOT NULL," +
                    "	IdRelacionamento integer," +
                    "	FOREIGN KEY (IdRelacionamento) REFERENCES Relacionamento(ID)" +
                    ");" +
                    "" +
                    "CREATE TABLE Atributo(	" +
                    "	ID serial Primary Key," +
                    "	Nome varchar(255) NOT NULL," +
                    "	x integer NOT NULL," +
                    "	y integer NOT NULL," +
                    "	indice integer NOT NULL," +
                    "	qtdAtributos integer NOT NULL," +
                    "	dado integer NOT NULL," +
                    "	propriedades varchar(20) NOT NULL," +
                    "	ID_Proprietario integer NOT NULL," +
                    "	Tipo_Proprietario varchar(15) NOT NULL" +
                    ");" +
                    "" +
                    "CREATE TABLE Padronizacao(" +
                    "    	ID serial Primary Key," +
                    "    	Nome varchar(255) NOT NULL," +
                    "    	x integer NOT NULL," +
                    "    	y integer NOT NULL," +
                    "	Padrao integer NOT NULL," +
                    "	List varchar(60) NOT NULL" +
                    ");" +
                    "CREATE TABLE Especializacao(" +
                    "    	ID serial Primary Key," +
                    "    	Nome varchar(255) NOT NULL," +
                    "    	x integer NOT NULL," +
                    "    	y integer NOT NULL," +
                    "	Especial integer NOT NULL," +
                    "	List varchar(60) NOT NULL" +
                    ");";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "COMMIT;";
                    cmd.ExecuteNonQuery();

                }
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nomeProject = nomeProjeto;
                    cmd.CommandText = "INSERT INTO PROJETO VALUES(@nome)";

                    cmd.Parameters.AddWithValue("nome", nomeProject);
                    cmd.ExecuteNonQuery();
                }
                string nome = "";
                int x = 0;
                int y = 0;
                int qtd = 0;
                int qtdEnv = 0;

                foreach (Entidade salva in entidades)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                        nome = salva.GetName();
                        x = salva.GetX();
                        y = salva.GetY();
                        qtd = salva.GetQtdAtributos();

                        cmd.CommandText = "INSERT INTO Entidade (Nome, x, y, qtdAtributos)" +
                            " VALUES(@nome, @x, @y, @qtdAtributos)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                        cmd.ExecuteNonQuery();
                    }
                }
                int i = 0;
                foreach (Relacionamento salva in relacionamentos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {

                        cmd.Connection = conn;

                        nome = salva.GetName();
                        x = salva.GetX();
                        y = salva.GetY();
                        qtd = salva.getQtdAtributos();
                        qtdEnv = salva.getQtdEnvolvidos();
                        List<Entidade> envs = salva.getEnvolvidos();
                        if (qtdEnv == 1)
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.ExecuteNonQuery();
                        }
                        else if (qtdEnv == 2)
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);
                            int entidade2 = entidades.IndexOf(envs[1]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1, idEntidade2)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1, @idEntidade2)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.Parameters.AddWithValue("idEntidade2", entidade2);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);
                            int entidade2 = entidades.IndexOf(envs[1]);
                            int entidade3 = entidades.IndexOf(envs[2]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1, idEntidade2, idEntidade3)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1, @idEntidade2, @idEntidade3)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.Parameters.AddWithValue("idEntidade2", entidade2);
                            cmd.Parameters.AddWithValue("idEntidade3", entidade3);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    foreach (Cardinalidade card in salva.getCards())
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;

                            string cardMin = card.getCardMin();
                            string cardMax = card.getCardMax();

                            x = card.GetX();
                            y = card.GetY();

                            int idRelacionamento = i;
                            List<Entidade> envs = salva.getEnvolvidos();
                            if (qtdEnv == 1)
                            {
                                int entidade1 = 0;
                                entidade1 = entidades.IndexOf(envs[0]);

                                cmd.CommandText = "INSERT INTO Cardinalidade (cardMin, cardMax,x, y, IdRelacionamento)" +
                                    " VALUES(@cardMin, @cardMax, @x, @y, @IdRelacionamento)";

                                cmd.Parameters.AddWithValue("cardMin", cardMin);
                                cmd.Parameters.AddWithValue("cardMax", cardMax);
                                cmd.Parameters.AddWithValue("x", x);
                                cmd.Parameters.AddWithValue("y", y);
                                cmd.Parameters.AddWithValue("IdRelacionamento", idRelacionamento);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    i++;
                }
                foreach (Padronizacao p in padronizacaos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = p.GetName();
                        x = p.GetX();
                        y = p.GetY();
                        int padrao = entidades.IndexOf(p.GetEntidadePadrao());
                        string list = "";
                        foreach (Entidade g in p.GetEntidades())
                        {
                            list += entidades.IndexOf(g);
                            list += ";";
                        }
                        cmd.CommandText = "INSERT INTO Padronizacao (Nome, x, y, Padrao, List)" +
                            " VALUES(@nome, @x, @y, @Padrao, @List)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("Padrao", padrao);
                        cmd.Parameters.AddWithValue("List", list);
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (Especializacao t in especializacaos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = t.GetName();
                        x = t.GetX();
                        y = t.GetY();
                        int espec = entidades.IndexOf(t.getEntidadeEspecializada());
                        string list = "";
                        foreach (Entidade g in t.getEntidades())
                        {
                            list += entidades.IndexOf(g);
                            list += ";";
                        }
                        cmd.CommandText = "INSERT INTO Especializacao (Nome, x, y, Especial, List)" +
                            " VALUES(@nome, @x, @y, @Especial, @List)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("Especial", espec);
                        cmd.Parameters.AddWithValue("List", list);
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (Atributo a in atributos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = a.GetName();
                        x = a.GetX();
                        y = a.GetY();
                        int indice = a.GetIndice();
                        int qtdAtributos = a.GetQtdAtributos();
                        int dado = a.GetIntDado();
                        string propriedades = "";
                        foreach (int prop in a.GetPropriedade())
                        {
                            propriedades += prop + ";";
                        }
                        string Tipo_Proprietario = a.GetProprietario().QuemSou();
                        int ID_Proprietario = 0;
                        switch (Tipo_Proprietario)
                        {
                            case "Entidade":
                                ID_Proprietario = entidades.IndexOf((Entidade)a.GetProprietario());
                                break;
                            case "Relacionamento":
                                ID_Proprietario = relacionamentos.IndexOf((Relacionamento)a.GetProprietario());
                                break;
                            case "Atributo":
                                ID_Proprietario = atributos.IndexOf((Atributo)a.GetProprietario());
                                break;
                        }

                        cmd.CommandText = "INSERT INTO Atributo (Nome, x, y, indice, qtdAtributos, dado, propriedades, ID_Proprietario, Tipo_Proprietario)" +
                            " VALUES(@nome, @x, @y, @indice, @qtdAtributos, @dado, @propriedades, @ID_Proprietario, @Tipo_Proprietario)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("indice", indice);

                        cmd.Parameters.AddWithValue("qtdAtributos", qtdAtributos);
                        cmd.Parameters.AddWithValue("dado", dado);
                        cmd.Parameters.AddWithValue("propriedades", propriedades);
                        cmd.Parameters.AddWithValue("ID_Proprietario", ID_Proprietario);
                        cmd.Parameters.AddWithValue("Tipo_Proprietario", Tipo_Proprietario);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
        }
    }
}

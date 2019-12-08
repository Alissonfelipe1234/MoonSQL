using System.Collections.Generic;

namespace FlowModel.Classes
{
    class Gerador
    {
        public static string SQL(string Nome, List<Desenho> figuras)
        {
            string sqlGerado = "Create Database " + Nome + ";\nUSE " + Nome + ";\n";
            Dictionary<Entidade, string> sql = new Dictionary<Entidade, string>();
            Dictionary<Desenho, string> tablesAltenative = new Dictionary<Desenho, string>();
            Dictionary<Entidade, Atributo> PK = new Dictionary<Entidade, Atributo>();
            foreach (Desenho d in figuras)
            {
                if (d.QuemSou() == "Entidade")
                {

                    Entidade ent = (Entidade)d;
                    sql.Add(ent, "Create Table " + ent.GetName() + " (\n");
                }
            }
            foreach (Desenho a in figuras)
            {
                if (a.QuemSou() == "Atributo")
                {
                    Atributo atributo = (Atributo)a;
                    if (atributo.GetProprietario().QuemSou() == "Entidade")
                    {
                        if (atributo.GetPropriedade()[0] == 1)
                        {
                            try
                            {
                                PK.Add((Entidade)atributo.GetProprietario(), atributo);
                            }
                            catch { }
                        }
                        if (atributo.GetCardMax() == 1)
                        {
                            Entidade EntidadeAtributo = (Entidade)atributo.GetProprietario();
                            sql[EntidadeAtributo] += atributo.GetSql();
                            if (atributo.GetIndice() + 1 != EntidadeAtributo.GetQtdAtributos())
                                sql[EntidadeAtributo] += ",\n";
                        }
                        else
                        {
                            Entidade EntidadeAtributoMValorado = (Entidade)atributo.GetProprietario();
                            string nome = atributo.GetName().Split(' ')[0];
                            sql[EntidadeAtributoMValorado] += nome + "FK integer";
                            if (atributo.GetCardMin() != 0)
                                sql[EntidadeAtributoMValorado] += " NOT NULL";
                            if (atributo.GetIndice() + 1 != EntidadeAtributoMValorado.GetQtdAtributos())
                                sql[EntidadeAtributoMValorado] += ",\n";

                            tablesAltenative.Add(atributo, "Create Table " + nome + " (\n");
                            tablesAltenative[atributo] += "ID" + nome + " serial Primary Key,\n";
                            tablesAltenative[atributo] += atributo.GetSql() + ",\n";
                            tablesAltenative[atributo] += EntidadeAtributoMValorado.GetName() + "FK integer,\n";
                            tablesAltenative[atributo] += "CONSTRAINT " + nome + "_" + EntidadeAtributoMValorado.GetName() + " FOREIGN KEY(FK" + EntidadeAtributoMValorado.GetName() + ")\n";
                            tablesAltenative[atributo] += "REFERENCES " + EntidadeAtributoMValorado.GetName() + "(" + nome + "FK)\n)";
                            tablesAltenative[atributo] += ");";
                        }
                    }
                }
            }
            foreach (Desenho a in figuras)
            {
                if (a.QuemSou() == "Relacionamento")
                {
                    Relacionamento relacionamento = (Relacionamento)a;
                    int envolvidos = relacionamento.getQtdEnvolvidos();
                    switch (envolvidos)
                    {
                        case 1:
                            Entidade dono = relacionamento.getEnvolvidos()[0];
                            if (PK.ContainsKey(dono))
                            {
                                if (dono.GetQtdAtributos() > 0)
                                    sql[dono] += ",\n" + dono.GetName() + "ID Integer PRIMARY KEY";
                                else
                                    sql[dono] += dono.GetName() + "ID Integer PRIMARY KEY";
                            }

                            sql[dono] += ",\n" + relacionamento.GetName();
                            if (relacionamento.getCards()[0].getCardMin().Equals("1"))
                                sql[dono] += " NOT NULL";
                            try { sql[dono] += " FOREIGN KEY REFERENCES " + dono.GetName() + "(" + PK[dono].GetName() + ")"; }
                            catch { sql[dono] += " FOREIGN KEY REFERENCES " + dono.GetName() + "(" + dono.GetName() + "ID  )"; }
                            break;
                        case 2:
                            Entidade dono1 = relacionamento.getEnvolvidos()[0];
                            Entidade dono2 = relacionamento.getEnvolvidos()[1];
                            Cardinalidade card1 = relacionamento.getCards()[0];
                            Cardinalidade card2 = relacionamento.getCards()[1];
                            if (card1.getCardMax().Equals("1") && card2.getCardMax().Equals("1"))
                            {
                                if (card1.getCardMin().Equals("1"))
                                {
                                    if (dono1.GetQtdAtributos() > 0)
                                        sql[dono1] += ",\n" + dono2.GetName() + " Integer";
                                    else
                                        sql[dono1] += dono2.GetName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono1] += " NOT NULL";
                                    try { sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.GetName() + "(" + PK[dono2].GetName() + ")"; }
                                    catch
                                    {
                                        sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.GetName() + "(" + dono2.GetName() + "ID  )";
                                        if (dono2.GetQtdAtributos() > 0)
                                            sql[dono2] += ",\n" + dono2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono2] += dono2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono1] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.GetProprietario() == relacionamento)
                                                {
                                                    sql[dono1] += possivel.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dono2.GetQtdAtributos() > 0)
                                        sql[dono2] += ",\n" + dono1.GetName() + " Integer";
                                    else
                                        sql[dono2] += dono1.GetName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono2] += " NOT NULL";
                                    try { sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.GetName() + "(" + PK[dono1].GetName() + ")"; }
                                    catch
                                    {
                                        sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.GetName() + "(" + dono1.GetName() + "ID  )";
                                        if (dono1.GetQtdAtributos() > 0)
                                            sql[dono1] += ",\n" + dono1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono1] += dono1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono2] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.GetProprietario() == relacionamento)
                                                {
                                                    sql[dono2] += possivel.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono2] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else if (!card1.getCardMax().Equals(card2.getCardMax()))
                            {
                                if (card1.getCardMax().Equals("N"))
                                {
                                    sql[dono1] += ",\n" + dono2.GetName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono1] += " NOT NULL";
                                    try { sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.GetName() + "(" + PK[dono2].GetName() + ")"; }
                                    catch
                                    {

                                        sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.GetName() + "(" + dono2.GetName() + "ID  )";
                                        if (dono2.GetQtdAtributos() > 0)
                                            sql[dono2] += ",\n" + dono2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono2] += dono2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono1] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.GetProprietario() == relacionamento)
                                                {
                                                    sql[dono1] += possivel.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    sql[dono2] += ",\n" + dono1.GetName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono2] += " NOT NULL";
                                    try { sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.GetName() + "(" + PK[dono1].GetName() + ")"; }
                                    catch
                                    {
                                        sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.GetName() + "(" + dono1.GetName() + "ID  )";
                                        if (dono1.GetQtdAtributos() > 0)
                                            sql[dono1] += ",\n" + dono1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono1] += dono1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono2] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.GetProprietario() == relacionamento)
                                                {
                                                    sql[dono2] += possivel.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono2] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.GetName() + " (\n");
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[dono1].GetSql() + ",\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += dono1.GetName() + "ID  integer,\n";
                                    PK.Add(dono1, new Atributo(dono1.GetName() + "ID", -50, -50, (Desenho)dono1));
                                    if (dono1.GetQtdAtributos() > 0)
                                        sql[dono1] += ",\n" + dono1.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[dono1] += dono1.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[dono2].GetSql();
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += dono2.GetName() + "ID  integer";
                                    PK.Add(dono2, new Atributo(dono2.GetName() + "ID", -50, -50, (Desenho)dono2));
                                    if (dono1.GetQtdAtributos() > 0)
                                        sql[dono2] += ",\n" + dono2.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[dono2] += dono2.GetName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relacionamento.getQtdAtributos();
                                if (atr > 0)
                                {
                                    foreach (Desenho f in figuras)
                                    {

                                        if (f.QuemSou().Equals("Atributo"))
                                        {
                                            Atributo possivel = (Atributo)f;
                                            if (possivel.GetProprietario() == relacionamento)
                                            {
                                                tablesAltenative[relacionamento] += ",\n";
                                                tablesAltenative[relacionamento] += possivel.GetSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relacionamento] += ",\n";
                                                else
                                                    break;

                                            }
                                        }
                                    }
                                }
                                tablesAltenative[relacionamento] += ",\nPRIMARY KEY (" + PK[dono1].GetName() + ", " + PK[dono2].GetName() + "),\n";
                                tablesAltenative[relacionamento] += "CONTRAINT " + relacionamento.GetName() + "FK1 FOREIGN KEY (" + PK[dono1].GetName() + ")\n";
                                tablesAltenative[relacionamento] += "REFERENCES " + dono1.GetName() + " (" + PK[dono1].GetName() + "),\n";
                                tablesAltenative[relacionamento] += "CONTRAINT " + relacionamento.GetName() + "FK2 FOREIGN KEY (" + PK[dono2].GetName() + ")\n";
                                tablesAltenative[relacionamento] += "REFERENCES " + dono2.GetName() + " (" + PK[dono2].GetName() + ")";
                            }
                            break;
                        case 3:
                            Entidade tern1 = relacionamento.getEnvolvidos()[0];
                            Entidade tern2 = relacionamento.getEnvolvidos()[1];
                            Entidade tern3 = relacionamento.getEnvolvidos()[2];
                            Cardinalidade carT1 = relacionamento.getCards()[0];
                            Cardinalidade carT2 = relacionamento.getCards()[1];
                            Cardinalidade carT3 = relacionamento.getCards()[2];
                            //caso 1:1:1 OR N:N:N
                            if (carT1.getCardMax() == carT2.getCardMax() && carT1.getCardMax() == carT3.getCardMax())
                            {
                                tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.GetName() + " (\n");
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern1].GetSql() + " FOREIGN KEY REFERENCES " + tern1.GetName() +
                                        "(" + PK[tern1].GetName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern1.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern1.GetName() +
                                        "(" + tern1.GetName() + "ID),\n";
                                    PK.Add(tern1, new Atributo(tern1.GetName() + "ID", -50, -50, (Desenho)tern1));
                                    if (tern1.GetQtdAtributos() > 0)
                                        sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern2].GetSql() + " FOREIGN KEY REFERENCES " + tern2.GetName() +
                                        "(" + PK[tern2].GetName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern2.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern2.GetName() +
                                        "(" + tern2.GetName() + "ID),\n";
                                    PK.Add(tern2, new Atributo(tern2.GetName() + "ID", -50, -50, (Desenho)tern2));
                                    if (tern2.GetQtdAtributos() > 0)
                                        sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern3].GetSql() + " FOREIGN KEY REFERENCES " + tern3.GetName() +
                                        "(" + PK[tern3].GetName() + ")";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern3.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern3.GetName() +
                                        "(" + tern3.GetName() + "ID)";
                                    PK.Add(tern3, new Atributo(tern3.GetName() + "ID", -50, -50, (Desenho)tern3));
                                    sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relacionamento.getQtdAtributos();
                                if (atr > 0)
                                {
                                    tablesAltenative[relacionamento] += ",\n";
                                    foreach (Desenho f in figuras)
                                    {
                                        if (f.QuemSou().Equals("Atributo"))
                                        {
                                            Atributo possivel = (Atributo)f;
                                            if (possivel.GetProprietario() == relacionamento)
                                            {
                                                tablesAltenative[relacionamento] += possivel.GetSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relacionamento] += ",\n";
                                                else
                                                    break;

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                int qtdN = 0;
                                if (carT1.getCardMax() == "N")
                                    qtdN++;
                                if (carT2.getCardMax() == "N")
                                    qtdN++;
                                if (carT3.getCardMax() == "N")
                                    qtdN++;
                                if (qtdN == 2)
                                {
                                    tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.GetName() + " (\n");
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern1].GetName() + " " + PK[tern1].GetIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern1.GetName() +
                                            "(" + PK[tern1].GetName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern1.GetName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern1.GetName() +
                                            "(" + tern1.GetName() + "ID),\n";
                                        PK.Add(tern1, new Atributo(tern1.GetName() + "ID", -50, -50, (Desenho)tern1));
                                        if (tern1.GetQtdAtributos() > 0)
                                            sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern2].GetName() + " " + PK[tern2].GetIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern2.GetName() +
                                            "(" + PK[tern2].GetName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern2.GetName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern2.GetName() +
                                            "(" + tern2.GetName() + "ID),\n";
                                        PK.Add(tern2, new Atributo(tern2.GetName() + "ID", -50, -50, (Desenho)tern2));
                                        if (tern2.GetQtdAtributos() > 0)
                                            sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern3].GetName() + " " + PK[tern3].GetIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern3.GetName() +
                                            "(" + PK[tern3].GetName() + ")";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern3.GetName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern3.GetName() +
                                            "(" + tern3.GetName() + "ID)";
                                        PK.Add(tern3, new Atributo(tern3.GetName() + "ID", -50, -50, (Desenho)tern3));
                                        if (tern3.GetQtdAtributos() > 0)
                                            sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        tablesAltenative[relacionamento] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.GetProprietario() == relacionamento)
                                                {
                                                    tablesAltenative[relacionamento] += possivel.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        tablesAltenative[relacionamento] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (carT1.getCardMax() == "N")
                                    {
                                        if (tern1.GetQtdAtributos() > 0)
                                            sql[tern1] += ",\n";
                                        try
                                        {
                                            sql[tern1] += PK[tern2].GetName() + "FK FOREIGN KEY REFERENCES " + tern2.GetName() +
                                                "(" + PK[tern2].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern2.GetName() + "ID  integer FOREIGN " + tern2.GetName() +
                                                "(" + tern2.GetName() + "ID),\n";
                                            PK.Add(tern2, new Atributo(tern2.GetName() + "ID", -50, -50, (Desenho)tern2));
                                            if (tern2.GetQtdAtributos() > 0)
                                                sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern1] += PK[tern3].GetName() + "FK FOREIGN KEY REFERENCES " + tern3.GetName() +
                                                "(" + PK[tern3].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern3.GetName() + "ID  integer FOREIGN " + tern3.GetName() +
                                                "(" + tern3.GetName() + "ID)";
                                            PK.Add(tern3, new Atributo(tern3.GetName() + "ID", -50, -50, (Desenho)tern3));
                                            if (tern3.GetQtdAtributos() > 0)
                                                sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern1] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.GetProprietario() == relacionamento)
                                                    {
                                                        sql[tern1] += possivel.GetSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern1] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (carT2.getCardMax() == "N")
                                    {
                                        if (tern2.GetQtdAtributos() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern2] += PK[tern1].GetName() + "FK FOREIGN KEY REFERENCES " + tern1.GetName() +
                                                "(" + PK[tern1].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern1.GetName() + "ID  integer FOREIGN " + tern1.GetName() +
                                                "(" + tern1.GetName() + "ID),\n";
                                            PK.Add(tern1, new Atributo(tern1.GetName() + "ID", -50, -50, (Desenho)tern1));
                                            if (tern1.GetQtdAtributos() > 0)
                                                sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern2] += PK[tern3].GetName() + "FK FOREIGN KEY REFERENCES " + tern3.GetName() +
                                                "(" + PK[tern3].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern3.GetName() + "ID  integer FOREIGN " + tern3.GetName() +
                                                "(" + tern3.GetName() + "ID)";
                                            PK.Add(tern3, new Atributo(tern3.GetName() + "ID", -50, -50, (Desenho)tern3));
                                            if (tern3.GetQtdAtributos() > 0)
                                                sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern2] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.GetProprietario() == relacionamento)
                                                    {
                                                        sql[tern2] += possivel.GetSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern2] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (tern2.GetQtdAtributos() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern3] += PK[tern1].GetName() + "FK FOREIGN KEY REFERENCES " + tern1.GetName() +
                                                "(" + PK[tern1].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern1.GetName() + "ID  integer FOREIGN " + tern1.GetName() +
                                                "(" + tern1.GetName() + "ID),\n";
                                            PK.Add(tern1, new Atributo(tern1.GetName() + "ID", -50, -50, (Desenho)tern1));
                                            if (tern1.GetQtdAtributos() > 0)
                                                sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern3] += PK[tern2].GetName() + "FK FOREIGN KEY REFERENCES " + tern2.GetName() +
                                                "(" + PK[tern2].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern2.GetName() + "ID  integer FOREIGN " + tern2.GetName() +
                                                "(" + tern2.GetName() + "ID)";
                                            PK.Add(tern2, new Atributo(tern2.GetName() + "ID", -50, -50, (Desenho)tern2));
                                            if (tern2.GetQtdAtributos() > 0)
                                                sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern3] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.GetProprietario() == relacionamento)
                                                    {
                                                        sql[tern3] += possivel.GetSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern3] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            foreach (KeyValuePair<Entidade, string> linha in sql)
                sqlGerado += linha.Value + "\n);\n";
            foreach (KeyValuePair<Desenho, string> linha in tablesAltenative)
                sqlGerado += linha.Value + "\n);\n";

            return sqlGerado;
        }
    }
}

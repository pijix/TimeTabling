using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using TimeTabling.Core;
using TimeTabling.Core.Contracts.DAL;

namespace TimeTabling.DAL
{
    public class AulaDAO : IAula
    {
        private readonly SqlConnection _sqlCon;
        
        public AulaDAO(string conStr)
        {
            _sqlCon = new SqlConnection(conStr);
            _sqlCon.Open();
        }

        public int AddAula(Aula aula)
        {
            var cmd = new SqlCommand("INSERT INTO Aulas VALUES (@codigo, @descripcion, @soft, @tipoAula)", _sqlCon);
            cmd.Parameters.Add(new SqlParameter("@codigo", aula.AulaC));
            cmd.Parameters.Add(new SqlParameter("@descripcion", aula.AulaD));
            cmd.Parameters.Add(new SqlParameter("@tipoAula", aula.TipoAula));
            cmd.Parameters.Add(new SqlParameter("@soft", aula.SoftDisponible));
            return cmd.ExecuteNonQuery();
        }

        public int DeleteAula(string aulaC)
        {
            var cmd = new SqlCommand("DELETE FROM Aulas WHERE AulaC = @codigo", _sqlCon);
            var pCodigo = new SqlParameter("@codigo", aulaC);
            cmd.Parameters.Add(pCodigo);
            return cmd.ExecuteNonQuery();
        }

        public int EditAula(Aula aula)
        {
            var cmd =
                new SqlCommand(
                    "UPDATE Aulas SET AulaD=@descripcion, TipoAula=@tipoAula, SoftDisponible=@soft WHERE AulaC=@codigo", _sqlCon);
            cmd.Parameters.Add(new SqlParameter("@codigo", aula.AulaC));
            cmd.Parameters.Add(new SqlParameter("@descripcion", aula.AulaD));
            cmd.Parameters.Add(new SqlParameter("@tipoAula", aula.TipoAula));
            cmd.Parameters.Add(new SqlParameter("@soft", aula.SoftDisponible));
            return cmd.ExecuteNonQuery();
        }

        public List<Aula> Aulas()
        {
            var res = new List<Aula>();
            var cmd = new SqlCommand("SELECT * FROM Aulas", _sqlCon);
            var da = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            da.Fill(ds, "Aulas");
            foreach (DataRow row in ds.Tables["Aulas"].Rows)
            {
                res.Add(new Aula()
                {
                    AulaC = row["AulaC"].ToString(),
                    AulaD = row["AulaD"].ToString(),
                    SoftDisponible = (bool) row["SoftDisponible"],
                    TipoAula = row["TipoAula"].ToString()
                });
            }
            return res;
        }

        public Aula Aula(string aulaC)
        {

            var cmd = new SqlCommand("SELECT * FROM Aulas WHERE AulaC=@codigo", _sqlCon);
            cmd.Parameters.Add(new SqlParameter("@codigo", aulaC));
            var da = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            da.Fill(ds, "Aulas");
            var dataRows = ds.Tables["Aulas"].Rows;
            
            if (dataRows == null) return null;
            
            var row = dataRows[0];
            return new Aula()
            {
                AulaC = row["AulaC"].ToString(),
                AulaD = row["AulaD"].ToString(),
                SoftDisponible = (bool) row["SoftDisponible"],
                TipoAula = row["TipoAula"].ToString()
            };
        }
    }
}

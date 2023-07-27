using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zoologic_Karen
{
    internal class ConexionMaestra_Karen
    {
        static string server_karen = "DESKTOP-H6JLLO5";
        static string basedatos_karen = "Zoologic_Karen";
        static string seguridad_karen = "true";
        static string user_karen = "SA";
        static string password_karen = "akaren08";
        static string cadena_karen = "DATA SOURCE=" + server_karen + "; DATABASE=" + basedatos_karen + "; Integrated security=" + seguridad_karen + "; USER ID=" + user_karen + "; PASSWORD=" + password_karen;

        public static SqlConnection conectar_karen = new SqlConnection(cadena_karen);
        //Linea sera para realizar calquier linea de consulta SQL
        public static SqlCommand consulta_karen;
        //Permite almacenar y acceder temporamente al resultado de una consulta SQL
        public static SqlDataReader leer_karen;

        DataSet cuadricula_karen = new DataSet();
        DataSet lista_karen = new DataSet();

        public static void abrir_karen()
        {
            if (conectar_karen.State == ConnectionState.Closed)
            {
                conectar_karen.Open();
                consulta_karen = new SqlCommand();
                consulta_karen.Connection = conectar_karen;
            }
        }
        public static void Karen_Ejecutar(string Karen_SQL)
        {
            consulta_karen.CommandType = System.Data.CommandType.Text;
            consulta_karen.CommandText = Karen_SQL;
            leer_karen = consulta_karen.ExecuteReader();
        }

        public static void Karen_llenaCombo(ComboBox Karen_Combo, string KarenSQL)
        {
            Karen_Ejecutar(KarenSQL);
            leer_karen.Close();
            leer_karen = consulta_karen.ExecuteReader();
            Karen_Combo.Items.Clear();
            Karen_Combo.Items.Add("--Seleccione--");
            while (leer_karen.Read())
            {
                Karen_Combo.Items.Add(leer_karen[0]);
            }
            leer_karen.Close();
        }

        public static void Karen_llenaText(TextBox Karen_Text, string KarenSQL)
        {
            Karen_Ejecutar(KarenSQL);
            leer_karen.Close();
            leer_karen = consulta_karen.ExecuteReader();
            leer_karen.Close();
        }
        public static void grid(DataGridView tabla, String sql)
        {
            Karen_Ejecutar(sql);
            leer_karen.Close();
            DataSet cuadricula_karen = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_karen);
            adaptador.Fill(cuadricula_karen, "datos");
            tabla.DataSource = cuadricula_karen;
            tabla.DataMember = "datos";
            cuadricula_karen.AcceptChanges();
        }

        public static void Karen_llenaCheck(CheckedListBox Karen_Ch, string KarenSQL)
        {
            Karen_Ejecutar(KarenSQL);
            leer_karen = consulta_karen.ExecuteReader();
            Karen_Ch.Items.Clear();
            while (leer_karen.Read())
            {
                Karen_Ch.Items.Add(leer_karen[0]);
            }
            leer_karen.Close();
        }

        public static void Karen_llenaGrid(DataGridView grid_karen, string KarenSQL)
        {
            Karen_Ejecutar(KarenSQL);
            leer_karen.Close();
            leer_karen = consulta_karen.ExecuteReader();
            while (leer_karen.Read())
            {
                grid_karen.Rows.Add(leer_karen[0]);
            }
            leer_karen.Close();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DesktopInventarisAlat
{
    class DB
    {
        public static MySqlConnection koneksi = new MySqlConnection("server = 127.0.0.1; username = 'root'; password = ''; database = 'inventaris_desktop'");
        public static DataSet ds = new DataSet();
        public static IDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string kuerinya)
        {
            Console.WriteLine(kuerinya);
            ds.Tables.Clear();
            perintah = new MySqlCommand(kuerinya, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}

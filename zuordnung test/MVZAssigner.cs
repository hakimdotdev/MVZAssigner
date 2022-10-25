using CryptSharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Windows.Forms;

namespace zuordnung_test
{
    public partial class MVZAssigner : MaterialForm
    {
        private static readonly Random random = new Random();

        public MVZAssigner()
        {
            InitializeComponent();
            // Theme Optionen der Material Library
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.BlueGrey900, Accent.LightBlue700, TextShade.WHITE);
        }

        public static Random Random => random;
        public static string RandomString(int laenge)
        {
            string Buchstaben = "abcdefghijklmnopqrstuvxyz1234567890";
            return new string(Enumerable.Repeat(Buchstaben, laenge)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }



        //
        // Data Reset
        //
        private void ClearData()
        {
            txtRootPath.Text = null;
            materialSingleLineTextField2.Text = null;
            materialSingleLineTextField3.Text = null;

        }
        //
        //Generieren
        //
        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //Stammdaten
                string NachVorname = name.Text;
                string benutzername = name.Text.Substring(0, 4);
                string Passwort = RandomString(5);
                // Ma_id für Namenskonvention formatieren
                string MAidPadded = Convert.ToDecimal(maid.Text).ToString("0000#");
                //
                //Pfade
                //
                string PfadMAOrdner = txtRootPath.Text;
                string Pfadhtpasswdshare = materialSingleLineTextField2.Text;
                //Unix / Ultimativer .htpasswd Pfad
                string datahtpasswdpfad = materialSingleLineTextField3.Text;
                // Pfad für das Verzeichnis mit Konvention
                string genmadirpfad = $@"{PfadMAOrdner}\{NachVorname}_{MAidPadded}";
                //Daten ausgeben
                if (MessageBox.Show($"Benutzername: {benutzername.ToLower()}Passwort: {Passwort}", "Benutzerdaten") == DialogResult.OK)
                {
                    ClearData();
                }
                //Erstellen des Verzeichnis
                Directory.CreateDirectory(genmadirpfad);
                // Verschlüsseln des Passworts
                string cryptedPassword = Crypter.MD5.Crypt(Passwort, new CrypterOptions()
                {
                {CrypterOption.Variant, MD5CrypterVariant.Apache}
                });
                // Schreiben der .htaccess
                File.AppendAllText(Pfadhtpasswdshare, benutzername.ToLower() + ":" + cryptedPassword + Environment.NewLine);
                string Outputhtaccess = $"AuthType Basic\r\nAuthName \"Passwortgeschützter Bereich\"\r\nAuthUserFile {datahtpasswdpfad}\r\nRequire user {benutzername.ToLower()}";
                // .htaccess Pfad zum Erstellen je Verzeichnis
                string genhtaccesspfad = genmadirpfad + @"\.htaccess";
                File.AppendAllText(genhtaccesspfad, Outputhtaccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }



        }

        //
        //Zuordnen
        //
        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Skript aus Resourcen
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "zuordnung_test.Resources.zuordnung.ps1";
            //Ausführen des PS-Skript
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string skriptpfad = reader.ReadToEnd();
                PowerShell ps = PowerShell.Create();
                //string skriptpfad = $@"C:\zuordnung.ps1";
                ps.AddScript(skriptpfad);
                ps.AddParameter("Source", folderBrowserDialog1.SelectedPath);
                ps.AddParameter("Destination", folderBrowserDialog2.SelectedPath);
                ps.Invoke();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRootPath.Text = folderBrowserDialog1.SelectedPath;

            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtDest.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            htPassSmb.Text = null;
            htPassUnix.Text = null;

        }
        //
        //Generieren
        //
        public void CreateEmp(string Name, string Pass, string Id, string MaVz, string HtPassSmb, string HtPassUnix)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException($"\"{nameof(Name)}\" kann nicht NULL oder leer sein.", nameof(Name));
            }

            if (string.IsNullOrEmpty(Pass))
            {
                throw new ArgumentException($"\"{nameof(Pass)}\" kann nicht NULL oder leer sein.", nameof(Pass));
            }

            if (string.IsNullOrEmpty(Id))
            {
               // Id = Guid.NewGuid();
            }

            if (string.IsNullOrEmpty(HtPassSmb))
            {
                throw new ArgumentException($"\"{nameof(HtPassSmb)}\" kann nicht NULL oder leer sein.", nameof(HtPassSmb));
            }

            if (string.IsNullOrEmpty(HtPassUnix))
            {
                throw new ArgumentException($"\"{nameof(HtPassUnix)}\" kann nicht NULL oder leer sein.", nameof(HtPassUnix));
            }

            try
            {
                string User = name.Text.Substring(0, 4); // Benutzername aus Vollem Namen
                string genmadirpfad = $@"{MaVz}\{Name}_{Id}"; // Pfad für das Verzeichnis mit Konvention
                if (MessageBox.Show($"Benutzername: {User.ToLower()}Passwort: {Pass}", "Benutzerdaten") == DialogResult.OK)
                {
                    ClearData();
                }
                //Erstellen des Verzeichnis
                Directory.CreateDirectory(genmadirpfad);
                // Verschlüsseln des Passworts
                string cryptedPassword = Crypter.MD5.Crypt(Pass, new CrypterOptions()
                {
                    {CrypterOption.Variant, MD5CrypterVariant.Apache}
                });
                File.AppendAllText(HtPassSmb, User.ToLower() + ":" + cryptedPassword + Environment.NewLine); // Schreiben der .htaccess
                string Outputhtaccess = $"AuthType Basic\r\nAuthName \"Passwortgeschützter Bereich\"\r\nAuthUserFile {HtPassUnix}\r\nRequire user {User.ToLower()}";
                // .htaccess Pfad zum Erstellen je Verzeichnis
                string genhtaccesspfad = genmadirpfad + @"\.htaccess";
                File.AppendAllText(genhtaccesspfad, Outputhtaccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        ///
        // Generieren
        //
        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                CreateEmp(name.Text, RandomString(5), maid.Text, txtRootPath.Text, htPassSmb.Text, htPassUnix.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        //
        //Zuordnen
        //
        private void btnAssign_Click(object sender, EventArgs e)
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

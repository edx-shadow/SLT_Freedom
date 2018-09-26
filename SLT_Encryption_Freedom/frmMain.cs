using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;

namespace SLT_Encryption_Freedom
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCrypt_Click(object sender, EventArgs e)
        {
            this.TextBoxImportExport.Lines = new string[]
            {
                RijndaelManagedEncryption.EncryptRijndael(string.Join("\n", this.TextBoxImportExport.Lines))
            };
        }

        private void cmdDecrypt_Click(object sender, EventArgs e)
        {
            if (this.TextBoxImportExport.Lines.Length != 0)
            {
                this.TextBoxImportExport.Lines = RijndaelManagedEncryption.DecryptRijndael(this.TextBoxImportExport.Lines[0]).Split("\n".ToCharArray());
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmdGrabar.Filter = "Text Files (*.TXT)|*.TXT";
                cmdGrabar.FileName = "banlist_encrypted.txt";
                cmdGrabar.InitialDirectory = Application.StartupPath;
                cmdGrabar.ShowDialog();
                StreamWriter SW = new StreamWriter(cmdGrabar.FileName);
                SW.Write(TextBoxImportExport.Text);
                SW.Close();
                MessageBox.Show("File saved!", "Sucessfull", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somethign awful happened: " + ex.Message);
            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("''Created by EDX''", "About");
        }
    }

    public class RijndaelManagedEncryption
    {
        internal const string Inputkey = "8e0f95e4-bd47-49d2-a275-18062e2db797";

        internal const string salt = "PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l";

        public static string EncryptRijndael(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            RijndaelManaged rijndaelManaged = RijndaelManagedEncryption.NewRijndaelManaged("PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l");
            ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
            MemoryStream memoryStream = new MemoryStream();
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(text);
                }
            }
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return base64String.Length % 4 == 0 && Regex.IsMatch(base64String, "^[a-zA-Z0-9\\+/]*={0,3}$", RegexOptions.None);
        }

        public static string DecryptRijndael(string cipherText)
        {
            string result;
            try
            {
                if (string.IsNullOrEmpty(cipherText))
                {
                    return "";
                }
                if (!RijndaelManagedEncryption.IsBase64String(cipherText))
                {
                    throw new Exception("The cipherText input parameter is not base64 encoded.");
                }
                RijndaelManaged rijndaelManaged = RijndaelManagedEncryption.NewRijndaelManaged("PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l");
                ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            result = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to decrypt text, an error occured:\n\n" + ex.Message, "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = "";
            }
            return result;
        }

        private static RijndaelManaged NewRijndaelManaged(string salt)
        {
            if (salt == null)
            {
                throw new ArgumentNullException("salt");
            }
            byte[] bytes = Encoding.ASCII.GetBytes(salt);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("8e0f95e4-bd47-49d2-a275-18062e2db797", bytes);
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
            return rijndaelManaged;
        }
    }
}

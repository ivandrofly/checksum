using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Checksum
{
    public static class Utils
    {
        public static void CheckRegistry()
        {
            string regkey = (string)Registry.GetValue("HKEY_CLASSES_ROOT\\*\\shell\\Checksum\\command", null, null);
            string regIcon = (string)Registry.GetValue("HKEY_CLASSES_ROOT\\*\\shell\\Checksum", "Icon", null);
            if (regkey == null || !regkey.Contains(Application.ExecutablePath))
                Registry.SetValue("HKEY_CLASSES_ROOT\\*\\shell\\Checksum\\command", null, Application.ExecutablePath + " %1");
            if (regIcon == null || regIcon != Application.ExecutablePath)
                Registry.SetValue("HKEY_CLASSES_ROOT\\*\\shell\\Checksum", "Icon", Application.ExecutablePath);
        }

        public static string CalculateMD5Hash(string file)
        {
            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(file))
            {
                byte[] b = md5.ComputeHash(stream);
                stream.Close();
                return BitConverter.ToString(b).Replace("-", "").ToLower();
            }
        }

        public static string CalculateSHA1Hash(string file)
        {
            using (SHA1 sha1 = SHA1.Create())
            using (var stream = File.OpenRead(file))
            {
                byte[] b = sha1.ComputeHash(stream);
                stream.Close();
                return BitConverter.ToString(b).Replace("-", "").ToLower();
            }
        }

        public static string CalculateSHA256Hash(string file)
        {
            using (var sha256 = SHA256.Create())
            using (var stream = File.OpenRead(file))
            {
                byte[] b = sha256.ComputeHash(stream);
                stream.Close();
                return BitConverter.ToString(b).Replace("-", "").ToLower();
            }
        }

        public static string CalculateSHA512Hash(string file)
        {
            using (var sha512 = SHA512.Create())
            using (var stream = File.OpenRead(file))
            {
                byte[] b = sha512.ComputeHash(stream);
                stream.Close();
                return BitConverter.ToString(b).Replace("-", "").ToLower();
            }
        }

        public static string CalculateHash(string file, HashAlgorithm hashAlgo)// where TAlgo : HashAlgorithm
        {
            // todo: crate string basing on Enum-HashAlgorithms
            // HashAlgorithm.Create(hashalgorithms)
            /*using (var hashAlgo = hash)
            {

            }*/
            return string.Empty;
        }
    }
}

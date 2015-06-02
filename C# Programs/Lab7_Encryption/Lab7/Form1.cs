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
using System.IO;
using System.Security;

namespace Lab7
{
    public partial class Form1 : Form
    {
        byte[] encryptKey;
        public Form1()
        {
            InitializeComponent();
            Text = "Luke Poitras - Lab7 File Encrypt/Decrypt";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // Text in the File Name textbox will be the path of file selected.
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "All Files (*.*)|*.*|Encrypted files (*.des)|*.des";
            if(openFileDlg.ShowDialog() == DialogResult.OK)
            {
                openFileText.Text = openFileDlg.FileName;
            }
        }

        private bool PasswordKey()
        {
            // Show error if key string field is empty
            if (this.keyStringText.Text == "")
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // make key string a byte array 
                // if the key is over an index of 8, then add the value of the 9th index to the value of the 0th index, etc.
                encryptKey = new byte[8];
                int index = 0;
                for (int i = 0; i < keyStringText.Text.Length; i++)
                {
                    byte[] ec = encryptKey;
                    ec[index] += (byte)keyStringText.Text[i];
                    index = (index + 1) % 8;
                }
                return true;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string originalKey = openFileText.Text;
            string encKey = originalKey + ".des";
            // Check if returns true
            if(PasswordKey() == true)
            {
                // Check if encrypted file already exists
                // If the encrypted file DNE, make a new one
                if(File.Exists(encKey))
                {
                    if (MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    Encrypt(originalKey, encKey, encryptKey, encryptKey);
                }
            }
        }

        private void Encrypt(string origString, string encString, byte[] encArray, byte[] encIV)
        {
            FileStream openFS = null;
            FileStream createFS = null;

            // creates new filestreams if path is valid. If not, catch exception.
            try
            {
                openFS = new FileStream(origString, FileMode.Open, FileAccess.Read);
                createFS = new FileStream(encString, FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch
            {
                MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            byte[] store = new byte[100];
            long bytesWritten = 0;
            long inFileLength = openFS.Length;
            int len;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            CryptoStream makeEncryption = new CryptoStream(createFS, des.CreateEncryptor(encArray, encIV), CryptoStreamMode.Write);
            while (bytesWritten < inFileLength)
            { 
                len = openFS.Read(store, 0, 100);
                makeEncryption.Write(store, 0, len);
                bytesWritten += len;
            }
            makeEncryption.Close();
            openFS.Close();
            createFS.Close();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        { 

            if(PasswordKey() == true)
            {
                string originalKey = openFileText.Text;
                if(originalKey.EndsWith(".des"))
                {
                    // new string w/o .des file extension
                    string nonDes = originalKey.Substring(0, originalKey.Length - 4);

                    //char[] nonDes = new char[originalKey.Length - 4];
                    //for(int i = 0; i < originalKey.Length - 4; i++)
                    //{
                    //   nonDes[i] = originalKey[i];
                    //}
                    //string convd = nonDes.ToString();
                   if(File.Exists(nonDes))
                   {
                       if (MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo) == DialogResult.No)
                       {
                           return;
                       }
                   }
                       Decrypt(originalKey, nonDes, encryptKey, encryptKey);
                }
                else
                {
                    MessageBox.Show("Not a .des file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Decrypt(string origString, string encString, byte[] encArray, byte[] encIV)
        {
            FileStream openFS = null;
            FileStream createFS = null;

            // creates new filestreams if path is valid. If not, catch exception.
            try
            {
                openFS = new FileStream(origString, FileMode.Open, FileAccess.Read);
                createFS = new FileStream(encString, FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch
            {
                MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            byte[] store = new byte[100];
            long bytesWritten = 0;
            long inFileLength = openFS.Length;
            int len;

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            CryptoStream makeDecryption = new CryptoStream(createFS, des.CreateDecryptor(encArray, encIV), CryptoStreamMode.Write);

            // write the file, if valid
            try
            {
                while (bytesWritten < inFileLength)
                {
                    len = openFS.Read(store, 0, 100);
                    makeDecryption.Write(store, 0, len);
                    bytesWritten += len;
                }
                makeDecryption.Close();
            }
                // catch if key or file is bad. If so, close all streams.
            catch
            {
                MessageBox.Show("Bad key or file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                openFS.Close();
                createFS.Close();
                File.Delete(encString);
                return;
            }
            openFS.Close();
            createFS.Close();
            File.Delete(origString);
        }
    }
}

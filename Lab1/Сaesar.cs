using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Сaesar
    {

        private int Key = 0;
        private int InpLength = 0;
        private string ResStr = "";
        private string InpStr = "";
        private char[] InpArr;

        private string fileName;
        private string fileNameOut;
        private string fileNameKey;

        public Сaesar(string fileName, string fileNameOut, string fileNameKey)
        {
            this.fileName = fileName;
            this.fileNameOut = fileNameOut;
            this.fileNameKey = fileNameKey;
        }

        private void ReadKeyFromFile(string FilePath)
        {
            using (StreamReader readKey = new StreamReader(FilePath))
            {
                Key = int.Parse(readKey.ReadToEnd());
            }
        }

        // Coder
        public void EncryptionFile()
        {
            if ((fileName.Length != 0) && (fileNameKey.Length != 0))
            {
                ReadKeyFromFile(fileNameKey);
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    using (StreamWriter writeRes = new StreamWriter(fileNameOut))
                    {
                        while ((InpStr = readFile.ReadLine()) != null)
                        {
                            InpArr = InpStr.ToCharArray();
                            InpLength = InpStr.Length;
                            for (int I = 0; I < InpLength; I++)
                            {
                                if ((InpArr[I] >= 'A') && (InpArr[I] <= 'Z'))
                                {
                                    InpArr[I] = (char)(InpArr[I] + Key);
                                    if (InpArr[I] > 'Z')
                                    {
                                        InpArr[I] = (char)(InpArr[I] - 26);
                                    }
                                }
                                else
                                if ((InpArr[I] >= 'a') && (InpArr[I] <= 'z'))
                                {
                                    InpArr[I] = (char)(InpArr[I] + Key);
                                    if (InpArr[I] > 'z')
                                    {
                                        InpArr[I] = (char)(InpArr[I] - 26);
                                    }
                                }
                                else
                                    if ((InpArr[I] >= 'А') && (InpArr[I] <= 'Я'))
                                {
                                    InpArr[I] = (char)(InpArr[I] + Key);
                                    if (InpArr[I] > 'Я')
                                    {
                                        InpArr[I] = (char)(InpArr[I] - 33);
                                    }
                                }
                                else
                                    if ((InpArr[I] >= 'а') && (InpArr[I] <= 'я'))
                                {
                                    InpArr[I] = (char)(InpArr[I] + Key);
                                    if (InpArr[I] > 'я')
                                    {
                                        InpArr[I] = (char)(InpArr[I] - 33);
                                    }
                                }
                            }
                            ResStr = new string(InpArr);
                            writeRes.WriteLine(ResStr);
                            ResStr = "";
                        }
                    }
                }
            }
        }
        // Decoder
        public void DecipherFile()
        {
            if ((fileName.Length != 0) && (fileNameKey.Length != 0))
            {
                ReadKeyFromFile(fileNameKey);
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    using (StreamWriter writeRes = new StreamWriter(fileNameOut))
                    {
                        while ((InpStr = readFile.ReadLine()) != null)
                        {
                            InpArr = InpStr.ToCharArray();
                            InpLength = InpStr.Length;
                            for (int I = 0; I < InpLength; I++)
                            {
                                if ((InpArr[I] >= 'A') && (InpArr[I] <= 'Z'))
                                {
                                    InpArr[I] = (char)(InpArr[I] - Key);
                                    if (InpArr[I] < 'A')
                                    {
                                        InpArr[I] = (char)(InpArr[I] + 26);
                                    }
                                }
                                else
                                if ((InpArr[I] >= 'a') && (InpArr[I] <= 'z'))
                                {
                                    InpArr[I] = (char)(InpArr[I] + Key);
                                    if (InpArr[I] < 'a')
                                    {
                                        InpArr[I] = (char)(InpArr[I] + 26);
                                    }
                                }
                                else
                                    if ((InpArr[I] >= 'А') && (InpArr[I] <= 'Я'))
                                {
                                    InpArr[I] = (char)(InpArr[I] - Key);
                                    if (InpArr[I] < 'А')
                                    {
                                        InpArr[I] = (char)(InpArr[I] + 33);
                                    }
                                }
                                else
                                    if ((InpArr[I] >= 'а') && (InpArr[I] <= 'я'))
                                {
                                    InpArr[I] = (char)(InpArr[I] - Key);
                                    if (InpArr[I] < 'а')
                                    {
                                        InpArr[I] = (char)(InpArr[I] + 33);
                                    }
                                }
                            }
                            ResStr = new string(InpArr);
                            writeRes.WriteLine(ResStr);
                            ResStr = "";
                        }
                    }
                }
            }
        }
    }
}

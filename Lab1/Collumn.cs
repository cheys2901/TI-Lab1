using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab1
{
    class Collumn
    {
        private string Key = "";
        private int InpLength = 0;
        private int KeyLength = 0;
        private int MatrHeight = 0;

        private string ResStr = "";
        private string InpStr = "";
        private char[,] Matr;

        private string fileName;
        private string fileNameOut;
        private string fileNameKey;

        int[] StartPos;
        public Collumn(string fileName, string fileNameOut, string fileNameKey)
        {
            this.fileName = fileName;
            this.fileNameOut = fileNameOut;
            this.fileNameKey = fileNameKey;
        }

        private void ReadKeyFromFile(string FilePath)
        {
            using (StreamReader readKey = new StreamReader(FilePath))
            {
                Key = readKey.ReadToEnd();
            }
        }
        private void MatrSort()
        {
            int I, J;
            for (I = 0; I < KeyLength; I++)
            {
                StartPos[I] = I;
            }
            int Temp;
            char TempC;
            char[] charStr = Key.ToCharArray();
            for (I = 0; I < KeyLength - 1; I++)
            {
                for (J = I + 1; J < KeyLength; J++)
                {
                    if (charStr[I] > charStr[J])
                    {
                        TempC = charStr[I];
                        charStr[I] = charStr[J];
                        charStr[J] = TempC;

                        Temp = StartPos[I];
                        StartPos[I] = StartPos[J];
                        StartPos[J] = Temp;
                    }
                }
            }
            Key = new string(charStr);
        }
        // Coder
        public void EncryptionFile()
        {
            if ((fileNameKey.Length != 0) && (fileName.Length != 0))
            {
                ReadKeyFromFile(fileNameKey);
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    using (StreamWriter writeRes = new StreamWriter(fileNameOut))
                    {
                        while ((InpStr = readFile.ReadLine()) != null)
                        {
                            InpLength = InpStr.Length;
                            KeyLength = Key.Length;
                            MatrHeight = InpLength / KeyLength;
                            if (InpLength % KeyLength != 0)
                            {
                                MatrHeight++;
                            }
                            Matr = new char[MatrHeight, KeyLength];
                            StartPos = new int[KeyLength];
                            int I = 0, J = 0, H = 0;
                            for (I = 0; I < MatrHeight; I++)
                            {
                                for (J = 0; J < KeyLength; J++)
                                {
                                    if (H < InpLength)
                                    {
                                        Matr[I, J] = InpStr[H];
                                        H++;
                                    }
                                }
                            }

                            MatrSort();

                            for (I = 0; I < KeyLength; I++)
                            {
                                for (J = 0; J < MatrHeight; J++)
                                {
                                    if (Matr[J, StartPos[I]] != 0)
                                    {
                                        ResStr += Matr[J, StartPos[I]];
                                    }
                                }
                            }
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
            if ((fileNameKey.Length != 0) && (fileName.Length != 0))
            {
                ReadKeyFromFile(fileNameKey);
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    using (StreamWriter writeRes = new StreamWriter(fileNameOut))
                    {
                        while ((InpStr = readFile.ReadLine()) != null)
                        {
                            InpLength = InpStr.Length;
                            KeyLength = Key.Length;
                            MatrHeight = InpLength / KeyLength;
                            if (InpLength % KeyLength != 0)
                            {
                                MatrHeight++;
                            }
                            Matr = new char[MatrHeight, KeyLength];
                            StartPos = new int[KeyLength];
                            int I = 0, J = 0, H = 0;

                            MatrSort();

                            int CurHeight = MatrHeight;
                            for (I = 0; I < KeyLength; I++)
                            {
                                if ((InpLength % KeyLength) - 1 < StartPos[I])
                                {
                                    CurHeight = MatrHeight - 1;
                                }
                                else CurHeight = MatrHeight;
                                for (J = 0; J < CurHeight; J++)
                                {
                                    Matr[J, StartPos[I]] = InpStr[H];
                                    H++;
                                }
                            }

                            for (I = 0; I < MatrHeight; I++)
                            {
                                for (J = 0; J < KeyLength; J++)
                                {
                                    if (Matr[I, J] != 0)
                                    {
                                        ResStr += Matr[I, J];
                                    }
                                }
                            }
                            writeRes.WriteLine(ResStr);
                            ResStr = "";
                        }
                    }
                }
            }
        }
    }
}

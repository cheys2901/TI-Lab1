using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Railway
    {

        private int Key = 0;
        private int InpLength = 0;
        private string ResStr = "";
        private string InpStr = "";
        private char[,] Matr;

        private string fileName;
        private string fileNameOut;
        private string fileNameKey;

        public Railway(string fileName, string fileNameOut, string fileNameKey)
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
                            Matr = new char[Key, InpLength];
                            StrToMart();
                            MatrToResStrGor();
                            writeRes.WriteLine(ResStr);
                            ResStr = "";
                        }
                    }
                }
            }
        }
        private void StrToMart()
        {
            int I = 0, J = 0;
            bool Dir = true;
            // Проход матрицы по диагонали
            for (J = 0; J < InpLength; J++)
            {
                Matr[I, J] = InpStr[J];
                if (I == (Key - 1))
                {
                    Dir = false;
                }
                else
                    if (I == 0)
                {
                    Dir = true;
                }
                if (Dir == true)
                {
                    ++I;
                }
                else
                {
                    --I;
                }
            }
        }
        private void MatrToResStrGor()
        {
            int I, J;
            for (I = 0; I < Key; I++)
            {
                for (J = 0; J < InpLength; J++)
                {
                    if (Matr[I, J] != 0)
                    {
                        ResStr += Matr[I, J];
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
                            Matr = new char[Key, InpLength];
                            InpLength = InpStr.Length;
                            int InStrInd = 0;

                            int I = 0, J = 0;
                            bool Dir = true;
                            // Проход матрицы по диагонали
                            for (J = 0; J < InpLength; J++)
                            {
                                Matr[I, J] = '1';
                                if (I == (Key - 1))
                                {
                                    Dir = false;
                                }
                                else
                                    if (I == 0)
                                {
                                    Dir = true;
                                }
                                if (Dir == true)
                                {
                                    ++I;
                                }
                                else
                                {
                                    --I;
                                }
                            }

                            int H = 0;
                            for (I= 0; I < Key; I++)
                            {
                                for (J=0; J < InpLength; J++)
                                {
                                    if (Matr[I, J] == '1')
                                    {
                                        Matr[I, J] = InpStr[H];
                                        H++;
                                    }
                                }
                            }
                            Dir = true;
                            ResStr = "";
                            I = 0;
                            for (J = 0; J < InpLength; J++)
                            {
                                ResStr += Matr[I, J];
                                if (I == (Key - 1))
                                {
                                    Dir = false;
                                }
                                else
                                    if (I == 0)
                                {
                                    Dir = true;
                                }
                                if (Dir == true)
                                {
                                    ++I;
                                }
                                else
                                {
                                    --I;
                                }
                            }

                            writeRes.WriteLine(ResStr);
                            ResStr = "";
                        }
                    }
                }
            }
        }
        private int GetElementsCount(int I)
        {

            int Res;
            Res = InpLength / (Key * 2 - 2);
            if ((I != 0) && (I != Key - 1))
            {
                Res *= 2;
            }

            // Рассматриваем все варианты количества элементов для каждой строки
            // Может можно было сделать и красиво, может потом сделаю (идея с массивом(чтоб не забыть))
            if (InpLength % (Key * 2 - 2) != 0)
            {
                if ((((InpLength % (Key * 2 - 2)) % Key) > 0) && (((InpLength % (Key * 2 - 2)) / Key) == 0))
                {
                    if (((InpLength % (Key * 2 - 2)) % Key) == I)
                    {
                        Res++;
                    }
                }
                else
                    if ((((InpLength % (Key * 2 - 2)) % Key) == 0) && (((InpLength % (Key * 2 - 2)) / Key) == 1))
                {
                    Res++;
                }
                else
                    if ((((InpLength % (Key * 2 - 2)) % Key) > 0) && (((InpLength % (Key * 2 - 2)) / Key) == 1))
                {
                    Res++;
                    if ((I >= (Key - (((InpLength % (Key * 2 - 2)) - Key) % Key) - 1) && (I <= (Key - 2))))
                    {
                        Res++;
                    }
                }
            }
            if ((Key < 6) && ((I == 0) || (I == Key -1)))
            {
                Res -= 1;
            }
            //else if ((Key < 6) && ((I == 0) || (I == Key - 1)))
            //{
            //    Res += 1;
            //}
            return Res;
        }
        private string MatrToResStr()
        {
            int I, J;
            string Res = "";
            bool Dir = true;
            I = 0;
            for (J = 0; J < InpLength; J++)
            {
                Res += Matr[I, J].ToString();
                if (I == (Key - 1))
                {
                    Dir = false;
                }
                else
                    if (I == 0)
                {
                    Dir = true;
                }
                if (Dir == true)
                {
                    ++I;
                }
                else
                {
                    --I;
                }
            }
            return Res;
        }
    }
}

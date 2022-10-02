using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CST_150_Activity5
{
    public partial class textProcFrm : Form
    {
        public textProcFrm()
        {
            InitializeComponent();
        }
        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamWriter outputFile;
            string inputText;
            string fileText = "";
            string maxWord = "";
            string input;
            openFile.ShowDialog();
            input = System.IO.File.ReadAllText(openFile.FileName);
            outputFile = File.CreateText("myFile.txt");

            //Display first and last item in the text file
            string[] arr = input.Split(' ');
            firstItmLstBx.Items.Add(arr[0]);
            lastItmLstBx.Items.Add(arr[arr.Length - 1]);
            outputFile.WriteLine("First word: " + arr[0]);
            outputFile.WriteLine("Last Word: " + arr[arr.Length - 1]);

            //Find the most vowels
            //Some code below was adopted from Chegg and modified to meet my needs
            //Some code below was adopted from the book and modified to meet my needs.
            int max = 0;
            int min = 0;
            int vowelCount = 0;
            int vowel = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == "a" || arr[i] == "e" || arr[i] == "i" || arr[i] == "o" || 
                    arr[i] == "u" || arr[i] == "A" || arr[i] == "E" || arr[i] ==
                "I" || arr[i] == "O" || arr[i] == "U")
                {
                    vowel = vowel + 1;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (max < arr[i].Length)
                {
                    max = arr[i].Length;
                    min = i;
                }
                else if(vowelCount < vowel)
                {
                    vowelCount = arr[i].Length;
                    min = i;
                }
            }
            mstVowelsLstBx.Items.Add(arr[max]);
            outputFile.WriteLine("Word with the most Vowels: " + arr[max]);
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Open the selected file.
                
                //int len = inputText.Length;
                
                inputFile = File.OpenText(openFile.FileName);
                //inputText = inputFile.ReadToEnd();

                
                try
                {


                    //Read all contents from file
                    int i = 0;
                    
                    while (!inputFile.EndOfStream)
                    {
                        //Convert contents to lowercase
                        
                        inputText = inputFile.ReadLine();
                        inputText = inputText.ToLower();
                        fileText += inputText;
                        textDocumentLstBx.Items.Add(inputText);

                        

                        int si = 0;
                        int ei = 0;
                        int maxIn = 0;
                        int maxStart = 0;
                        int len = inputText.Length;
                        int minStart = 0;
                        int maxLen = 0;
                        int minLen = len;
                        while (ei <= len)
                        {
                            if (ei <= len)
                            {
                                ei++;
                            }
                            else
                            {
                                int currentLen = ei - si;
                                if (currentLen < minLen)
                                {
                                    minLen = currentLen;
                                    minStart = si;
                                }
                                else if (currentLen > maxLen)
                                {
                                    maxLen = currentLen;
                                    maxIn = si;
                                }
                                ei++;
                                si = ei;
                            }
                        }
                        maxWord = inputText.Substring(maxStart, maxLen);
                        longestWordLstBx.Items.Add(maxWord);
                        
                        //Find the longest word in the whole file
                        //Code found from https://www.geeksforgeeks.org/program-find-smallest-largest-word-string/
                        //Modified to find the longest word only



                    }
                    //Close file
                    
                    inputFile.Close();
                    
                }
                catch (Exception ex) { MessageBox.Show("File not found"); }
            }
            else { MessageBox.Show("Operation canceled."); }
            outputFile.WriteLine("Entire document lowercase: " + fileText);
            outputFile.Close();
        }


    }
}

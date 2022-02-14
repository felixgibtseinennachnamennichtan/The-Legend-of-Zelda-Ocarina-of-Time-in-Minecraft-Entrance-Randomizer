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
using System.Diagnostics;

namespace TLoZOoTiM_Rando
{
    public partial class Form1 : Form
    {
        public string[] KokiriInside;
        public string[] KokiriOutside;
        public string[] KokiriInsideRando;
        public string[] KokiriOutsideRando;
        public int[] Other;
        public string ogPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                     ogPath = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);
                    List<string> Kokiri = new List<string>();
                    
                    foreach (string s in files) {
                        if (s.Substring(s.Length- "inside.mcfunction".Length,"inside.mcfunction".Length).Equals("inside.mcfunction")) {
                            Kokiri.Add(s);
                        }
                    }
                    KokiriInside = Kokiri.ToArray();
                    Kokiri.Clear();
                    foreach (string s in files)
                    {
                        if ( s.Substring(s.Length - "outside.mcfunction".Length, "outside.mcfunction".Length).Equals("outside.mcfunction"))
                        {
                            Kokiri.Add(s);
                        }
                    }
                    KokiriOutside = Kokiri.ToArray();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] inside = KokiriInsideFiles();
            string[] outside = KokiriOutsideFiles();
            foreach (string s in inside) {
                Debug.WriteLine(s);
            }
            Debug.WriteLine("#############");
            foreach (string s in outside)
            {
                Debug.WriteLine(s);
            }
            RandomizeKokiri();
            KokiriInsideRando = new string[Other.Length];
            KokiriOutsideRando = new string[Other.Length];
            int i = 0;
            foreach (string s in outside) {
                KokiriOutsideRando[i] = outside[Other[i]];
                i++;
            }
            i = 0;
            foreach (string s in inside)
            {
                KokiriInsideRando[Other[i]] = inside[i];
                i++;
            }
        }
        string[] KokiriInsideFiles() {
            int i = 0;
            string[] ret = new string[KokiriInside.Length];
            foreach (string s in KokiriInside) {

               ret[i]= File.ReadAllText(@s);
                i++;
            }

            return  ret; }
        string[] KokiriOutsideFiles()
        {
            int i = 0;
            string[] ret = new string[KokiriOutside.Length];
            foreach (string s in KokiriOutside)
            {

                ret[i] = File.ReadAllText(@s);
                i++;
            }

            return ret;
        }
        
        void RandomizeKokiri() {
            Random num = new Random();
            bool[] free = new bool[KokiriInsideFiles().Length];
            for (int j = 0;j<free.Length;j++) {
                free[j]=true;
            }
            int i = 0;
            Other = new int[KokiriInsideFiles().Length];
            foreach (string s in KokiriInsideFiles()) {
                int foo = num.Next(0,free.Length);
                bool mybool = false;
                for (;free[foo]==false||mybool==false;) {
                    foo = num.Next(0, free.Length);
                    string pathseg1 = KokiriInside[foo].Substring(ogPath.Length + 1,( KokiriInside[foo].Length - ogPath.Length + 1) - "inside.mcfunction".Length+2);
                    int backslash = pathseg1.IndexOf("\\");
                    string pathseg2 = pathseg1.Substring(0,backslash);
                    
                    Debug.WriteLine(pathseg2);

                    string pathseg3 = KokiriInside[i].Substring(ogPath.Length + 1, (KokiriInside[i].Length - ogPath.Length + 1) - "inside.mcfunction".Length+2);
                    int backsslash = pathseg3.IndexOf("\\");
                    string pathseg4 = pathseg3.Substring(0, backsslash);
                    mybool = pathseg2==pathseg4;
                    if (mybool) { Debug.WriteLine("Match"); }
                    Debug.WriteLine(pathseg4);
                    
                }
                
                Other[i] = foo;
                Debug.WriteLine(foo);
                free[foo] = false;
                i++;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string s in KokiriInside) {
                File.WriteAllText(s,KokiriInsideRando[i]);
                i++;
            }
             i = 0;
            foreach (string s in KokiriOutside)
            {
                File.WriteAllText(s, KokiriOutsideRando[i]);
                i++;
            }
        }
    }
}

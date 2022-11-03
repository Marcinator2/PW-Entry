using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WindowsInput.Native;
using WindowsInput;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace PW_Entry
{
    public partial class Form1 : Form
    {
        internal const int ActiveResize = 3;

        //Import the FindWindow API to find our window
        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        //Import the SetForeground API to activate it
        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd1, int nCmdShow);

        List<string> PWListe = new List<string>();
        List<string> IPListe = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnListeImportieren_Click(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            int Wartezeit = Int32.Parse(tbxWartezeit.Text);
            int Delay = Int32.Parse(tbxDelay.Text);
            string Passwort = lbxListe.SelectedIndex.ToString();

            Passwort = tbxPasswd.Text;
            Wartezeit = Wartezeit * 1000;

            simulateTypingText(Passwort, Delay, Wartezeit);
            //btnStart.BackColor = Color.Orange;

        }



        public void simulateTypingText(string Text, int typingDelay = 100, int startDelay = 0)
        {
            //btnStart.BackColor = Color.Orange;
            InputSimulator sim = new InputSimulator();

            // Wait the start delay time
            sim.Keyboard.Sleep(startDelay);

            // Split the text in lines in case it has
            string[] lines = Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                // Split line into characters
                char[] words = line.ToCharArray();

                // Simulate typing of the char i.e: a, e , i ,o ,u etc
                // Apply immediately the typing delay
                foreach (char word in words)
                {
                    sim.Keyboard.TextEntry(word).Sleep(typingDelay);
                }

                //Enter nach PW drücken
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            }
        }

        private void btnPasswort_MouseDown(object sender, MouseEventArgs e)
        {
            tbxPasswd.UseSystemPasswordChar = false;
        }

        private void btnPasswort_MouseUp(object sender, MouseEventArgs e)
        {
            tbxPasswd.UseSystemPasswordChar = true;
        }
        private void tbxDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void tbxWartezeit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        public void btnListeImportieren_Click(object sender, EventArgs e)

        {
            try
            {
            lbxListe.Items.Clear();
            PWListe.Clear();
            IPListe.Clear();
            var pfad = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string path = pfad + @"\Data.csv";

                List<example> values = File.ReadAllLines(path)

                                              .Skip(1)

                                              .Select(v => example.FromCsv(v))

                                              .ToList();

                foreach (var item in values)

                {

                    lbxListe.Items.Add(item.t1);
                    PWListe.Add(item.t2);
                    IPListe.Add(item.t3);

                }
            }
            catch (Exception ex)
            { MessageBox.Show("Data.csv ist geöffnet oder nicht vorhanden."); }
            return;
        }

        public class example

        {

            public string t1;

            public string t2;

            public string t3;

            public static example FromCsv(string csvLine)

            {

                string[] values = csvLine.Split(';');

                example dailyValues = new example();

                dailyValues.t1 = values[0];
                dailyValues.t2 = values[1];
                dailyValues.t3 = values[2];


                return dailyValues;

            }

        }

        private void lbxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxListe.SelectedIndex >= 0)
            {
                tbxPasswd.Text = PWListe[lbxListe.SelectedIndex];

            }
        }

      
        private void btnFensterSuchen_Click(object sender, EventArgs e)
        {

            Process[] processlist = Process.GetProcesses();

            

            foreach (Process process in processlist)
            {

                if (!String.IsNullOrEmpty(process.MainWindowTitle) && lbxListe.SelectedIndex >= 0 && Convert.ToString(IPListe[lbxListe.SelectedIndex]) != "")
                {
                    if (process.MainWindowTitle.Contains(IPListe[lbxListe.SelectedIndex]))
                    {
                        ShowWindow(process.MainWindowHandle, 9);
                        SetForegroundWindow(process.MainWindowHandle);
                        
                    }
                }
            }

        }
     

    }


}


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
using System.Threading;
using System.Globalization;
using ProgressBarSample;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Windows; 


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

            LangInit();//Set Language
            btnListeImportieren_Click(sender, e); //Import Data.csv
            barSicht.Value = Properties.Settings.Default.Opacity;
            Sichtbarkeit = Convert.ToDouble(barSicht.Value);
            Sichtbarkeit /= 100;
            GetSettings();  
            this.Opacity = Sichtbarkeit;
        }
        public double Sichtbarkeit;

        public void GetSettings()
        {
            tbxDelay.Text = Properties.Settings.Default.Delay.ToString();
            tbxWartezeit.Text = Properties.Settings.Default.WaitTime.ToString();
            barSicht.Value = Properties.Settings.Default.Opacity;
        }
        public void SaveSettigs()
        {
            Properties.Settings.Default.Delay = Convert.ToInt32(tbxDelay.Text);
            Properties.Settings.Default.WaitTime = Convert.ToInt32(tbxWartezeit.Text);
            Properties.Settings.Default.Opacity = barSicht.Value;
            Properties.Settings.Default.Save();

        }

        //Set Language
        public void LangInit()
        {

            btnListeimportieren.Text = Properties.strings.ImpList;
            btnFensterSuchen.Text = Properties.strings.SearchWind;
            btnPasswort.Text = Properties.strings.ShowPW;
            label3.Text = Properties.strings.EnterPW;
            label2.Text = Properties.strings.WaitTime;
            label1.Text = Properties.strings.Delay;
            btnStart.Text = Properties.strings.Start;
            menuLang.Text = Properties.strings.Lang;
            menuLangGER.Text = Properties.strings.LangDE;
            menuLangENG.Text = Properties.strings.LangEN;
            lblSicht.Text = Properties.strings.ChangeVisibility;
            btnSave.Text = Properties.strings.Save;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            int Wartezeit = Int32.Parse(tbxWartezeit.Text);
            int Delay = Int32.Parse(tbxDelay.Text);
            string Passwort = lbxListe.SelectedIndex.ToString();

            Passwort = tbxPasswd.Text;
            Wartezeit = Wartezeit * 1000;

            simulateTypingText(Passwort, Delay, Wartezeit);
           

        }



        public void simulateTypingText(string Text, int typingDelay = 100, int startDelay = 0)
        {
        
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
            catch (Exception)
            { MessageBox.Show(Properties.strings.NotFound); }
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

        private void menuLangGER_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
            LangInit();
        }
        public void menuLangENG_Click(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-GB");
            LangInit();

        }





        private void barSicht_Click(object sender, EventArgs e)
        {
            // Get mouse position(x) minus the width of the progressbar (so beginning of the progressbar is mousepos = 0 //
            float absoluteMouse = (PointToClient(MousePosition).X - barSicht.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = barSicht.Width / (float)barSicht.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;
            // Set the calculated relative value to the progressbar //


            this.barSicht.Value = Convert.ToInt32(relativeMouse);

            Sichtbarkeit = Convert.ToDouble(barSicht.Value);
            Sichtbarkeit = Sichtbarkeit / 100;
            this.Opacity = Sichtbarkeit;
         }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0xA0) // WM_NCMOUSEMOVE
            {
                TrackNcMouseLeave(this);
                ShowClientArea();
            }
            else if (m.Msg == 0x2A2) // WM_NCMOUSELEAVE
            {
                HideClientAreaIfPointerIsOut();
            }

            base.WndProc(ref m);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            HideClientAreaIfPointerIsOut();
        }

        private void ShowClientArea()
        {
                this.Opacity = 1;
        }

        private void HideClientAreaIfPointerIsOut()
        {
            if (this.Bounds.Contains(Cursor.Position))
                return;

            Sichtbarkeit= Convert.ToDouble(barSicht.Value);
            Sichtbarkeit/=100;
            this.Opacity = Sichtbarkeit;
         }

        public static void TrackNcMouseLeave(Control control)
        {
            TRACKMOUSEEVENT tme = new TRACKMOUSEEVENT();
            tme.cbSize = (uint)Marshal.SizeOf(tme);
            tme.dwFlags = 2 | 0x10; // TME_LEAVE | TME_NONCLIENT
            tme.hwndTrack = control.Handle;
            TrackMouseEvent(tme);
        }

        [DllImport("user32")]
        public static extern bool TrackMouseEvent([In, Out] TRACKMOUSEEVENT lpEventTrack);

        [StructLayout(LayoutKind.Sequential)]
        public class TRACKMOUSEEVENT
        {
            public uint cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public uint dwHoverTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettigs();  

        }
    }
}

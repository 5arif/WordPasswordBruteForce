using System.Collections.Concurrent;
using System.Security;

namespace WordPasswordBruteForce
{
    public partial class MainForm : Form
    {
        private static string allowedStr = String.Empty;
        private static char[] allowedCC = Array.Empty<char>();
        private int allowedlattertIdx = -1;
        private object syncLockerobjNewPassword = new object();
        private char[] passwordToVerify = Array.Empty<char>();

        private string? fileName = null;
        private List<Thread>? TTCll = null;
        private DateTime startDtTm;

        private object syncLockerobjStopSearch = new object();
        private bool stopSearch = false;

        private List<string> testedPasswords;

        public MainForm()
        {
            InitializeComponent();

            EstimatedTimeTxt_Populate();

            openFileDialog1.Filter = "Word Document (*.DOC;*.DOCX;*.RTF)|*.DOC;*.DOCX;*.RTF|All files (*.*)|*.*";
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            BtnFind.Enabled = false;
            btnBrowse.Enabled = false;
            testedPasswords = new();

            allowedStr = AllowedCharsToString();
            allowedCC = allowedStr.ToCharArray();
            allowedlattertIdx = allowedStr.Length - 1;

            fileName = FileNameTxt.Text;
            startDtTm = DateTime.UtcNow;

            // --- set first password to check
            int PwMinLen = int.Parse(PwMinLenTxt.Text);
            passwordToVerify = new char[PwMinLen];
            passwordToVerify = new string(allowedCC[0], PwMinLen).ToCharArray();

            int ThreadToUse = int.Parse(MaxTasksTxt.Text);
            ThreadPanel_Create(ThreadToUse);

            TTCll = new List<Thread>();
            for (int numt = 0; numt < ThreadToUse; numt++)
            {
                TextBox NumTxt = (TextBox)(EsecuzioneTLP.Controls["NumThread" + numt.ToString("00") + "Txt"]);
                var T = new Thread(() => { Runner(NumTxt); });
                T.Priority = System.Threading.ThreadPriority.BelowNormal;
                T.Start();
                TTCll.Add(T);
            }
        }

        private void ThreadPanel_Create(int Tot)
        {
            EsecuzioneTLP.ColumnCount = Tot;

            // the first column already exists
            {
                ColumnStyle ClnSt = new ColumnStyle(SizeType.Percent, ((float)1 / Tot * 100));
                EsecuzioneTLP.ColumnStyles[0] = ClnSt;
            }

            for (int Idx = 0 + 1; Idx < Tot; Idx++)
            {
                ColumnStyle ClnSt = new ColumnStyle(SizeType.Percent, ((float)1 / Tot * 100));
                int i = EsecuzioneTLP.ColumnStyles.Add(ClnSt);
            }

            for (int Idx = 0; Idx < Tot; Idx++)
            {
                // r 1
                EsecuzioneTLP.Controls.Add(new Label() { Text = Idx.ToString("00") }, Idx, 0);
                // r 2
                TextBox NumTxt = new TextBox() { TextAlign = HorizontalAlignment.Right, Width = 50, Name = "NumThread" + Idx.ToString("00") + "Txt", Dock = DockStyle.Fill };
                EsecuzioneTLP.Controls.Add(NumTxt, Idx, 1);
            }
        }

        private void Runner(TextBox NumTxt)
        {
            var AA = new Action<string>((s) => { NumTxt.Text = s; });
            //--- App Word
            NumTxt.Invoke(AA, "word");
            var WApp = new Microsoft.Office.Interop.Word.Application();
            NumTxt.Invoke(AA, string.Empty);

            while (!StopSearch())
            {
                string test = new string(PasswordNext());
                while ((bool)this.Invoke(() => testedPasswords.Contains(test)))
                {
                    Text = new string(PasswordNext());
                }

                testedPasswords.Add(test);
                NumTxt.Invoke(AA, test);
                {
                    Microsoft.Office.Interop.Word.Document? WDoc = null;
                    try
                    {
                        WDoc = WApp.Documents.Open(fileName, PasswordDocument: test, ReadOnly: true);
                        StopSearch(true);

                        Achivied(test);

                        WDoc.Close();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(WDoc);
                    }
                    catch (Exception ex)
                    {
                        ex.Message.Contains("The password is incorrect. Word cannot open the document.");
                    }
                }
            }

            if (WApp != null)
            {

                try { WApp.Quit(); } finally { }
                try { System.Runtime.InteropServices.Marshal.ReleaseComObject(WApp); } finally { }
            }
        }

        private char[] PasswordNext()
        {
            char[] GiveBack;

            lock (syncLockerobjNewPassword)
            {
                // --- password to verify
                GiveBack = new char[passwordToVerify.Length];

                // --- password to prepare to next round
                passwordToVerify.CopyTo(GiveBack, 0);
                //  prepare next pwd
                bool riporto = false;
                for (int i = passwordToVerify.Length - 1; i >= 0; i--)
                {
                    if (passwordToVerify[i] != allowedCC[allowedlattertIdx])
                    {
                        passwordToVerify[i] = allowedCC[(allowedStr.IndexOf(passwordToVerify[i]) + 1)];
                        riporto = false;
                        break;
                    }
                    else
                    {
                        passwordToVerify[i] = allowedCC[0];
                        riporto = true;
                    }
                }
                // --- insert new starting char on left side
                if (riporto)
                {
                    char[] tmp = new char[passwordToVerify.Length];
                    passwordToVerify.CopyTo(tmp, 0);

                    passwordToVerify = new char[passwordToVerify.Length + 1];
                    passwordToVerify[0] = allowedCC[0];
                    tmp.CopyTo(passwordToVerify, 1);
                }
            }

            return GiveBack;
        }

        private bool StopSearch(bool stopper = false)
        {
            bool yn;

            lock (syncLockerobjStopSearch)
            {
                if (stopper)
                {
                    stopSearch = stopper;
                }

                yn = stopSearch;
            }

            return yn;
        }

        private void Achivied(string pw)
        {
            PasswordTxt.Invoke(new Action(() => { PasswordTxt.Text = pw; }));
            try
            {
                DateTime NowDtTm = DateTime.UtcNow;
                TimeNeededTxt.Invoke(new Action(() => { TimeNeededTxt.Text = (NowDtTm - startDtTm).ToString(@"d\g\g\:hh\h\h\:mm\m\m\:ss\s\s"); }));
                TimeNeededTxt.Invoke(new Action(() => { StartTxt.Text = (startDtTm).ToString(); }));
                TimeNeededTxt.Invoke(new Action(() => { EndTxt.Text = (NowDtTm).ToString(); }));
                this.groupBox4.BackColor = Color.LightGreen;
            }
            finally
            { }
        }

        private void LunghezzaMassimaTxt_TextChanged(object sender, EventArgs e)
        {
            EstimatedTimeTxt_Populate();
        }

        private void MaxTasksTxt_TextChanged(object sender, EventArgs e)
        {
            EstimatedTimeTxt_Populate();
        }

        private void EstimatedTimeTxt_Populate()
        {
            ExtimedTimeTxt.Text = string.Empty;

            if (int.TryParse(PwMaxLenTxt.Text, out int L) && int.TryParse(MaxTasksTxt.Text, out int P))
            {
                // A-Z  +  a-z  +  0-9   (26+26+10=62) ->   238.328 combinations
                // 4 thread su 238.328 combinations  ->  2h,30m  -> 1.500 test/minut
                // 1.500 / 4 thread = 400 test/processore/minuto
                double minutes = Math.Pow(AllowedCharsToString().Length, L) / (P * 400);
                TimeSpan TS = new TimeSpan(0, (int)minutes, 0);
                ExtimedTimeTxt.Text = TS.ToString();
            }
        }

        private string AllowedCharsToString()
        {
            return (UppercaseChk.Checked ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : string.Empty)
                        + (LowercaseChk.Checked ? "abcdefghijklmnopqrstuvwxyz" : string.Empty)
                        + (NumbersChk.Checked ? "0123456789" : string.Empty)
                        + (SpecialChk.Checked ? " \"!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~" : string.Empty);
        }

        private void UppercaseChk_CheckedChanged(object sender, EventArgs e)
        {
            EstimatedTimeTxt_Populate();
        }

        private void LowercaseChk_CheckedChanged(object sender, EventArgs e)
        {
            EstimatedTimeTxt_Populate();
        }

        private void NumbersChk_CheckedChanged(object sender, EventArgs e)
        {
            EstimatedTimeTxt_Populate();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileNameTxt.Text = openFileDialog1.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
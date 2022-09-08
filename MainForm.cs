using NPOI.POIFS.Crypt;
using NPOI.POIFS.Crypt.Agile;
using NPOI.POIFS.FileSystem;
using System.Reflection;
using System.Security;

namespace WordPasswordBruteForce
{
    public partial class MainForm : Form
    {
        private static string allowedStr = String.Empty;
        private static char[] allowedCC = Array.Empty<char>();
        private int allowedlattertIdx = -1;
        private object syncLockerObjNewPassword = new();
        private char[] passwordToVerify = Array.Empty<char>();

        private string? fileName = null;
        private DateTime startDtTm;

        private object syncLockerObjStopSearch = new();
        private bool stopSearch = false;

        private List<string> testedPasswords;

        public MainForm()
        {
            InitializeComponent();

            //force to load AgileDecryptor
            Assembly.Load(typeof(AgileDecryptor).Assembly.GetName());

            EstimatedTimeTxt_Populate();
            openFileDoc.Filter = "Office Document (*.DOC;*.DOCX;*.RTF;*.XLS;*.XLSX;)|*.DOC;*.DOCX;*.RTF;*.XLS;*.XLSX;*.CSV|All files (*.*)|*.*";
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (!string.IsNullOrEmpty(errorProviderDoc.GetError(FileNameTxt)))
            {
                return;
            }

            MessageBox.Show("Start");

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
            stopSearch = false;

            for (int numt = 0; numt < ThreadToUse; numt++)
            {
                TextBox numTxt = (TextBox)(EsecuzioneTLP.Controls["NumThread" + numt.ToString("00") + "Txt"]);
                var thread = new Thread(() => { Runner(numTxt); });
                thread.Priority = ThreadPriority.Lowest;
                thread.Start();
            }
        }

        private void ThreadPanel_Create(int Tot)
        {
            if(EsecuzioneTLP.Controls.Count > 0)
            {
                EsecuzioneTLP.Controls.Clear();
            }

            EsecuzioneTLP.ColumnCount = Tot;
            // the first column already exists
            {
                ColumnStyle ClnSt = new(SizeType.Percent, ((float)1 / Tot * 100));
                EsecuzioneTLP.ColumnStyles[0] = ClnSt;
            }

            for (int Idx = 0 + 1; Idx < Tot; Idx++)
            {
                ColumnStyle ClnSt = new(SizeType.Percent, ((float)1 / Tot * 100));
                int i = EsecuzioneTLP.ColumnStyles.Add(ClnSt);
            }

            for (int Idx = 0; Idx < Tot; Idx++)
            {
                // r 1
                EsecuzioneTLP.Controls.Add(new Label() { Text = Idx.ToString("00") }, Idx, 0);
                // r 2
                TextBox NumTxt = new() { TextAlign = HorizontalAlignment.Right, Width = 50, Name = "NumThread" + Idx.ToString("00") + "Txt", Dock = DockStyle.Fill };
                EsecuzioneTLP.Controls.Add(NumTxt, Idx, 1);
            }
        }

        private void Runner(TextBox NumTxt)
        {
            var action = new Action<string>((s) => { NumTxt.Text = s; });
            NumTxt.Invoke(action, string.Empty);

            //NPOI
            var fileSystem = new POIFSFileSystem(new FileStream(fileName ?? String.Empty, FileMode.Open, FileAccess.Read));
            var info = new EncryptionInfo(fileSystem);
            var decryptor = Decryptor.GetInstance(info);

            while (!StopSearch())
            {
                string test = new(PasswordNext());
                while ((bool)Invoke(() => testedPasswords.Contains(test)))
                {
                    test = new string(PasswordNext());
                }

                testedPasswords.Add(test);
                NumTxt.Invoke(action, test);

                try
                {
                    if (decryptor.VerifyPassword(test))
                    {
                        StopSearch(true);
                        Achivied(test);
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.Contains("The password is incorrect. Word cannot open the document.");
                }
                finally
                {
                    fileSystem.Close();
                }
            }
        }

        private char[] PasswordNext()
        {
            char[] GiveBack;

            lock (syncLockerObjNewPassword)
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

            lock (syncLockerObjStopSearch)
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
                groupBox4.BackColor = Color.LightGreen;
            }
            finally
            {
                stopSearch = true;
                StopSearch(true);
            }
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
                TimeSpan TS = new(0, (int)minutes, 0);
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
            if (openFileDoc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileNameTxt.Text = openFileDoc.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StopSearch(true);
            BtnFind.Enabled = true;
            btnBrowse.Enabled = true;

            StartTxt.Text = String.Empty;
            PasswordTxt.Text = String.Empty;
            EndTxt.Text = String.Empty;
            TimeNeededTxt.Text = String.Empty;

            EsecuzioneTLP.Controls.Clear();
            groupBox4.BackColor = SystemColors.Control;
        }

        private void FileNameTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FileNameTxt.Text))
            {
                errorProviderDoc.SetError(FileNameTxt, "Please select file");
            }
            else
            {
                errorProviderDoc.Clear();
            }
        }

        private void openFileDoc_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDoc.FileName))
            {
                errorProviderDoc.Clear();
            }
        }
    }
}
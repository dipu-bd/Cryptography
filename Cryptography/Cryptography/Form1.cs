using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initPolybiusList(5);
            showRSAKeys();
        }

        #region Caesar Cipher

        /// <summary>
        /// previous selected index
        /// </summary>
        private int caesarIndex = 0;

        private void encryptCaesar()
        {
            string cipher = "";
            int val = (int)caesarNumeric.Value - caesarIndex;

            foreach (char ch in plainCaesar.Text)
            {
                if (char.IsLower(ch))
                {
                    cipher += (char)((ch - 'a' + val + 26) % 26 + 'a');
                }
                else if (char.IsUpper(ch))
                {
                    cipher += (char)((ch - 'A' + val + 26) % 26 + 'A');
                }
                else
                {
                    cipher += ch;
                }
            }

            plainCaesar.Text = cipher;
            caesarIndex = (caesarIndex + val) % 26;
        }

        private void caesarDistance_Scroll(object sender, EventArgs e)
        {
            int val = 26 - caesarDistance.Value;
            if (caesarNumeric.Value != val)
                caesarNumeric.Value = val;

            if (caesarIndex != caesarNumeric.Value)
                encryptCaesar();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (caesarNumeric2.Value != caesarNumeric.Value)
                caesarNumeric2.Value = caesarNumeric.Value;

            if (caesarNumeric.Value != caesarNumeric2.Value)
                caesarNumeric2.Value = caesarNumeric2.Value;

            int val = 26 - (int)caesarNumeric.Value;
            if (caesarDistance.Value != val)
                caesarDistance.Value = val;
        }

        #endregion

        #region Polyalphabetic Cipher

        private void encryptPolyalpha()
        {
            cipherPolyalpha.Clear();

            string key = polyalphaKeyword.Text.ToLower();
            if (key.Length == 0) return;

            string plain = plainPolyaplha.Text;
            string cipher = "";
            int pos = 0;
            foreach (char ch in plain)
            {
                if (char.IsLower(ch))
                {
                    int a = ch - 'a';
                    int k = key[pos] - 'a';
                    cipher += (char)((a + k) % 26 + 'a');
                    pos = (pos + 1) % key.Length;
                }
                else if (char.IsUpper(ch))
                {
                    int a = ch - 'A';
                    int k = key[pos] - 'a';
                    cipher += (char)((a + k) % 26 + 'A');
                    pos = (pos + 1) % key.Length;
                }
                else
                {
                    cipher += ch;
                }
            }
            cipherPolyalpha.Text = cipher;
        }

        private void decryptPolyalpha()
        {
            plainPolyaplha.Clear();

            string key = polyalphaKeyword.Text.ToLower();
            if (key.Length == 0) return;

            string plain = "";
            string cipher = cipherPolyalpha.Text;
            int pos = 0;
            foreach (char ch in cipher)
            {
                if (char.IsLower(ch))
                {
                    int a = ch - 'a';
                    int k = key[pos] - 'a';
                    plain += (char)((a - k + 26) % 26 + 'a');
                    pos = (pos + 1) % key.Length;
                }
                else if (char.IsUpper(ch))
                {
                    int a = ch - 'A';
                    int k = key[pos] - 'a';
                    plain += (char)((a - k + 26) % 26 + 'A');
                    pos = (pos + 1) % key.Length;
                }
                else
                {
                    plain += ch;
                }
            }
            plainPolyaplha.Text = plain;
        }

        private void polyRadio_CheckedChanged(object sender, EventArgs e)
        {
            plainPolyaplha.ReadOnly = polyalphaDecryptRadio.Checked;
            cipherPolyalpha.ReadOnly = polyalphaEncryptRadio.Checked;
        }

        private void plainPoly_TextChanged(object sender, EventArgs e)
        {
            if (polyalphaEncryptRadio.Checked) encryptPolyalpha();
        }

        private void cipherPoly_TextChanged(object sender, EventArgs e)
        {
            if (polyalphaDecryptRadio.Checked) decryptPolyalpha();
        }

        private void polyKeyword_TextChanged(object sender, EventArgs e)
        {
            if (polyalphaEncryptRadio.Checked) encryptPolyalpha();
            if (polyalphaDecryptRadio.Checked) decryptPolyalpha();
        }

        #endregion

        #region Polybius Cipher

        Point getpos(char ch)
        {
            int sz = polybiusSquare.Items.Count;
            for (int i = 0; i < sz; ++i)
                for (int j = 1; j <= sz; ++j)
                    if (polybiusSquare.Items[i].SubItems[j].Text == ch.ToString())
                        return new Point(i + 1, j);
            return new Point(0, 0);
        }

        private void encryptPolybius()
        {
            cipherPolybius.Clear();

            string plain = plainPolybius.Text;
            string cipher = "";
            foreach (char ch in plain)
            {
                if (char.IsLetter(ch))
                {
                    Point p = getpos(char.ToLower(ch));
                    cipher += p.X.ToString();
                    cipher += p.Y.ToString();
                }
                else
                {
                    cipher += ch;
                }

            }

            cipherPolybius.Text = cipher;
        }

        private void decryptPolybius()
        {
            plainPolybius.Clear();

            string plain = "";
            string cipher = cipherPolybius.Text;
            if (cipher.Length == 0) return;

            int n = polybiusSquare.Items.Count;
            for (int i = 1; i < cipher.Length; ++i)
            {
                if (!char.IsDigit(cipher, i - 1))
                {
                    plain += cipher[i - 1];
                    continue;
                }

                if (char.IsDigit(cipher, i))
                {
                    int x = cipher[i - 1] - '1';
                    int y = cipher[i] - '0';
                    if (x < 0 || y < 1 || x >= n || y > n) plain += "?";
                    else plain += polybiusSquare.Items[x].SubItems[y].Text;
                    ++i;
                }
            }

            plainPolybius.Text = plain;
        }

        private void doworkPolybius()
        {
            if (polybiusEncryptRadio.Checked) encryptPolybius();
            if (polybiusDecryptRadio.Checked) decryptPolybius();
        }

        private void polybiusRadio_CheckedChanged(object sender, EventArgs e)
        {
            plainPolybius.ReadOnly = polybiusDecryptRadio.Checked;
            cipherPolybius.ReadOnly = polybiusEncryptRadio.Checked;
        }

        private void plainPolybius_TextChanged(object sender, EventArgs e)
        {
            if (polybiusEncryptRadio.Checked) encryptPolybius();
        }

        private void cipherPolybius_TextChanged(object sender, EventArgs e)
        {
            if (polybiusDecryptRadio.Checked) decryptPolybius();
        }


        //
        // Polybius square list
        //
        private void initPolybiusList(int sz)
        {
            polybiusSquare.Clear();

            polybiusSquare.Columns.Add("", 20);
            for (int i = 0; i < sz; ++i)
            {
                polybiusSquare.Columns.Add((i + 1).ToString(), 25);
                polybiusSquare.Items.Add((i + 1).ToString());
            }

            string[] matrix = { };
            if (sz == 5)
            {
                matrix = new string[] { "abcde", "fghik", "lmnop", "qrstu", "vwxyz" };
            }
            else
            {
                matrix = new string[] { "abcdef", "ghijkl", "mnopqr", "stuvwx", "yz0123", "456789" };
            }

            for (int i = 0; i < sz; ++i)
            {
                for (int j = 0; j < sz; ++j)
                {
                    polybiusSquare.Items[i].SubItems.Add(matrix[i][j].ToString());
                }
            }
        }
        private void showEditBox(ListViewItem.ListViewSubItem sub)
        {
            //show box
            TextBox tb = new TextBox();
            tb.Tag = sub;
            tb.MaxLength = 1;
            tb.Text = sub.Text;
            tb.Font = sub.Font;
            tb.Bounds = sub.Bounds;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.TextAlign = HorizontalAlignment.Center;
            polybiusSquare.Controls.Add(tb);

            tb.Focus();
            tb.Leave += tb_Leave;
            tb.KeyDown += tb_KeyDown;
        }

        void tb_KeyDown(object obj, KeyEventArgs ex)
        {
            bool mov = false;
            int movx = 0, movy = 1;
            if (ex.KeyCode == Keys.Enter)
            {
                mov = true;
            }
            else if (ex.KeyCode == Keys.Up)
            {
                mov = true;
                movx = -1;
                movy = 0;
            }
            else if (ex.KeyCode == Keys.Down)
            {
                mov = true;
                movx = 1;
                movy = 0;
            }
            else if (ex.KeyCode == Keys.Left)
            {
                mov = true;
                movx = 0;
                movy = -1;
            }
            else if (ex.KeyCode == Keys.Right)
            {
                mov = true;
                movx = 0;
                movy = 1;
            }

            if (mov)
            {
                var tb = (TextBox)obj;
                var sub = (ListViewItem.ListViewSubItem)tb.Tag;
                select_next(sub, movx, movy);
                tb_Leave(obj, ex);
            }
        }

        void tb_Leave(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            var sub = (ListViewItem.ListViewSubItem)tb.Tag;
            bool changed = (sub.Text != tb.Text);
            sub.Text = tb.Text;
            polybiusSquare.Controls.Remove(tb);

            if (changed) doworkPolybius();
        }

        void select_next(ListViewItem.ListViewSubItem sub, int incx = 0, int incy = 1)
        {
            var lvi = polybiusSquare.GetItemAt(sub.Bounds.X, sub.Bounds.Y);

            int n = polybiusSquare.Items.Count;
            int m = lvi.SubItems.Count - 1;

            int x = lvi.Index + incx;
            int y = lvi.SubItems.IndexOf(sub) + incy - 1;
            if (y < 0) { --x; y = m - 1; }
            if (y >= m) { ++x; y = 0; }

            ++y;
            x = (x + n) % n;

            showEditBox(polybiusSquare.Items[x].SubItems[y]);
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the item at the mouse pointer.
            ListViewHitTestInfo info = polybiusSquare.HitTest(e.X, e.Y);

            // Show the edit box, if found. 
            if (info != null && info.SubItem != null)
            {
                showEditBox(info.SubItem);
            }
        }

        private void fivPolyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fivePolyCheck.Checked)
            {
                sixPolyCheck.Checked = false;
                initPolybiusList(5);
                doworkPolybius();
            }
        }

        private void sixPolyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sixPolyCheck.Checked)
            {
                fivePolyCheck.Checked = false;
                initPolybiusList(6);
                doworkPolybius();
            }
        }

        private void transposeButton_Click(object sender, EventArgs e)
        {
            int n = polybiusSquare.Items.Count;
            int m = polybiusSquare.Items[0].SubItems.Count;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 2; j < m; ++j)
                {
                    int x = j - 1;
                    int y = i + 1;
                    string a = polybiusSquare.Items[i].SubItems[j].Text;
                    string b = polybiusSquare.Items[x].SubItems[y].Text;
                    polybiusSquare.Items[i].SubItems[j].Text = b;
                    polybiusSquare.Items[x].SubItems[y].Text = a;
                }
            }

            doworkPolybius();
        }


        #endregion

        #region RSA Encryption

        private RSAInput rsaInput = new RSAInput();

        void showRSAKeys()
        {
            modulusRSA.Text = rsaInput.getN();
            firstPrimeRSA.Text = rsaInput.getP();
            secondPrimeRSA.Text = rsaInput.getQ();
            publicKeyRSA.Text = rsaInput.getE();
            privateKeyRSA.Text = rsaInput.getD();
        }

        public void processRsaInputs()
        {
            if (factorCheckRSA.Checked)
            {
                rsaInput.setP(firstPrimeRSA.Text);
                rsaInput.setQ(secondPrimeRSA.Text);
                rsaInput.setE(publicKeyRSA.Text);
                rsaInput.makeN();
                rsaInput.makeD();
                rsaInput.checkValidity();
            }
            else
            {
                rsaInput.setN(modulusRSA.Text);
                rsaInput.setE(publicKeyRSA.Text);
                rsaInput.setD(privateKeyRSA.Text);
            }
          
            showRSAKeys();
        }

        //
        // GUI Interactivity
        // 
        private void convertButtonRSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (encryptRadioRSA.Checked)
                {
                    processRsaInputs();
                    cipherRSA.Text = rsaInput.encrypt(plainRSA.Text);

                    cipherRSA.Text += Environment.NewLine;
                    cipherRSA.Text += Environment.NewLine;
                    cipherRSA.Text += Environment.NewLine;
                    cipherRSA.Text += "-----------------------------------------------";
                    cipherRSA.Text += Environment.NewLine;
                    cipherRSA.Text += "----------------- ENCRYPTION DATA -------------";
                    cipherRSA.Text += Environment.NewLine;
                    cipherRSA.Text += "N=" + rsaInput.getN() + Environment.NewLine;
                    cipherRSA.Text += "E=" + rsaInput.getE() + Environment.NewLine;
                    cipherRSA.Text += "D=" + rsaInput.getD() + Environment.NewLine;

                }
                else
                {
                    string text = cipherRSA.Text;
                    int last = text.IndexOf('\n');
                    int nstart = text.IndexOf("N=", last);
                    int estart = text.IndexOf("E=", nstart);
                    int dstart = text.IndexOf("D=", estart);

                    try
                    {
                        string N = text.Substring(nstart + 2, estart - nstart - 3).Trim();
                        string E = text.Substring(estart + 2, dstart - estart - 3).Trim();
                        string D = text.Substring(dstart + 2).Trim();
                        factorCheckRSA.Checked = false;
                        modulusRSA.Text = N;
                        publicKeyRSA.Text = E;
                        privateKeyRSA.Text = D;
                    }
                    catch { }

                    processRsaInputs();
                    plainRSA.Text = rsaInput.decrypt(text.Substring(0, text.IndexOf('\n')));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toggleRSA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(ofd.FileName);
                if (encryptRadioRSA.Checked)
                {
                    plainRSA.Text = text;
                }
                else
                {
                    cipherRSA.Text = text;
                }
            }
        }

        private void factorCheckRSA_CheckedChanged(object sender, EventArgs e)
        {
            modulusRSA.ReadOnly = factorCheckRSA.Checked;
            privateKeyRSA.ReadOnly = factorCheckRSA.Checked;
            primePanelRSA.Visible = factorCheckRSA.Checked;

            modulusRSA.Text = "";
            firstPrimeRSA.Text = "";
            secondPrimeRSA.Text = "";
            privateKeyRSA.Text = "";
        }

        private void randPrimeRSA_Click(object sender, EventArgs e)
        {
            rsaInput.randPQ();
            firstPrimeRSA.Text = rsaInput.getP();
            secondPrimeRSA.Text = rsaInput.getQ();
            modulusRSA.Text = rsaInput.getN();
        }

        private void randKeyRSA_Click(object sender, EventArgs e)
        {
            rsaInput.randE();
            publicKeyRSA.Text = rsaInput.getE();
            privateKeyRSA.Text = rsaInput.getD();
        }

        #endregion

        private void encryptRadioRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (encryptRadioRSA.Checked)
            {
                plainRSA.ReadOnly = false;
                cipherRSA.ReadOnly = true;
                convertButtonRSA.Text = "Encrypt";
            }
        }

        private void decryptRadioRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (decryptRadioRSA.Checked)
            {
                plainRSA.ReadOnly = true;
                cipherRSA.ReadOnly = false;
                convertButtonRSA.Text = "Decrypt";
            }
        }

        #region Mysterious Encryption

        #endregion

    }
}

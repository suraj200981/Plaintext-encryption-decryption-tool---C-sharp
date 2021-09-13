using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiphersWindowsApp;
using System.Text.RegularExpressions;


namespace CiphersInterface
{
    public partial class CaesarForm : Form
    {

        public string undoInput;

        public CaesarForm()
        {

        InitializeComponent();
            undoInput = "";
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu menu = new MainMenu();

            menu.ShowDialog();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {

            

            var caesar = new Caesar();
            var encodedPlaintext = caesar.Encode(inputTextBoxCeasar.Text, (int)keySelector.Value);

            outputText.Visible = true;
            btnOutputCopy.Visible = true;
            btnOutputTextOps.Visible = true;

            outputText.Text = encodedPlaintext;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(inputTextBoxCeasar.Text);
        }

        private void btnCaesarInputPaste_Click(object sender, EventArgs e)
        {
           inputTextBoxCeasar.Text = System.Windows.Forms.Clipboard.GetText();

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var caesar = new Caesar();
            var decodedPlaintext = caesar.Decode(inputTextBoxCeasar.Text, (int)keySelector.Value);

            outputText.Visible = true;
            btnOutputCopy.Visible = true;
            btnOutputTextOps.Visible = true;

            outputText.Text = decodedPlaintext;
        }

        private void btnAutosolve_Click(object sender, EventArgs e)
        {
            var caesar = new Caesar();
            var autoSolveResults = caesar.bruteForce(inputTextBoxCeasar.Text);

            outputText.Visible = true;
            btnOutputCopy.Visible = true;
            btnOutputTextOps.Visible = true;

            outputText.Text = autoSolveResults;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (inputTextBoxCeasar.Text.Equals("")) {

                MessageBox.Show("You cannot change the text options without entering any text!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                btnCaesarInputPaste.Visible = false;
                button1.Visible = false;
                button3.Visible = false;

                //show the text options
                btnHideTextOptions.Visible = true;
                btnRemoveSpaces.Visible = true;
                btnLettersOnly.Visible = true;
                btnReverse.Visible = true;
                btnUpper.Visible = true;
                btnLower.Visible = true;
                btnUndo.Visible = true;
                btn5Groups.Visible = true;


                //orignal string before text option modifications
                undoInput = inputTextBoxCeasar.Text;
            }
        }

        private void btnHideTextOptions_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            btnCaesarInputPaste.Visible = true;
            button3.Visible = true;

            //hide the text options
            btnHideTextOptions.Visible = false;
            btnRemoveSpaces.Visible = false;
            btnLettersOnly.Visible = false;
            btnReverse.Visible = false;
            btnUpper.Visible = false;
            btnLower.Visible = false;
            btnUndo.Visible = false;
            btn5Groups.Visible = false;

        }

        private void btnRemoveSpaces_Click(object sender, EventArgs e)
        {

            var originalText = inputTextBoxCeasar.Text;
            var caesar = new Caesar();
            var whiteSpacesRemoved = caesar.removeSpaces(inputTextBoxCeasar.Text);

            inputTextBoxCeasar.Text = whiteSpacesRemoved;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

            //orignal string before text option modifications
            inputTextBoxCeasar.Text = undoInput;


        }

        private void btnLettersOnly_Click(object sender, EventArgs e)
        {
            //  [a-zA - Z]

            StringBuilder sb = new StringBuilder();
            int counts = 0;

            Regex rx = new Regex("[a-zA - Z]",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(inputTextBoxCeasar.Text);

            foreach (Match match in matches)
            {

                GroupCollection groups = match.Groups;
                sb.Append(groups[0]);

                counts++;

            }

            inputTextBoxCeasar.Text = sb.ToString();

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            char[] arrayOfChars = inputTextBoxCeasar.Text.ToCharArray();

            Array.Reverse(arrayOfChars);

            for (int x = 0; x < arrayOfChars.Length; x++) {

                sb.Append(arrayOfChars[x]);
            }

            inputTextBoxCeasar.Text = sb.ToString();

        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            inputTextBoxCeasar.Text = inputTextBoxCeasar.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            inputTextBoxCeasar.Text = inputTextBoxCeasar.Text.ToLower();

        }

        private void btn5Groups_Click(object sender, EventArgs e)
        {

            btnRemoveSpaces.PerformClick();

            string str = inputTextBoxCeasar.Text;

            string temp;

            StringBuilder sb = new StringBuilder();

            //split into groups
            for (int i = 0; i < 5; i++)
            {
                temp = "";
                for (int x = i; x < str.Length; x = x + 10)
                {
                    temp += str[x];
                }
                sb.Append(temp+" | ");
            }

            inputTextBoxCeasar.Text = sb.ToString();
        }
    }
    }


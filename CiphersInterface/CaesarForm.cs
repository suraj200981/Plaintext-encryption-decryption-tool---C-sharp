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
    }
    }


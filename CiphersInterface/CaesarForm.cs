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
        public CaesarForm()
        {
            InitializeComponent();
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
    }
}

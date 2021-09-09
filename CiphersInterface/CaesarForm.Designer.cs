
namespace CiphersInterface
{
    partial class CaesarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBoxCeasar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCaesarInputPaste = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.keySelector = new System.Windows.Forms.NumericUpDown();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnAutosolve = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.btnOutputCopy = new System.Windows.Forms.Button();
            this.btnOutputTextOps = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caesar Cipher Tool";
            // 
            // inputTextBoxCeasar
            // 
            this.inputTextBoxCeasar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBoxCeasar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputTextBoxCeasar.Location = new System.Drawing.Point(32, 81);
            this.inputTextBoxCeasar.Name = "inputTextBoxCeasar";
            this.inputTextBoxCeasar.Size = new System.Drawing.Size(617, 111);
            this.inputTextBoxCeasar.TabIndex = 1;
            this.inputTextBoxCeasar.Text = "Enter text here...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCaesarInputPaste
            // 
            this.btnCaesarInputPaste.BackColor = System.Drawing.Color.Green;
            this.btnCaesarInputPaste.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaesarInputPaste.ForeColor = System.Drawing.Color.White;
            this.btnCaesarInputPaste.Location = new System.Drawing.Point(108, 198);
            this.btnCaesarInputPaste.Name = "btnCaesarInputPaste";
            this.btnCaesarInputPaste.Size = new System.Drawing.Size(70, 36);
            this.btnCaesarInputPaste.TabIndex = 3;
            this.btnCaesarInputPaste.Text = "Paste";
            this.btnCaesarInputPaste.UseVisualStyleBackColor = false;
            this.btnCaesarInputPaste.Click += new System.EventHandler(this.btnCaesarInputPaste_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(184, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Text Options...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // keySelector
            // 
            this.keySelector.Location = new System.Drawing.Point(32, 250);
            this.keySelector.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.keySelector.Name = "keySelector";
            this.keySelector.Size = new System.Drawing.Size(125, 20);
            this.keySelector.TabIndex = 5;
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Green;
            this.btnDecode.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(32, 285);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(70, 36);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.Green;
            this.btnEncode.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.Location = new System.Drawing.Point(108, 285);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(70, 36);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnAutosolve
            // 
            this.btnAutosolve.BackColor = System.Drawing.Color.Green;
            this.btnAutosolve.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutosolve.ForeColor = System.Drawing.Color.White;
            this.btnAutosolve.Location = new System.Drawing.Point(184, 285);
            this.btnAutosolve.Name = "btnAutosolve";
            this.btnAutosolve.Size = new System.Drawing.Size(222, 36);
            this.btnAutosolve.TabIndex = 8;
            this.btnAutosolve.Text = "Auto Solve (without key)";
            this.btnAutosolve.UseVisualStyleBackColor = false;
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Green;
            this.btnInstructions.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(412, 285);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(114, 36);
            this.btnInstructions.TabIndex = 9;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(32, 339);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(617, 74);
            this.outputText.TabIndex = 10;
            this.outputText.Text = "";
            this.outputText.Visible = false;
            // 
            // btnOutputCopy
            // 
            this.btnOutputCopy.BackColor = System.Drawing.Color.Green;
            this.btnOutputCopy.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputCopy.ForeColor = System.Drawing.Color.White;
            this.btnOutputCopy.Location = new System.Drawing.Point(32, 419);
            this.btnOutputCopy.Name = "btnOutputCopy";
            this.btnOutputCopy.Size = new System.Drawing.Size(70, 36);
            this.btnOutputCopy.TabIndex = 11;
            this.btnOutputCopy.Text = "Copy";
            this.btnOutputCopy.UseVisualStyleBackColor = false;
            this.btnOutputCopy.Visible = false;
            // 
            // btnOutputTextOps
            // 
            this.btnOutputTextOps.BackColor = System.Drawing.Color.Green;
            this.btnOutputTextOps.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputTextOps.ForeColor = System.Drawing.Color.White;
            this.btnOutputTextOps.Location = new System.Drawing.Point(108, 419);
            this.btnOutputTextOps.Name = "btnOutputTextOps";
            this.btnOutputTextOps.Size = new System.Drawing.Size(128, 36);
            this.btnOutputTextOps.TabIndex = 12;
            this.btnOutputTextOps.Text = "Text Options...";
            this.btnOutputTextOps.UseVisualStyleBackColor = false;
            this.btnOutputTextOps.Visible = false;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.OldLace;
            this.btnBackToMenu.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(547, 471);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(131, 37);
            this.btnBackToMenu.TabIndex = 13;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // CaesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 530);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnOutputTextOps);
            this.Controls.Add(this.btnOutputCopy);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnAutosolve);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.keySelector);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCaesarInputPaste);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTextBoxCeasar);
            this.Controls.Add(this.label1);
            this.Name = "CaesarForm";
            this.Text = "CaesarForm";
            ((System.ComponentModel.ISupportInitialize)(this.keySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputTextBoxCeasar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCaesarInputPaste;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown keySelector;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnAutosolve;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button btnOutputCopy;
        private System.Windows.Forms.Button btnOutputTextOps;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
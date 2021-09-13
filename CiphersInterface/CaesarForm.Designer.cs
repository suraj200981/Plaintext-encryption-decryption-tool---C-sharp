
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
            this.btnHideTextOptions = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btn5Groups = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLettersOnly = new System.Windows.Forms.Button();
            this.btnRemoveSpaces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caesar Cipher Tool";
            // 
            // inputTextBoxCeasar
            // 
            this.inputTextBoxCeasar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBoxCeasar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputTextBoxCeasar.Location = new System.Drawing.Point(43, 100);
            this.inputTextBoxCeasar.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBoxCeasar.Name = "inputTextBoxCeasar";
            this.inputTextBoxCeasar.Size = new System.Drawing.Size(821, 136);
            this.inputTextBoxCeasar.TabIndex = 1;
            this.inputTextBoxCeasar.Text = "Enter text here...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
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
            this.btnCaesarInputPaste.Location = new System.Drawing.Point(144, 244);
            this.btnCaesarInputPaste.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaesarInputPaste.Name = "btnCaesarInputPaste";
            this.btnCaesarInputPaste.Size = new System.Drawing.Size(93, 44);
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
            this.button3.Location = new System.Drawing.Point(245, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Text Options...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // keySelector
            // 
            this.keySelector.Location = new System.Drawing.Point(43, 308);
            this.keySelector.Margin = new System.Windows.Forms.Padding(4);
            this.keySelector.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.keySelector.Name = "keySelector";
            this.keySelector.Size = new System.Drawing.Size(167, 22);
            this.keySelector.TabIndex = 5;
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Green;
            this.btnDecode.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(43, 351);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(93, 44);
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
            this.btnEncode.Location = new System.Drawing.Point(144, 351);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(93, 44);
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
            this.btnAutosolve.Location = new System.Drawing.Point(245, 351);
            this.btnAutosolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutosolve.Name = "btnAutosolve";
            this.btnAutosolve.Size = new System.Drawing.Size(296, 44);
            this.btnAutosolve.TabIndex = 8;
            this.btnAutosolve.Text = "Auto Solve (without key)";
            this.btnAutosolve.UseVisualStyleBackColor = false;
            this.btnAutosolve.Click += new System.EventHandler(this.btnAutosolve_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Green;
            this.btnInstructions.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(549, 351);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(152, 44);
            this.btnInstructions.TabIndex = 9;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(43, 417);
            this.outputText.Margin = new System.Windows.Forms.Padding(4);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(821, 90);
            this.outputText.TabIndex = 10;
            this.outputText.Text = "";
            this.outputText.Visible = false;
            // 
            // btnOutputCopy
            // 
            this.btnOutputCopy.BackColor = System.Drawing.Color.Green;
            this.btnOutputCopy.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputCopy.ForeColor = System.Drawing.Color.White;
            this.btnOutputCopy.Location = new System.Drawing.Point(43, 516);
            this.btnOutputCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutputCopy.Name = "btnOutputCopy";
            this.btnOutputCopy.Size = new System.Drawing.Size(93, 44);
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
            this.btnOutputTextOps.Location = new System.Drawing.Point(144, 516);
            this.btnOutputTextOps.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutputTextOps.Name = "btnOutputTextOps";
            this.btnOutputTextOps.Size = new System.Drawing.Size(171, 44);
            this.btnOutputTextOps.TabIndex = 12;
            this.btnOutputTextOps.Text = "Text Options...";
            this.btnOutputTextOps.UseVisualStyleBackColor = false;
            this.btnOutputTextOps.Visible = false;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.OldLace;
            this.btnBackToMenu.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(729, 580);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(175, 46);
            this.btnBackToMenu.TabIndex = 13;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnHideTextOptions
            // 
            this.btnHideTextOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHideTextOptions.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideTextOptions.ForeColor = System.Drawing.Color.White;
            this.btnHideTextOptions.Location = new System.Drawing.Point(783, 295);
            this.btnHideTextOptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideTextOptions.Name = "btnHideTextOptions";
            this.btnHideTextOptions.Size = new System.Drawing.Size(83, 44);
            this.btnHideTextOptions.TabIndex = 14;
            this.btnHideTextOptions.Text = "Hide";
            this.btnHideTextOptions.UseVisualStyleBackColor = false;
            this.btnHideTextOptions.Visible = false;
            this.btnHideTextOptions.Click += new System.EventHandler(this.btnHideTextOptions_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Green;
            this.btnUndo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(783, 244);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(83, 44);
            this.btnUndo.TabIndex = 15;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btn5Groups
            // 
            this.btn5Groups.BackColor = System.Drawing.Color.Green;
            this.btn5Groups.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Groups.ForeColor = System.Drawing.Color.White;
            this.btn5Groups.Location = new System.Drawing.Point(656, 244);
            this.btn5Groups.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Groups.Name = "btn5Groups";
            this.btn5Groups.Size = new System.Drawing.Size(119, 44);
            this.btn5Groups.TabIndex = 16;
            this.btn5Groups.Text = "5-groups";
            this.btn5Groups.UseVisualStyleBackColor = false;
            this.btn5Groups.Visible = false;
            // 
            // btnLower
            // 
            this.btnLower.BackColor = System.Drawing.Color.Green;
            this.btnLower.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.ForeColor = System.Drawing.Color.White;
            this.btnLower.Location = new System.Drawing.Point(559, 244);
            this.btnLower.Margin = new System.Windows.Forms.Padding(4);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(89, 44);
            this.btnLower.TabIndex = 17;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = false;
            this.btnLower.Visible = false;
            // 
            // btnUpper
            // 
            this.btnUpper.BackColor = System.Drawing.Color.Green;
            this.btnUpper.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpper.ForeColor = System.Drawing.Color.White;
            this.btnUpper.Location = new System.Drawing.Point(461, 244);
            this.btnUpper.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(89, 44);
            this.btnUpper.TabIndex = 18;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = false;
            this.btnUpper.Visible = false;
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.Green;
            this.btnReverse.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.ForeColor = System.Drawing.Color.White;
            this.btnReverse.Location = new System.Drawing.Point(357, 244);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(96, 44);
            this.btnReverse.TabIndex = 19;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Visible = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnLettersOnly
            // 
            this.btnLettersOnly.BackColor = System.Drawing.Color.Green;
            this.btnLettersOnly.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLettersOnly.ForeColor = System.Drawing.Color.White;
            this.btnLettersOnly.Location = new System.Drawing.Point(211, 244);
            this.btnLettersOnly.Margin = new System.Windows.Forms.Padding(4);
            this.btnLettersOnly.Name = "btnLettersOnly";
            this.btnLettersOnly.Size = new System.Drawing.Size(139, 44);
            this.btnLettersOnly.TabIndex = 20;
            this.btnLettersOnly.Text = "Letters only";
            this.btnLettersOnly.UseVisualStyleBackColor = false;
            this.btnLettersOnly.Visible = false;
            this.btnLettersOnly.Click += new System.EventHandler(this.btnLettersOnly_Click);
            // 
            // btnRemoveSpaces
            // 
            this.btnRemoveSpaces.BackColor = System.Drawing.Color.Green;
            this.btnRemoveSpaces.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSpaces.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSpaces.Location = new System.Drawing.Point(43, 244);
            this.btnRemoveSpaces.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSpaces.Name = "btnRemoveSpaces";
            this.btnRemoveSpaces.Size = new System.Drawing.Size(167, 44);
            this.btnRemoveSpaces.TabIndex = 21;
            this.btnRemoveSpaces.Text = "Remove Spaces";
            this.btnRemoveSpaces.UseVisualStyleBackColor = false;
            this.btnRemoveSpaces.Visible = false;
            this.btnRemoveSpaces.Click += new System.EventHandler(this.btnRemoveSpaces_Click);
            // 
            // CaesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 652);
            this.Controls.Add(this.btnRemoveSpaces);
            this.Controls.Add(this.btnLettersOnly);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btn5Groups);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnHideTextOptions);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnHideTextOptions;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btn5Groups;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnLettersOnly;
        private System.Windows.Forms.Button btnRemoveSpaces;
    }
}
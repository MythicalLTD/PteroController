namespace PteroController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnclear = new Button();
            txtpanelurl = new TextBox();
            txtpanelapikey = new TextBox();
            txtsvid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnexit = new Button();
            coutput = new ConsoleControl.ConsoleControl();
            SuspendLayout();
            // 
            // btnclear
            // 
            btnclear.Location = new Point(713, 253);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 2;
            btnclear.Text = "Fetch";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // txtpanelurl
            // 
            txtpanelurl.Location = new Point(12, 24);
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.Size = new Size(257, 23);
            txtpanelurl.TabIndex = 3;
            // 
            // txtpanelapikey
            // 
            txtpanelapikey.Location = new Point(275, 24);
            txtpanelapikey.Name = "txtpanelapikey";
            txtpanelapikey.Size = new Size(257, 23);
            txtpanelapikey.TabIndex = 4;
            txtpanelapikey.UseSystemPasswordChar = true;
            // 
            // txtsvid
            // 
            txtsvid.Location = new Point(538, 24);
            txtsvid.Name = "txtsvid";
            txtsvid.Size = new Size(257, 23);
            txtsvid.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(538, 6);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Server ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Panel URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 6);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "Panel API KEY:";
            // 
            // btnexit
            // 
            btnexit.Location = new Point(12, 253);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 8;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // coutput
            // 
            coutput.IsInputEnabled = true;
            coutput.Location = new Point(12, 53);
            coutput.Margin = new Padding(4, 3, 4, 3);
            coutput.Name = "coutput";
            coutput.SendKeyboardCommandsToProcess = false;
            coutput.ShowDiagnostics = false;
            coutput.Size = new Size(776, 194);
            coutput.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 284);
            Controls.Add(coutput);
            Controls.Add(btnexit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsvid);
            Controls.Add(txtpanelapikey);
            Controls.Add(txtpanelurl);
            Controls.Add(btnclear);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtnonclean;
        private Button btnclear;
        private TextBox txtpanelurl;
        private TextBox txtpanelapikey;
        private TextBox txtsvid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnexit;
        private ConsoleControl.ConsoleControl coutput;
    }
}
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
            txtpanelurl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtclientkey = new TextBox();
            label3 = new Label();
            txtsvid = new TextBox();
            btnfetch = new Button();
            SuspendLayout();
            // 
            // txtpanelurl
            // 
            txtpanelurl.Location = new Point(3, 22);
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.Size = new Size(180, 23);
            txtpanelurl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Panel URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Client Key:";
            // 
            // txtclientkey
            // 
            txtclientkey.Location = new Point(3, 66);
            txtclientkey.Name = "txtclientkey";
            txtclientkey.Size = new Size(180, 23);
            txtclientkey.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Server ID:";
            // 
            // txtsvid
            // 
            txtsvid.Location = new Point(3, 110);
            txtsvid.Name = "txtsvid";
            txtsvid.Size = new Size(180, 23);
            txtsvid.TabIndex = 4;
            // 
            // btnfetch
            // 
            btnfetch.Location = new Point(54, 148);
            btnfetch.Name = "btnfetch";
            btnfetch.Size = new Size(75, 23);
            btnfetch.TabIndex = 6;
            btnfetch.Text = "Fetch";
            btnfetch.UseVisualStyleBackColor = true;
            btnfetch.Click += btnfetch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfetch);
            Controls.Add(label3);
            Controls.Add(txtsvid);
            Controls.Add(label2);
            Controls.Add(txtclientkey);
            Controls.Add(label1);
            Controls.Add(txtpanelurl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpanelurl;
        private Label label1;
        private Label label2;
        private TextBox txtclientkey;
        private Label label3;
        private TextBox txtsvid;
        private Button btnfetch;
    }
}
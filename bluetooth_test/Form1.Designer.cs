namespace bluetooth_test
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
            this.btRead = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btObfuscate = new System.Windows.Forms.Button();
            this.lbRead = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.lbExport = new System.Windows.Forms.Label();
            this.lbObfuscate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(8, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 105);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(12, 214);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 2;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btObfuscate
            // 
            this.btObfuscate.Location = new System.Drawing.Point(12, 317);
            this.btObfuscate.Name = "btObfuscate";
            this.btObfuscate.Size = new System.Drawing.Size(75, 23);
            this.btObfuscate.TabIndex = 3;
            this.btObfuscate.Text = "Obfuscate";
            this.btObfuscate.UseVisualStyleBackColor = true;
            this.btObfuscate.Click += new System.EventHandler(this.btObfuscate_Click);
            // 
            // lbRead
            // 
            this.lbRead.AutoSize = true;
            this.lbRead.Location = new System.Drawing.Point(12, 38);
            this.lbRead.Name = "lbRead";
            this.lbRead.Size = new System.Drawing.Size(38, 15);
            this.lbRead.TabIndex = 4;
            this.lbRead.Text = "label1";
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(12, 131);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(38, 15);
            this.lbSave.TabIndex = 5;
            this.lbSave.Text = "label2";
            // 
            // lbExport
            // 
            this.lbExport.AutoSize = true;
            this.lbExport.Location = new System.Drawing.Point(12, 240);
            this.lbExport.Name = "lbExport";
            this.lbExport.Size = new System.Drawing.Size(38, 15);
            this.lbExport.TabIndex = 6;
            this.lbExport.Text = "label3";
            // 
            // lbObfuscate
            // 
            this.lbObfuscate.AutoSize = true;
            this.lbObfuscate.Location = new System.Drawing.Point(12, 343);
            this.lbObfuscate.Name = "lbObfuscate";
            this.lbObfuscate.Size = new System.Drawing.Size(38, 15);
            this.lbObfuscate.TabIndex = 7;
            this.lbObfuscate.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbObfuscate);
            this.Controls.Add(this.lbExport);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.lbRead);
            this.Controls.Add(this.btObfuscate);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btRead;
        private Button btSave;
        private Button btExport;
        private Button btObfuscate;
        private Label lbRead;
        private Label lbSave;
        private Label lbExport;
        private Label lbObfuscate;
    }
}
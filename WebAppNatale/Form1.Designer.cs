namespace WebAppNatale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UsernameLogin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registrazione = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.Location = new System.Drawing.Point(315, 144);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(162, 20);
            this.UsernameLogin.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(315, 192);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.PasswordChar = '*';
            this.PasswordLogin.Size = new System.Drawing.Size(162, 20);
            this.PasswordLogin.TabIndex = 2;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(336, 248);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(113, 23);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // Registrazione
            // 
            this.Registrazione.AutoSize = true;
            this.Registrazione.Location = new System.Drawing.Point(374, 288);
            this.Registrazione.Name = "Registrazione";
            this.Registrazione.Size = new System.Drawing.Size(51, 13);
            this.Registrazione.TabIndex = 7;
            this.Registrazione.TabStop = true;
            this.Registrazione.Text = "Registrati";
            this.Registrazione.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registrazione_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrazione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsernameLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Registrazione;
    }
}


namespace POS_project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.buttlogin = new System.Windows.Forms.Button();
            this.buttreset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            resources.ApplyResources(this.txtuser, "txtuser");
            this.txtuser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtuser.Name = "txtuser";
            // 
            // txtpass
            // 
            resources.ApplyResources(this.txtpass, "txtpass");
            this.txtpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpass.Name = "txtpass";
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // buttlogin
            // 
            this.buttlogin.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.buttlogin, "buttlogin");
            this.buttlogin.Name = "buttlogin";
            this.buttlogin.UseVisualStyleBackColor = false;
            this.buttlogin.Click += new System.EventHandler(this.buttlogin_Click);
            // 
            // buttreset
            // 
            this.buttreset.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.buttreset, "buttreset");
            this.buttreset.Name = "buttreset";
            this.buttreset.UseVisualStyleBackColor = false;
            this.buttreset.Click += new System.EventHandler(this.buttreset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_project.Properties.Resources._89968732_491600888182122_2233752279503077376_n;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POS_project.Properties.Resources._90087942_632695984190938_1358089876133642240_n;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_project.Properties.Resources.clouds_2;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_project.Properties.Resources.clouds_1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.buttexit, "buttexit");
            this.buttexit.Name = "buttexit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttreset);
            this.Controls.Add(this.buttlogin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttlogin;
        private System.Windows.Forms.Button buttreset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


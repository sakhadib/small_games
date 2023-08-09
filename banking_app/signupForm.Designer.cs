namespace banking_app
{
    partial class signupForm
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
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.uname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_pass_tb = new System.Windows.Forms.TextBox();
            this.sun_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.Location = new System.Drawing.Point(390, 162);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(231, 31);
            this.pass_tb.TabIndex = 4;
            // 
            // uname_tb
            // 
            this.uname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_tb.Location = new System.Drawing.Point(390, 105);
            this.uname_tb.Name = "uname_tb";
            this.uname_tb.Size = new System.Drawing.Size(231, 31);
            this.uname_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Pass";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // c_pass_tb
            // 
            this.c_pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_pass_tb.Location = new System.Drawing.Point(390, 224);
            this.c_pass_tb.Name = "c_pass_tb";
            this.c_pass_tb.Size = new System.Drawing.Size(231, 31);
            this.c_pass_tb.TabIndex = 4;
            // 
            // sun_btn
            // 
            this.sun_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sun_btn.Location = new System.Drawing.Point(380, 316);
            this.sun_btn.Name = "sun_btn";
            this.sun_btn.Size = new System.Drawing.Size(121, 51);
            this.sun_btn.TabIndex = 6;
            this.sun_btn.Text = "signup";
            this.sun_btn.UseVisualStyleBackColor = true;
            this.sun_btn.Click += new System.EventHandler(this.sun_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sun_btn);
            this.Controls.Add(this.c_pass_tb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uname_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "signupForm";
            this.Text = "signupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox uname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_pass_tb;
        private System.Windows.Forms.Button sun_btn;
        private System.Windows.Forms.Button button1;
    }
}
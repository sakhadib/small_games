namespace tic_tac_toe
{
    partial class congo
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.p1_pt = new System.Windows.Forms.Label();
            this.p2_pt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "congratulations";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(127, 117);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(369, 39);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Player 1 won the game";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(248, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "points so far";
            // 
            // p1_pt
            // 
            this.p1_pt.AutoSize = true;
            this.p1_pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_pt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.p1_pt.Location = new System.Drawing.Point(163, 234);
            this.p1_pt.Name = "p1_pt";
            this.p1_pt.Size = new System.Drawing.Size(110, 24);
            this.p1_pt.TabIndex = 0;
            this.p1_pt.Text = "points so far";
            // 
            // p2_pt
            // 
            this.p2_pt.AutoSize = true;
            this.p2_pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_pt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.p2_pt.Location = new System.Drawing.Point(328, 234);
            this.p2_pt.Name = "p2_pt";
            this.p2_pt.Size = new System.Drawing.Size(110, 24);
            this.p2_pt.TabIndex = 0;
            this.p2_pt.Text = "points so far";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(251, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "EXIT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // congo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 494);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.p2_pt);
            this.Controls.Add(this.p1_pt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "congo";
            this.Text = "congo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p1_pt;
        private System.Windows.Forms.Label p2_pt;
        private System.Windows.Forms.Label label3;
    }
}
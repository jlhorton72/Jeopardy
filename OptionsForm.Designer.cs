namespace FinalHandsOnJeapordy_Jim_Horton
{
    partial class OptionsForm
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
            this.txtBxNumPlyrs = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblPlyr1 = new System.Windows.Forms.Label();
            this.lblPlyr2 = new System.Windows.Forms.Label();
            this.lblPlyr3 = new System.Windows.Forms.Label();
            this.txtBxPlyr1 = new System.Windows.Forms.TextBox();
            this.txtBxPlyr2 = new System.Windows.Forms.TextBox();
            this.txtBxPlyr3 = new System.Windows.Forms.TextBox();
            this.btnNumPlayers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Many Players:  (1-3)";
            // 
            // txtBxNumPlyrs
            // 
            this.txtBxNumPlyrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBxNumPlyrs.Location = new System.Drawing.Point(279, 86);
            this.txtBxNumPlyrs.Name = "txtBxNumPlyrs";
            this.txtBxNumPlyrs.Size = new System.Drawing.Size(175, 29);
            this.txtBxNumPlyrs.TabIndex = 1;
            this.txtBxNumPlyrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxNumPlyrs.TextChanged += new System.EventHandler(this.txtBxNumPlyrs_TextChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(166, 236);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(52, 23);
            this.lblTest.TabIndex = 2;
            this.lblTest.Text = "label2";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // lblPlyr1
            // 
            this.lblPlyr1.AutoSize = true;
            this.lblPlyr1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr1.Location = new System.Drawing.Point(113, 317);
            this.lblPlyr1.Name = "lblPlyr1";
            this.lblPlyr1.Size = new System.Drawing.Size(141, 23);
            this.lblPlyr1.TabIndex = 3;
            this.lblPlyr1.Text = "Name of Player 1:";
            this.lblPlyr1.Visible = false;
            // 
            // lblPlyr2
            // 
            this.lblPlyr2.AutoSize = true;
            this.lblPlyr2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr2.Location = new System.Drawing.Point(113, 369);
            this.lblPlyr2.Name = "lblPlyr2";
            this.lblPlyr2.Size = new System.Drawing.Size(141, 23);
            this.lblPlyr2.TabIndex = 4;
            this.lblPlyr2.Text = "Name of Player 2:";
            this.lblPlyr2.Visible = false;
            this.lblPlyr2.Click += new System.EventHandler(this.lblPlyr2_Click);
            // 
            // lblPlyr3
            // 
            this.lblPlyr3.AutoSize = true;
            this.lblPlyr3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr3.Location = new System.Drawing.Point(113, 421);
            this.lblPlyr3.Name = "lblPlyr3";
            this.lblPlyr3.Size = new System.Drawing.Size(145, 23);
            this.lblPlyr3.TabIndex = 5;
            this.lblPlyr3.Text = "Name of Player 3: ";
            this.lblPlyr3.Visible = false;
            // 
            // txtBxPlyr1
            // 
            this.txtBxPlyr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBxPlyr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxPlyr1.ForeColor = System.Drawing.Color.Black;
            this.txtBxPlyr1.Location = new System.Drawing.Point(279, 314);
            this.txtBxPlyr1.Name = "txtBxPlyr1";
            this.txtBxPlyr1.Size = new System.Drawing.Size(175, 29);
            this.txtBxPlyr1.TabIndex = 6;
            this.txtBxPlyr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPlyr1.Visible = false;
            // 
            // txtBxPlyr2
            // 
            this.txtBxPlyr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBxPlyr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxPlyr2.ForeColor = System.Drawing.Color.Black;
            this.txtBxPlyr2.Location = new System.Drawing.Point(279, 366);
            this.txtBxPlyr2.Name = "txtBxPlyr2";
            this.txtBxPlyr2.Size = new System.Drawing.Size(175, 29);
            this.txtBxPlyr2.TabIndex = 7;
            this.txtBxPlyr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPlyr2.Visible = false;
            // 
            // txtBxPlyr3
            // 
            this.txtBxPlyr3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBxPlyr3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxPlyr3.ForeColor = System.Drawing.Color.Black;
            this.txtBxPlyr3.Location = new System.Drawing.Point(279, 418);
            this.txtBxPlyr3.Name = "txtBxPlyr3";
            this.txtBxPlyr3.Size = new System.Drawing.Size(175, 29);
            this.txtBxPlyr3.TabIndex = 8;
            this.txtBxPlyr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPlyr3.Visible = false;
            // 
            // btnNumPlayers
            // 
            this.btnNumPlayers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNumPlayers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPlayers.ForeColor = System.Drawing.Color.White;
            this.btnNumPlayers.Location = new System.Drawing.Point(315, 130);
            this.btnNumPlayers.Name = "btnNumPlayers";
            this.btnNumPlayers.Size = new System.Drawing.Size(106, 65);
            this.btnNumPlayers.TabIndex = 2;
            this.btnNumPlayers.Text = "Enter Number";
            this.btnNumPlayers.UseVisualStyleBackColor = false;
            this.btnNumPlayers.Click += new System.EventHandler(this.btnNumPlayers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter Name(s)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(703, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNumPlayers);
            this.Controls.Add(this.txtBxPlyr3);
            this.Controls.Add(this.txtBxPlyr2);
            this.Controls.Add(this.txtBxPlyr1);
            this.Controls.Add(this.lblPlyr3);
            this.Controls.Add(this.lblPlyr2);
            this.Controls.Add(this.lblPlyr1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtBxNumPlyrs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNumPlyrs;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblPlyr1;
        private System.Windows.Forms.Label lblPlyr2;
        private System.Windows.Forms.Label lblPlyr3;
        private System.Windows.Forms.TextBox txtBxPlyr1;
        private System.Windows.Forms.TextBox txtBxPlyr2;
        private System.Windows.Forms.TextBox txtBxPlyr3;
        private System.Windows.Forms.Button btnNumPlayers;
        private System.Windows.Forms.Button button1;
    }
}
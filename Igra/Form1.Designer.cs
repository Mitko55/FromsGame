
namespace Igra
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btntoForm2 = new System.Windows.Forms.Button();
            this.imgKid = new System.Windows.Forms.PictureBox();
            this.btntoForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgKid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(76, 325);
            this.lbl1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(40);
            this.lbl1.Size = new System.Drawing.Size(701, 113);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "You are lost in the forest OH NOOO";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btntoForm2
            // 
            this.btntoForm2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntoForm2.Location = new System.Drawing.Point(552, 31);
            this.btntoForm2.Name = "btntoForm2";
            this.btntoForm2.Size = new System.Drawing.Size(225, 59);
            this.btntoForm2.TabIndex = 2;
            this.btntoForm2.Text = "Search for help";
            this.btntoForm2.UseVisualStyleBackColor = true;
            this.btntoForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgKid
            // 
            this.imgKid.Image = global::Igra.Properties.Resources.png_transparent_captain_hook_lost_boys_neverland_peter_pan_tinker_bell_peter_pan_child_hand_toddler1;
            this.imgKid.Location = new System.Drawing.Point(301, 31);
            this.imgKid.Name = "imgKid";
            this.imgKid.Size = new System.Drawing.Size(207, 253);
            this.imgKid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKid.TabIndex = 3;
            this.imgKid.TabStop = false;
            this.imgKid.Click += new System.EventHandler(this.imgKid_Click_1);
            // 
            // btntoForm3
            // 
            this.btntoForm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntoForm3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntoForm3.Location = new System.Drawing.Point(552, 129);
            this.btntoForm3.Name = "btntoForm3";
            this.btntoForm3.Size = new System.Drawing.Size(225, 71);
            this.btntoForm3.TabIndex = 4;
            this.btntoForm3.Text = "Stay here and wait for your dad to save you!";
            this.btntoForm3.UseVisualStyleBackColor = true;
            this.btntoForm3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igra.Properties.Resources.rs930_135120665_low;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntoForm3);
            this.Controls.Add(this.imgKid);
            this.Controls.Add(this.btntoForm2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgKid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btntoForm2;
        private System.Windows.Forms.PictureBox imgKid;
        private System.Windows.Forms.Button btntoForm3;
    }
}


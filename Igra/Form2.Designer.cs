
namespace Igra
{
    partial class Form2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btntoForm5 = new System.Windows.Forms.Button();
            this.btntoForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(91, 263);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(40);
            this.lbl1.Size = new System.Drawing.Size(626, 178);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "You walk around the forest searching for help. Its soo cold... Its dark... You he" +
    "ar something in the bushes! Do you want to check it?";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btntoForm5
            // 
            this.btntoForm5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntoForm5.Location = new System.Drawing.Point(531, 114);
            this.btntoForm5.Name = "btntoForm5";
            this.btntoForm5.Size = new System.Drawing.Size(186, 68);
            this.btntoForm5.TabIndex = 1;
            this.btntoForm5.Text = "Pass it";
            this.btntoForm5.UseVisualStyleBackColor = true;
            this.btntoForm5.Click += new System.EventHandler(this.btntoForm5_Click);
            // 
            // btntoForm4
            // 
            this.btntoForm4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntoForm4.Location = new System.Drawing.Point(91, 114);
            this.btntoForm4.Name = "btntoForm4";
            this.btntoForm4.Size = new System.Drawing.Size(190, 68);
            this.btntoForm4.TabIndex = 2;
            this.btntoForm4.Text = "Check it!";
            this.btntoForm4.UseVisualStyleBackColor = true;
            this.btntoForm4.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igra.Properties.Resources.fikran_hadinata_dark_forest_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntoForm4);
            this.Controls.Add(this.btntoForm5);
            this.Controls.Add(this.lbl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btntoForm5;
        private System.Windows.Forms.Button btntoForm4;
    }
}
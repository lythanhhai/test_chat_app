﻿
namespace PBL4_Chat.View
{
    partial class group_info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(group_info));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbDes = new Guna.UI.WinForms.GunaLabel();
            this.lbNameGroup = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.lbDes);
            this.gunaGradientPanel1.Controls.Add(this.lbNameGroup);
            this.gunaGradientPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(206)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(384, 95);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.BackColor = System.Drawing.Color.Transparent;
            this.lbDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbDes.ForeColor = System.Drawing.Color.White;
            this.lbDes.Location = new System.Drawing.Point(80, 54);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(125, 25);
            this.lbDes.TabIndex = 5;
            this.lbDes.Text = "this is a group";
            // 
            // lbNameGroup
            // 
            this.lbNameGroup.AutoSize = true;
            this.lbNameGroup.BackColor = System.Drawing.Color.Transparent;
            this.lbNameGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNameGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbNameGroup.ForeColor = System.Drawing.Color.White;
            this.lbNameGroup.Location = new System.Drawing.Point(80, 16);
            this.lbNameGroup.Name = "lbNameGroup";
            this.lbNameGroup.Size = new System.Drawing.Size(79, 25);
            this.lbNameGroup.TabIndex = 4;
            this.lbNameGroup.Text = "Group A";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(15, 16);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(59, 63);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 3;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // group_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "group_info";
            this.Size = new System.Drawing.Size(384, 95);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel lbDes;
        private Guna.UI.WinForms.GunaLabel lbNameGroup;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
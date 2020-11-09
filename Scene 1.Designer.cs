namespace RPGFormAppStuffThing
{
    partial class Scene_1
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
            this.grpCharInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblPerception = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCharInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCharInfo
            // 
            this.grpCharInfo.Controls.Add(this.lblName);
            this.grpCharInfo.Controls.Add(this.lblLuck);
            this.grpCharInfo.Controls.Add(this.lblIntelligence);
            this.grpCharInfo.Controls.Add(this.lblPerception);
            this.grpCharInfo.Controls.Add(this.lblStrength);
            this.grpCharInfo.Controls.Add(this.pictureBox1);
            this.grpCharInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCharInfo.Name = "grpCharInfo";
            this.grpCharInfo.Size = new System.Drawing.Size(178, 282);
            this.grpCharInfo.TabIndex = 0;
            this.grpCharInfo.TabStop = false;
            this.grpCharInfo.Text = "Character Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(20, 133);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(48, 15);
            this.lblStrength.TabIndex = 1;
            this.lblStrength.Text = "label1";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerception.Location = new System.Drawing.Point(20, 148);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(48, 15);
            this.lblPerception.TabIndex = 2;
            this.lblPerception.Text = "label1";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.Location = new System.Drawing.Point(20, 163);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(48, 15);
            this.lblIntelligence.TabIndex = 3;
            this.lblIntelligence.Text = "label1";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuck.Location = new System.Drawing.Point(20, 178);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(48, 15);
            this.lblLuck.TabIndex = 4;
            this.lblLuck.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 204);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label1";
            // 
            // Scene_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 309);
            this.Controls.Add(this.grpCharInfo);
            this.Name = "Scene_1";
            this.Text = "Scene_1";
            this.Load += new System.EventHandler(this.Scene_1_Load);
            this.grpCharInfo.ResumeLayout(false);
            this.grpCharInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCharInfo;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblPerception;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
    }
}
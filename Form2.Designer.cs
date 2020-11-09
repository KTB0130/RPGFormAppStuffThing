namespace RPGFormAppStuffThing
{
    partial class CharacterCreation
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
            this.pcbCharacter = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStrength = new System.Windows.Forms.ComboBox();
            this.cmbPerception = new System.Windows.Forms.ComboBox();
            this.cmbIntelligence = new System.Windows.Forms.ComboBox();
            this.cmbLuck = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.btnConfirmCharacter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strength";
            // 
            // pcbCharacter
            // 
            this.pcbCharacter.Location = new System.Drawing.Point(391, 12);
            this.pcbCharacter.Name = "pcbCharacter";
            this.pcbCharacter.Size = new System.Drawing.Size(164, 141);
            this.pcbCharacter.TabIndex = 2;
            this.pcbCharacter.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perception";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intelligence";
            // 
            // cmbStrength
            // 
            this.cmbStrength.FormattingEnabled = true;
            this.cmbStrength.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbStrength.Location = new System.Drawing.Point(133, 42);
            this.cmbStrength.Name = "cmbStrength";
            this.cmbStrength.Size = new System.Drawing.Size(100, 21);
            this.cmbStrength.TabIndex = 5;
            this.cmbStrength.SelectedIndexChanged += new System.EventHandler(this.cmbStrength_SelectedIndexChanged);
            // 
            // cmbPerception
            // 
            this.cmbPerception.FormattingEnabled = true;
            this.cmbPerception.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPerception.Location = new System.Drawing.Point(133, 76);
            this.cmbPerception.Name = "cmbPerception";
            this.cmbPerception.Size = new System.Drawing.Size(100, 21);
            this.cmbPerception.TabIndex = 6;
            this.cmbPerception.SelectedIndexChanged += new System.EventHandler(this.cmbPerception_SelectedIndexChanged);
            // 
            // cmbIntelligence
            // 
            this.cmbIntelligence.FormattingEnabled = true;
            this.cmbIntelligence.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbIntelligence.Location = new System.Drawing.Point(133, 110);
            this.cmbIntelligence.Name = "cmbIntelligence";
            this.cmbIntelligence.Size = new System.Drawing.Size(100, 21);
            this.cmbIntelligence.TabIndex = 7;
            this.cmbIntelligence.SelectedIndexChanged += new System.EventHandler(this.cmbIntelligence_SelectedIndexChanged);
            // 
            // cmbLuck
            // 
            this.cmbLuck.FormattingEnabled = true;
            this.cmbLuck.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbLuck.Location = new System.Drawing.Point(133, 141);
            this.cmbLuck.Name = "cmbLuck";
            this.cmbLuck.Size = new System.Drawing.Size(100, 21);
            this.cmbLuck.TabIndex = 8;
            this.cmbLuck.SelectedIndexChanged += new System.EventHandler(this.cmbLuck_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Luck";
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Items.AddRange(new object[] {
            "Masculine",
            "Feminine"});
            this.cmbCharacter.Location = new System.Drawing.Point(424, 159);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(100, 21);
            this.cmbCharacter.TabIndex = 10;
            this.cmbCharacter.SelectedIndexChanged += new System.EventHandler(this.cmbCharacter_SelectedIndexChanged);
            // 
            // btnConfirmCharacter
            // 
            this.btnConfirmCharacter.Location = new System.Drawing.Point(41, 189);
            this.btnConfirmCharacter.Name = "btnConfirmCharacter";
            this.btnConfirmCharacter.Size = new System.Drawing.Size(181, 69);
            this.btnConfirmCharacter.TabIndex = 11;
            this.btnConfirmCharacter.Text = "Confirm Character";
            this.btnConfirmCharacter.UseVisualStyleBackColor = true;
            this.btnConfirmCharacter.Click += new System.EventHandler(this.btnConfirmCharacter_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(391, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name:";
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConfirmCharacter);
            this.Controls.Add(this.cmbCharacter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLuck);
            this.Controls.Add(this.cmbIntelligence);
            this.Controls.Add(this.cmbPerception);
            this.Controls.Add(this.cmbStrength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbCharacter);
            this.Controls.Add(this.label1);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStrength;
        private System.Windows.Forms.ComboBox cmbPerception;
        private System.Windows.Forms.ComboBox cmbIntelligence;
        private System.Windows.Forms.ComboBox cmbLuck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.Button btnConfirmCharacter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
    }
}
namespace TLoZOoTiM_Rando
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SubareaRandoBox = new System.Windows.Forms.CheckBox();
            this.MusicRandoBox = new System.Windows.Forms.CheckBox();
            this.MainAreaCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Datapack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Randomize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SubareaRandoBox
            // 
            this.SubareaRandoBox.AutoSize = true;
            this.SubareaRandoBox.Location = new System.Drawing.Point(13, 74);
            this.SubareaRandoBox.Name = "SubareaRandoBox";
            this.SubareaRandoBox.Size = new System.Drawing.Size(169, 21);
            this.SubareaRandoBox.TabIndex = 3;
            this.SubareaRandoBox.Text = "Randomize Entrances";
            this.SubareaRandoBox.UseVisualStyleBackColor = true;
            // 
            // MusicRandoBox
            // 
            this.MusicRandoBox.AutoSize = true;
            this.MusicRandoBox.Location = new System.Drawing.Point(13, 102);
            this.MusicRandoBox.Name = "MusicRandoBox";
            this.MusicRandoBox.Size = new System.Drawing.Size(141, 21);
            this.MusicRandoBox.TabIndex = 4;
            this.MusicRandoBox.Text = "Randomize Music";
            this.MusicRandoBox.UseVisualStyleBackColor = true;
            // 
            // MainAreaCheckbox
            // 
            this.MainAreaCheckbox.AutoSize = true;
            this.MainAreaCheckbox.Location = new System.Drawing.Point(13, 130);
            this.MainAreaCheckbox.Name = "MainAreaCheckbox";
            this.MainAreaCheckbox.Size = new System.Drawing.Size(246, 21);
            this.MainAreaCheckbox.TabIndex = 5;
            this.MainAreaCheckbox.Text = "Randomize Main Areas (unpaired)";
            this.MainAreaCheckbox.UseVisualStyleBackColor = true;
            this.MainAreaCheckbox.CheckedChanged += new System.EventHandler(this.MainAreaCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainAreaCheckbox);
            this.Controls.Add(this.MusicRandoBox);
            this.Controls.Add(this.SubareaRandoBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TLoZOoTiM Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox SubareaRandoBox;
        private System.Windows.Forms.CheckBox MusicRandoBox;
        private System.Windows.Forms.CheckBox MainAreaCheckbox;
    }
}


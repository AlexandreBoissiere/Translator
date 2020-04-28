namespace Translator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToTranslate = new System.Windows.Forms.TextBox();
            this.Translated = new System.Windows.Forms.TextBox();
            this.InputLang = new System.Windows.Forms.ComboBox();
            this.OutputLang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TranslateStarter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToTranslate
            // 
            this.ToTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTranslate.Location = new System.Drawing.Point(25, 67);
            this.ToTranslate.Multiline = true;
            this.ToTranslate.Name = "ToTranslate";
            this.ToTranslate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToTranslate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ToTranslate.Size = new System.Drawing.Size(483, 474);
            this.ToTranslate.TabIndex = 0;
            this.ToTranslate.Text = "Text to translate";
            // 
            // Translated
            // 
            this.Translated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translated.Location = new System.Drawing.Point(630, 67);
            this.Translated.Multiline = true;
            this.Translated.Name = "Translated";
            this.Translated.ReadOnly = true;
            this.Translated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Translated.Size = new System.Drawing.Size(483, 474);
            this.Translated.TabIndex = 1;
            this.Translated.Text = "Translated text";
            // 
            // InputLang
            // 
            this.InputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputLang.FormattingEnabled = true;
            this.InputLang.Items.AddRange(new object[] {
            "Latin",
            "Français"});
            this.InputLang.Location = new System.Drawing.Point(132, 37);
            this.InputLang.Name = "InputLang";
            this.InputLang.Size = new System.Drawing.Size(121, 24);
            this.InputLang.TabIndex = 2;
            // 
            // OutputLang
            // 
            this.OutputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputLang.FormattingEnabled = true;
            this.OutputLang.Items.AddRange(new object[] {
            "Français",
            "Latin"});
            this.OutputLang.Location = new System.Drawing.Point(761, 37);
            this.OutputLang.Name = "OutputLang";
            this.OutputLang.Size = new System.Drawing.Size(121, 24);
            this.OutputLang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input language : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output language : ";
            // 
            // TranslateStarter
            // 
            this.TranslateStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateStarter.Location = new System.Drawing.Point(526, 307);
            this.TranslateStarter.Name = "TranslateStarter";
            this.TranslateStarter.Size = new System.Drawing.Size(89, 28);
            this.TranslateStarter.TabIndex = 6;
            this.TranslateStarter.Text = "Translate";
            this.TranslateStarter.UseVisualStyleBackColor = true;
            this.TranslateStarter.Click += new System.EventHandler(this.TranslateStarter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.TranslateStarter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLang);
            this.Controls.Add(this.InputLang);
            this.Controls.Add(this.Translated);
            this.Controls.Add(this.ToTranslate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToTranslate;
        private System.Windows.Forms.TextBox Translated;
        private System.Windows.Forms.ComboBox InputLang;
        private System.Windows.Forms.ComboBox OutputLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TranslateStarter;
    }
}


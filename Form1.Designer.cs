namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.destination = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.renametext = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createfilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destination
            // 
            resources.ApplyResources(this.destination, "destination");
            this.destination.Name = "destination";
            this.destination.UseVisualStyleBackColor = true;
            this.destination.Click += new System.EventHandler(this.destination_Click);
            // 
            // file
            // 
            resources.ApplyResources(this.file, "file");
            this.file.Name = "file";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // text1
            // 
            resources.ApplyResources(this.text1, "text1");
            this.text1.Name = "text1";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // copy
            // 
            resources.ApplyResources(this.copy, "copy");
            this.copy.Name = "copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.button1_Click);
            // 
            // text2
            // 
            resources.ApplyResources(this.text2, "text2");
            this.text2.Name = "text2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Rename
            // 
            resources.ApplyResources(this.Rename, "Rename");
            this.Rename.Name = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // renametext
            // 
            resources.ApplyResources(this.renametext, "renametext");
            this.renametext.Name = "renametext";
            this.renametext.TextChanged += new System.EventHandler(this.renametext_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createfilebutton
            // 
            resources.ApplyResources(this.createfilebutton, "createfilebutton");
            this.createfilebutton.Name = "createfilebutton";
            this.createfilebutton.UseVisualStyleBackColor = true;
            this.createfilebutton.Click += new System.EventHandler(this.createfilebutton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.createfilebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.renametext);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.file);
            this.Controls.Add(this.destination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button destination;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.TextBox renametext;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createfilebutton;
    }
}


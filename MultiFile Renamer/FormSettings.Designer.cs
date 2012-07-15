namespace MultiFile_Renamer
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RenamingTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLocation3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLocation2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLocation1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSeparator = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.textBoxImages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DefinitionsTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonDontSave = new System.Windows.Forms.RadioButton();
            this.radioButtonSaveRegistry = new System.Windows.Forms.RadioButton();
            this.radioButtonSaveLocal = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.RenamingTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSeparator.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            this.DefinitionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RenamingTab);
            this.tabControl1.Controls.Add(this.ExtensionsTab);
            this.tabControl1.Controls.Add(this.DefinitionsTab);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 255);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.TabControl1Click);
            // 
            // RenamingTab
            // 
            this.RenamingTab.Controls.Add(this.groupBox1);
            this.RenamingTab.Controls.Add(this.groupBoxSeparator);
            this.RenamingTab.Location = new System.Drawing.Point(4, 22);
            this.RenamingTab.Name = "RenamingTab";
            this.RenamingTab.Padding = new System.Windows.Forms.Padding(3);
            this.RenamingTab.Size = new System.Drawing.Size(398, 229);
            this.RenamingTab.TabIndex = 0;
            this.RenamingTab.Text = "Renaming";
            this.RenamingTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLocation3);
            this.groupBox1.Controls.Add(this.radioButtonLocation2);
            this.groupBox1.Controls.Add(this.radioButtonLocation1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // radioButtonLocation3
            // 
            this.radioButtonLocation3.AutoSize = true;
            this.radioButtonLocation3.Location = new System.Drawing.Point(20, 108);
            this.radioButtonLocation3.Name = "radioButtonLocation3";
            this.radioButtonLocation3.Size = new System.Drawing.Size(85, 17);
            this.radioButtonLocation3.TabIndex = 3;
            this.radioButtonLocation3.TabStop = true;
            this.radioButtonLocation3.Text = "radioButton3";
            this.radioButtonLocation3.UseVisualStyleBackColor = true;
            this.radioButtonLocation3.Click += new System.EventHandler(this.RadioButtonLocation3Click);
            // 
            // radioButtonLocation2
            // 
            this.radioButtonLocation2.AutoSize = true;
            this.radioButtonLocation2.Location = new System.Drawing.Point(20, 78);
            this.radioButtonLocation2.Name = "radioButtonLocation2";
            this.radioButtonLocation2.Size = new System.Drawing.Size(85, 17);
            this.radioButtonLocation2.TabIndex = 2;
            this.radioButtonLocation2.TabStop = true;
            this.radioButtonLocation2.Text = "radioButton2";
            this.radioButtonLocation2.UseVisualStyleBackColor = true;
            this.radioButtonLocation2.Click += new System.EventHandler(this.RadioButtonLocation2Click);
            // 
            // radioButtonLocation1
            // 
            this.radioButtonLocation1.AutoSize = true;
            this.radioButtonLocation1.Location = new System.Drawing.Point(20, 48);
            this.radioButtonLocation1.Name = "radioButtonLocation1";
            this.radioButtonLocation1.Size = new System.Drawing.Size(85, 17);
            this.radioButtonLocation1.TabIndex = 1;
            this.radioButtonLocation1.TabStop = true;
            this.radioButtonLocation1.Text = "radioButton1";
            this.radioButtonLocation1.UseVisualStyleBackColor = true;
            this.radioButtonLocation1.Click += new System.EventHandler(this.RadioButtonLocation1Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order of Labels and Identifiers:";
            // 
            // groupBoxSeparator
            // 
            this.groupBoxSeparator.Controls.Add(this.label1);
            this.groupBoxSeparator.Controls.Add(this.textBoxSeparator);
            this.groupBoxSeparator.Location = new System.Drawing.Point(14, 6);
            this.groupBoxSeparator.Name = "groupBoxSeparator";
            this.groupBoxSeparator.Size = new System.Drawing.Size(364, 50);
            this.groupBoxSeparator.TabIndex = 2;
            this.groupBoxSeparator.TabStop = false;
            this.groupBoxSeparator.Text = "Separator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Separator between labels: ";
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Location = new System.Drawing.Point(145, 19);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(213, 20);
            this.textBoxSeparator.TabIndex = 1;
            this.textBoxSeparator.TextChanged += new System.EventHandler(this.TextBoxSeparatorTextChanged);
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.Controls.Add(this.textBoxMedia);
            this.ExtensionsTab.Controls.Add(this.textBoxImages);
            this.ExtensionsTab.Controls.Add(this.label5);
            this.ExtensionsTab.Controls.Add(this.label4);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 22);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(398, 229);
            this.ExtensionsTab.TabIndex = 1;
            this.ExtensionsTab.Text = "Media Extensions";
            this.ExtensionsTab.UseVisualStyleBackColor = true;
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(14, 154);
            this.textBoxMedia.Multiline = true;
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(370, 59);
            this.textBoxMedia.TabIndex = 3;
            // 
            // textBoxImages
            // 
            this.textBoxImages.Location = new System.Drawing.Point(14, 43);
            this.textBoxImages.Multiline = true;
            this.textBoxImages.Name = "textBoxImages";
            this.textBoxImages.Size = new System.Drawing.Size(370, 59);
            this.textBoxImages.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preview music and video with the following extensions (Separate by comma):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preview images with the following extensions (Separate by comma):";
            // 
            // DefinitionsTab
            // 
            this.DefinitionsTab.Controls.Add(this.label7);
            this.DefinitionsTab.Controls.Add(this.label6);
            this.DefinitionsTab.Controls.Add(this.label3);
            this.DefinitionsTab.Controls.Add(this.radioButtonDontSave);
            this.DefinitionsTab.Controls.Add(this.radioButtonSaveRegistry);
            this.DefinitionsTab.Controls.Add(this.radioButtonSaveLocal);
            this.DefinitionsTab.Location = new System.Drawing.Point(4, 22);
            this.DefinitionsTab.Name = "DefinitionsTab";
            this.DefinitionsTab.Size = new System.Drawing.Size(398, 229);
            this.DefinitionsTab.TabIndex = 2;
            this.DefinitionsTab.Text = "Saving";
            this.DefinitionsTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 202);
            this.label7.MaximumSize = new System.Drawing.Size(350, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "If you choose this option, no definitions will be saved.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 115);
            this.label6.MaximumSize = new System.Drawing.Size(350, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 52);
            this.label6.TabIndex = 4;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 33);
            this.label3.MaximumSize = new System.Drawing.Size(350, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // radioButtonDontSave
            // 
            this.radioButtonDontSave.AutoSize = true;
            this.radioButtonDontSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDontSave.Location = new System.Drawing.Point(19, 182);
            this.radioButtonDontSave.Name = "radioButtonDontSave";
            this.radioButtonDontSave.Size = new System.Drawing.Size(152, 17);
            this.radioButtonDontSave.TabIndex = 2;
            this.radioButtonDontSave.Text = "Don\'t Save Definitions";
            this.radioButtonDontSave.UseVisualStyleBackColor = true;
            this.radioButtonDontSave.Click += new System.EventHandler(this.RadioButtonDontSaveClick);
            // 
            // radioButtonSaveRegistry
            // 
            this.radioButtonSaveRegistry.AutoSize = true;
            this.radioButtonSaveRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSaveRegistry.Location = new System.Drawing.Point(19, 95);
            this.radioButtonSaveRegistry.Name = "radioButtonSaveRegistry";
            this.radioButtonSaveRegistry.Size = new System.Drawing.Size(241, 17);
            this.radioButtonSaveRegistry.TabIndex = 1;
            this.radioButtonSaveRegistry.Text = "Save Definitions on Windows Registry";
            this.radioButtonSaveRegistry.UseVisualStyleBackColor = true;
            this.radioButtonSaveRegistry.Click += new System.EventHandler(this.RadioButtonSaveRegistryClick);
            // 
            // radioButtonSaveLocal
            // 
            this.radioButtonSaveLocal.AutoSize = true;
            this.radioButtonSaveLocal.Checked = true;
            this.radioButtonSaveLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSaveLocal.Location = new System.Drawing.Point(19, 13);
            this.radioButtonSaveLocal.Name = "radioButtonSaveLocal";
            this.radioButtonSaveLocal.Size = new System.Drawing.Size(210, 17);
            this.radioButtonSaveLocal.TabIndex = 0;
            this.radioButtonSaveLocal.TabStop = true;
            this.radioButtonSaveLocal.Text = "Save Definitions on Local Folder";
            this.radioButtonSaveLocal.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(243, 263);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(79, 26);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApplyClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(330, 263);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 26);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 296);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.RenamingTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSeparator.ResumeLayout(false);
            this.groupBoxSeparator.PerformLayout();
            this.ExtensionsTab.ResumeLayout(false);
            this.ExtensionsTab.PerformLayout();
            this.DefinitionsTab.ResumeLayout(false);
            this.DefinitionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RenamingTab;
        private System.Windows.Forms.TabPage ExtensionsTab;
        private System.Windows.Forms.TabPage DefinitionsTab;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonDontSave;
        private System.Windows.Forms.RadioButton radioButtonSaveRegistry;
        private System.Windows.Forms.RadioButton radioButtonSaveLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSeparator;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.TextBox textBoxImages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonLocation3;
        private System.Windows.Forms.RadioButton radioButtonLocation2;
        private System.Windows.Forms.RadioButton radioButtonLocation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
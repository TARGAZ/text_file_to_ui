namespace text_file_to_ui
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
            this.components = new System.ComponentModel.Container();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtYearsOfBirth = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleSpecificationAtribut = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbYearsOfBirth = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbRoleSpecificationAtribut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Location = new System.Drawing.Point(26, 21);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(131, 36);
            this.btnChoseFile.TabIndex = 0;
            this.btnChoseFile.Text = "Chose file...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(292, 82);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(172, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // txtYearsOfBirth
            // 
            this.txtYearsOfBirth.Location = new System.Drawing.Point(292, 127);
            this.txtYearsOfBirth.Name = "txtYearsOfBirth";
            this.txtYearsOfBirth.Size = new System.Drawing.Size(172, 22);
            this.txtYearsOfBirth.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(292, 176);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(172, 22);
            this.txtCity.TabIndex = 3;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(292, 230);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(172, 22);
            this.txtFaculty.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(292, 280);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(172, 22);
            this.txtRole.TabIndex = 5;
            // 
            // txtRoleSpecificationAtribut
            // 
            this.txtRoleSpecificationAtribut.Location = new System.Drawing.Point(292, 334);
            this.txtRoleSpecificationAtribut.Name = "txtRoleSpecificationAtribut";
            this.txtRoleSpecificationAtribut.Size = new System.Drawing.Size(172, 22);
            this.txtRoleSpecificationAtribut.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(23, 88);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(71, 16);
            this.lbFullName.TabIndex = 8;
            this.lbFullName.Text = "Full name :";
            // 
            // lbYearsOfBirth
            // 
            this.lbYearsOfBirth.AutoSize = true;
            this.lbYearsOfBirth.Location = new System.Drawing.Point(23, 133);
            this.lbYearsOfBirth.Name = "lbYearsOfBirth";
            this.lbYearsOfBirth.Size = new System.Drawing.Size(91, 16);
            this.lbYearsOfBirth.TabIndex = 9;
            this.lbYearsOfBirth.Text = "Years of birth :";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(23, 182);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 16);
            this.lbCity.TabIndex = 10;
            this.lbCity.Text = "City :";
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Location = new System.Drawing.Point(23, 236);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(56, 16);
            this.lbFaculty.TabIndex = 11;
            this.lbFaculty.Text = "Faculty :";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(23, 286);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(42, 16);
            this.lbRole.TabIndex = 12;
            this.lbRole.Text = "Role :";
            // 
            // lbRoleSpecificationAtribut
            // 
            this.lbRoleSpecificationAtribut.AutoSize = true;
            this.lbRoleSpecificationAtribut.Location = new System.Drawing.Point(23, 340);
            this.lbRoleSpecificationAtribut.Name = "lbRoleSpecificationAtribut";
            this.lbRoleSpecificationAtribut.Size = new System.Drawing.Size(167, 16);
            this.lbRoleSpecificationAtribut.TabIndex = 13;
            this.lbRoleSpecificationAtribut.Text = "[Role specification atribut] :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 423);
            this.Controls.Add(this.lbRoleSpecificationAtribut);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbYearsOfBirth);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.txtRoleSpecificationAtribut);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtYearsOfBirth);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnChoseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtYearsOfBirth;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleSpecificationAtribut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbYearsOfBirth;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbRoleSpecificationAtribut;
    }
}


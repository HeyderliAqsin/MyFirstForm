
namespace FormFirst
{
    partial class UserForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgroup = new System.Windows.Forms.TextBox();
            this.btnAddgroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcome.Location = new System.Drawing.Point(223, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(308, 57);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // txtgroup
            // 
            this.txtgroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgroup.Location = new System.Drawing.Point(22, 164);
            this.txtgroup.Name = "txtgroup";
            this.txtgroup.Size = new System.Drawing.Size(270, 34);
            this.txtgroup.TabIndex = 2;
            // 
            // btnAddgroup
            // 
            this.btnAddgroup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddgroup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddgroup.ForeColor = System.Drawing.Color.White;
            this.btnAddgroup.Location = new System.Drawing.Point(22, 244);
            this.btnAddgroup.Name = "btnAddgroup";
            this.btnAddgroup.Size = new System.Drawing.Size(185, 50);
            this.btnAddgroup.TabIndex = 3;
            this.btnAddgroup.Text = "Add";
            this.btnAddgroup.UseVisualStyleBackColor = false;
            this.btnAddgroup.Click += new System.EventHandler(this.btnAddgroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(529, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Groups";
            // 
            // cmbgroup
            // 
            this.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(527, 164);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(256, 36);
            this.cmbgroup.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbgroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddgroup);
            this.Controls.Add(this.txtgroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgroup;
        private System.Windows.Forms.Button btnAddgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbgroup;
    }
}
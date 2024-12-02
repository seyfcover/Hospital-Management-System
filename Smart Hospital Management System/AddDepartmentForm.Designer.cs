namespace Smart_Hospital_Management_System
{
    partial class AddDepartmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartmentForm));
            this.cboMainDepartment = new System.Windows.Forms.ComboBox();
            this.lblMainDepartment = new System.Windows.Forms.Label();
            this.txtNewDepartment = new System.Windows.Forms.TextBox();
            this.lblNewDepartment = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBoxSubDepartments = new System.Windows.Forms.ListBox();
            this.lblSubDepartments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMainDepartment
            // 
            this.cboMainDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMainDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMainDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboMainDepartment.FormattingEnabled = true;
            this.cboMainDepartment.Location = new System.Drawing.Point(15, 41);
            this.cboMainDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cboMainDepartment.Name = "cboMainDepartment";
            this.cboMainDepartment.Size = new System.Drawing.Size(226, 26);
            this.cboMainDepartment.TabIndex = 0;
            this.cboMainDepartment.SelectedIndexChanged += new System.EventHandler(this.cboMainDepartment_SelectedIndexChanged);
            // 
            // lblMainDepartment
            // 
            this.lblMainDepartment.AutoSize = true;
            this.lblMainDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMainDepartment.Location = new System.Drawing.Point(15, 20);
            this.lblMainDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainDepartment.Name = "lblMainDepartment";
            this.lblMainDepartment.Size = new System.Drawing.Size(118, 19);
            this.lblMainDepartment.TabIndex = 1;
            this.lblMainDepartment.Text = "Ana Departman:";
            // 
            // txtNewDepartment
            // 
            this.txtNewDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewDepartment.Location = new System.Drawing.Point(15, 98);
            this.txtNewDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewDepartment.Name = "txtNewDepartment";
            this.txtNewDepartment.Size = new System.Drawing.Size(226, 24);
            this.txtNewDepartment.TabIndex = 2;
            this.txtNewDepartment.TextChanged += new System.EventHandler(this.txtNewDepartment_TextChanged);
            // 
            // lblNewDepartment
            // 
            this.lblNewDepartment.AutoSize = true;
            this.lblNewDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewDepartment.Location = new System.Drawing.Point(15, 77);
            this.lblNewDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewDepartment.Name = "lblNewDepartment";
            this.lblNewDepartment.Size = new System.Drawing.Size(120, 19);
            this.lblNewDepartment.TabIndex = 3;
            this.lblNewDepartment.Text = "Yeni Departman:";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(15, 138);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(68, 28);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Ekle";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteDepartment.FlatAppearance.BorderSize = 0;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(172, 138);
            this.btnDeleteDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(68, 28);
            this.btnDeleteDepartment.TabIndex = 5;
            this.btnDeleteDepartment.Text = "Sil";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(15, 179);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBoxSubDepartments
            // 
            this.listBoxSubDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxSubDepartments.FormattingEnabled = true;
            this.listBoxSubDepartments.ItemHeight = 18;
            this.listBoxSubDepartments.Location = new System.Drawing.Point(15, 244);
            this.listBoxSubDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSubDepartments.Name = "listBoxSubDepartments";
            this.listBoxSubDepartments.Size = new System.Drawing.Size(226, 94);
            this.listBoxSubDepartments.TabIndex = 7;
            // 
            // lblSubDepartments
            // 
            this.lblSubDepartments.AutoSize = true;
            this.lblSubDepartments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubDepartments.Location = new System.Drawing.Point(15, 219);
            this.lblSubDepartments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubDepartments.Name = "lblSubDepartments";
            this.lblSubDepartments.Size = new System.Drawing.Size(130, 19);
            this.lblSubDepartments.TabIndex = 8;
            this.lblSubDepartments.Text = "Alt Departmanlar:";
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(270, 366);
            this.Controls.Add(this.lblSubDepartments);
            this.Controls.Add(this.listBoxSubDepartments);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.lblNewDepartment);
            this.Controls.Add(this.txtNewDepartment);
            this.Controls.Add(this.lblMainDepartment);
            this.Controls.Add(this.cboMainDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Ekle/Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cboMainDepartment;
        private System.Windows.Forms.Label lblMainDepartment;
        private System.Windows.Forms.TextBox txtNewDepartment;
        private System.Windows.Forms.Label lblNewDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxSubDepartments;
        private System.Windows.Forms.Label lblSubDepartments;
    }
}

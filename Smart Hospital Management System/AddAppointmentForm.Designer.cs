namespace Smart_Hospital_Management_System
{
    partial class AddAppointmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointmentForm));
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.listBoxSubDepartments = new System.Windows.Forms.ListBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDepartment
            // 
            this.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(20, 50);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(400, 25);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // listBoxSubDepartments
            // 
            this.listBoxSubDepartments.FormattingEnabled = true;
            this.listBoxSubDepartments.ItemHeight = 17;
            this.listBoxSubDepartments.Location = new System.Drawing.Point(20, 110);
            this.listBoxSubDepartments.Name = "listBoxSubDepartments";
            this.listBoxSubDepartments.Size = new System.Drawing.Size(400, 106);
            this.listBoxSubDepartments.TabIndex = 1;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(20, 262);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(400, 25);
            this.txtPatientName.TabIndex = 2;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(20, 312);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(180, 40);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.Text = "Randevu Al";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartment.Location = new System.Drawing.Point(20, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(118, 19);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Ana Departman:";
            // 
            // lblSubDepartment
            // 
            this.lblSubDepartment.AutoSize = true;
            this.lblSubDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSubDepartment.Location = new System.Drawing.Point(20, 85);
            this.lblSubDepartment.Name = "lblSubDepartment";
            this.lblSubDepartment.Size = new System.Drawing.Size(130, 19);
            this.lblSubDepartment.TabIndex = 2;
            this.lblSubDepartment.Text = "Alt Departmanlar:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPatientName.Location = new System.Drawing.Point(20, 237);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(78, 19);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Hasta Adı:";
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(450, 386);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.listBoxSubDepartments);
            this.Controls.Add(this.lblSubDepartment);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Al";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ListBox listBoxSubDepartments;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.Label lblPatientName;
    }
}

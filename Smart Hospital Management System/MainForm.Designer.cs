namespace Smart_Hospital_Management_System
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnViewQueue = new System.Windows.Forms.Button();
            this.btnLabResults = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(55, 48);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(200, 50);
            this.btnAddDepartment.TabIndex = 0;
            this.btnAddDepartment.Text = "Departman Ekle";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(55, 133);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(200, 50);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "Randevu Al";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnViewQueue
            // 
            this.btnViewQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnViewQueue.FlatAppearance.BorderSize = 0;
            this.btnViewQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewQueue.ForeColor = System.Drawing.Color.White;
            this.btnViewQueue.Location = new System.Drawing.Point(55, 214);
            this.btnViewQueue.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewQueue.Name = "btnViewQueue";
            this.btnViewQueue.Size = new System.Drawing.Size(200, 50);
            this.btnViewQueue.TabIndex = 2;
            this.btnViewQueue.Text = "Sırayı Gör";
            this.btnViewQueue.UseVisualStyleBackColor = false;
            this.btnViewQueue.Click += new System.EventHandler(this.btnViewQueue_Click);
            // 
            // btnLabResults
            // 
            this.btnLabResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.btnLabResults.FlatAppearance.BorderSize = 0;
            this.btnLabResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLabResults.ForeColor = System.Drawing.Color.White;
            this.btnLabResults.Location = new System.Drawing.Point(55, 296);
            this.btnLabResults.Margin = new System.Windows.Forms.Padding(2);
            this.btnLabResults.Name = "btnLabResults";
            this.btnLabResults.Size = new System.Drawing.Size(200, 50);
            this.btnLabResults.TabIndex = 3;
            this.btnLabResults.Text = "Laboratuvar Sonuçları";
            this.btnLabResults.UseVisualStyleBackColor = false;
            this.btnLabResults.Click += new System.EventHandler(this.btnLabResults_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(55, 371);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImage = global::Smart_Hospital_Management_System.Properties.Resources.v870_mynt_05;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 475);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLabResults);
            this.Controls.Add(this.btnViewQueue);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnAddDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Yönetim Sistemi";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnViewQueue;
        private System.Windows.Forms.Button btnLabResults;
        private System.Windows.Forms.Button btnExit;
    }
}

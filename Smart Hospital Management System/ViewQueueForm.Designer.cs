namespace Smart_Hospital_Management_System
{
    partial class ViewQueueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQueueForm));
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnViewQueue = new System.Windows.Forms.Button();
            this.lbxQueue = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOfP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartment.Location = new System.Drawing.Point(20, 20);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(88, 19);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Departman:";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Location = new System.Drawing.Point(20, 45);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(260, 25);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // btnViewQueue
            // 
            this.btnViewQueue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewQueue.ForeColor = System.Drawing.Color.White;
            this.btnViewQueue.Location = new System.Drawing.Point(20, 85);
            this.btnViewQueue.Name = "btnViewQueue";
            this.btnViewQueue.Size = new System.Drawing.Size(120, 40);
            this.btnViewQueue.TabIndex = 2;
            this.btnViewQueue.Text = "Sıradaki Hasta";
            this.btnViewQueue.UseVisualStyleBackColor = false;
            this.btnViewQueue.Click += new System.EventHandler(this.btnViewQueue_Click);
            // 
            // lbxQueue
            // 
            this.lbxQueue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbxQueue.FormattingEnabled = true;
            this.lbxQueue.ItemHeight = 17;
            this.lbxQueue.Location = new System.Drawing.Point(20, 135);
            this.lbxQueue.Name = "lbxQueue";
            this.lbxQueue.Size = new System.Drawing.Size(260, 89);
            this.lbxQueue.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(160, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextQueue
            // 
            this.btnNextQueue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNextQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNextQueue.ForeColor = System.Drawing.Color.White;
            this.btnNextQueue.Location = new System.Drawing.Point(20, 268);
            this.btnNextQueue.Name = "btnNextQueue";
            this.btnNextQueue.Size = new System.Drawing.Size(260, 45);
            this.btnNextQueue.TabIndex = 5;
            this.btnNextQueue.Text = "Randevu Tamamlandı";
            this.btnNextQueue.UseVisualStyleBackColor = false;
            this.btnNextQueue.Click += new System.EventHandler(this.btnNextQueue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sıradaki Hasta Sayısı : ";
            // 
            // CountOfP
            // 
            this.CountOfP.AutoSize = true;
            this.CountOfP.Location = new System.Drawing.Point(156, 237);
            this.CountOfP.Name = "CountOfP";
            this.CountOfP.Size = new System.Drawing.Size(0, 19);
            this.CountOfP.TabIndex = 7;
            // 
            // ViewQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(320, 340);
            this.Controls.Add(this.CountOfP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnViewQueue);
            this.Controls.Add(this.lbxQueue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextQueue);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sırayı Gör";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnViewQueue;
        private System.Windows.Forms.ListBox lbxQueue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNextQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountOfP;
    }
}

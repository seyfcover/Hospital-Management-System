using System;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Hospital_Management_System
{
    public partial class ViewQueueForm : Form
    {
        private HospitalService hospitalService;
        private int Id;

        public ViewQueueForm(HospitalService service, int Id) {
            InitializeComponent();
            hospitalService = service; // Hastane hizmetini al
            this.Id = Id-1;
            LoadDepartments(); // Departmanları yükle
            if (CountOfP.Text == "0") {
                btnNextQueue.Enabled = false;
            }
        }

        private void LoadDepartments() {
      
           // var mainDepartments = hospitalService.GetMainDepartments();
            var mainDepartments = hospitalService.GetSubDepartments();

            cboDepartment.Items.Clear(); 

            foreach (var department in mainDepartments) {
                cboDepartment.Items.Add(department); 
            }

            if (cboDepartment.Items.Count > 0) {
                cboDepartment.SelectedIndex = 0; // İlk öğeyi seç
            }
        }

        private void btnViewQueue_Click(object sender, EventArgs e) {
            string department = cboDepartment.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(department) || department == "Yeni Ana Departman Ekle") {
                MessageBox.Show("Lütfen geçerli bir departman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbxQueue.Items.Clear(); // Önceki öğeleri temizle
            CountOfP.Text = hospitalService.GetPatientCount(department).ToString();

            if (CountOfP.Text == "0") {
                btnNextQueue.Enabled = false;

            } else {
                btnNextQueue.Enabled = true;
            }

            // Sıradaki hastayı almak için GetBackPatient kullan
            var nextPatient = hospitalService.GetBackPatient(department);
            if (!string.IsNullOrEmpty(nextPatient)) {
                lbxQueue.Items.Add(nextPatient); // Sıradaki hastayı ekle
            } else {
                MessageBox.Show("Randevu kuyruğu boş veya mevcut değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNextQueue_Click(object sender, EventArgs e) {
            string department = cboDepartment.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(department) || department == "Yeni Ana Departman Ekle") {
                MessageBox.Show("Lütfen geçerli bir departman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbxQueue.Items.Clear(); // Önceki öğeleri temizle
            CountOfP.Text = hospitalService.GetPatientCount(department).ToString();

            if (CountOfP.Text == "0") {
                btnNextQueue.Enabled = false;

            } else {
                btnNextQueue.Enabled = true;
            }

            // Sıradaki hastayı almak için GetNextPatient kullan
            var nextPatient = hospitalService.GetNextPatient(department);
            if (!string.IsNullOrEmpty(nextPatient)) {
                LabResultEntryForm labResultEntryForm = new LabResultEntryForm(hospitalService,++Id);
                labResultEntryForm.ShowDialog();
                lbxQueue.Items.Add(nextPatient); // Sıradaki hastayı ekle
            } else {
                MessageBox.Show("Randevu kuyruğu boş veya mevcut değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnViewQueue_Click(sender, e);
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // İptal butonuna basıldığında formu kapat
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            string department = cboDepartment.SelectedItem?.ToString();
            CountOfP.Text = hospitalService.GetPatientCount(department).ToString();
            if (CountOfP.Text == "0") {
                btnNextQueue.Enabled = false;
                btnViewQueue_Click(null, null);
            } else { btnNextQueue.Enabled = true;
                btnViewQueue_Click(null, null);
            }
        }
    }
}

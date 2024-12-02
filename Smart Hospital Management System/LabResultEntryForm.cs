using System;
using System.Windows.Forms;
using Smart_Hospital_Management_System.Services;

namespace Smart_Hospital_Management_System
{
    public partial class LabResultEntryForm : Form
    {
        private HospitalService hospitalService;
        
        public LabResultEntryForm(HospitalService service, int Id) {
            InitializeComponent();
            hospitalService = service; // Hastane hizmetini al
            txtPatientId.Text = Id.ToString();
            txtTestName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            string patientId = txtPatientId.Text.Trim();
            string testName = txtTestName.Text.Trim();
            string result = txtResult.Text.Trim();

            if (string.IsNullOrEmpty(patientId) || string.IsNullOrEmpty(testName) || string.IsNullOrEmpty(result)) {
                MessageBox.Show("Lütfen hasta ID'sini, test adını ve sonucu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sonucu ekle
            var labResult = new LabResult(patientId, testName, result);
            hospitalService.AddLabResult(labResult); // Hasta ID'si, labResult nesnesi içinde saklı olduğu için sadece labResult geçirildi
            MessageBox.Show("Laboratuvar sonucu başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Alanları temizle
            txtTestName.Clear();
            txtResult.Clear();
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // İptal butonuna basıldığında formu kapat
        }

        Formatter formatter = new Formatter();
        private void txtTestName_TextChanged(object sender, EventArgs e) {
            txtTestName.TextChanged -= txtTestName_TextChanged;

            // Formatlama işlemini gerçekleştir
            formatter.FormatDepartmentName(txtTestName);

            // Olayı tekrar etkinleştir
            txtTestName.TextChanged += txtTestName_TextChanged;
        }

        private void txtResult_TextChanged(object sender, EventArgs e) {
            txtResult.TextChanged -= txtResult_TextChanged;

            // Formatlama işlemini gerçekleştir
            formatter.FormatDepartmentName(txtResult);

            // Olayı tekrar etkinleştir
            txtResult.TextChanged += txtResult_TextChanged;
        }
    }
}

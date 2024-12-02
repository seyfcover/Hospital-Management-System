using System;
using System.Windows.Forms;

namespace Smart_Hospital_Management_System
{
    public partial class LabResultsForm : Form
    {
        private HospitalService hospitalService;

        public LabResultsForm(HospitalService service) {
            InitializeComponent();
            hospitalService = service; // Hastane hizmetini al
        }

        private void btnViewResults_Click(object sender, EventArgs e) {
            string patientId = txtPatientId.Text.Trim();

            if (string.IsNullOrEmpty(patientId)) {
                MessageBox.Show("Lütfen hasta kimliğini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbxResults.Items.Clear(); // Önceki sonuçları temizle

            // Önce null kontrolü yapalım
            var results = hospitalService.GetLabResults(patientId);
            if (results != null && results.Count > 0) {
                foreach (var result in results) {
                    lbxResults.Items.Add(result.ToString()); // Sonuçları ListBox'a ekle
                }
            } else {
                MessageBox.Show("Bu hasta için laboratuvar sonucu bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // İptal butonuna basıldığında formu kapat
        }
    }
}

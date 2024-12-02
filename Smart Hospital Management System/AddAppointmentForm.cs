using System;
using System.Windows.Forms;
using Smart_Hospital_Management_System.Services;

namespace Smart_Hospital_Management_System
{
    public partial class AddAppointmentForm : Form
    {
        private HospitalService hospitalService;

        public AddAppointmentForm(HospitalService service ){
            InitializeComponent();
            hospitalService = service; // Hastane hizmetini al
            LoadDepartments(); // Departmanları yükle
        }

        private void LoadDepartments() {
            // Ana departmanları yükleyin
            cboDepartment.Items.Clear(); // Önceki öğeleri temizle
            var mainDepartments = hospitalService.GetMainDepartments();

            foreach (var department in mainDepartments) {
                cboDepartment.Items.Add(department); // Ana departmanları ekle
            }

            // Eğer alt departman varsa, yükleme yapılabilir
            if (cboDepartment.Items.Count > 0) {
                cboDepartment.SelectedIndex = 0; // İlk öğeyi seç
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            // Seçilen ana departman için alt departmanları yükle
            string selectedDepartment = cboDepartment.SelectedItem?.ToString();
            listBoxSubDepartments.Items.Clear(); // Önceki alt departmanları temizle

            if (selectedDepartment != null) {
                var subDepartments = hospitalService.GetSubDepartments(selectedDepartment);
                foreach (var subDepartment in subDepartments) {
                    listBoxSubDepartments.Items.Add(subDepartment); // Alt departmanları ekle
                }
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e) {
            string department = cboDepartment.SelectedItem?.ToString();
            string subDepartment = listBoxSubDepartments.SelectedItem?.ToString(); // Seçilen alt departman
            string patientName = txtPatientName.Text.Trim();


            if (string.IsNullOrEmpty(department) || string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(subDepartment)) {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen alt departmana randevu al
            hospitalService.AddPatientToQueue(subDepartment, patientName);
            MessageBox.Show($"'{patientName}' adlı hasta için '{subDepartment}' alt departmanına randevu alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu kapat
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // İptal butonuna basıldığında formu kapat
        }
        Formatter formatter = new Formatter();
        private void txtPatientName_TextChanged(object sender, EventArgs e) {
            txtPatientName.TextChanged -= txtPatientName_TextChanged;

            // Formatlama işlemini gerçekleştir
            formatter.FormatDepartmentName(txtPatientName);

            // Olayı tekrar etkinleştir
            txtPatientName.TextChanged += txtPatientName_TextChanged;
        }
    }
}

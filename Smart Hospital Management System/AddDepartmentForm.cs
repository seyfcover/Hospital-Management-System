using Smart_Hospital_Management_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Hospital_Management_System
{
    public partial class AddDepartmentForm : Form
    {
        private HospitalService hospitalService; // HospitalService örneği

        public AddDepartmentForm(HospitalService service) {
            InitializeComponent();
            hospitalService = service; // Servisi formda kullan
            LoadMainDepartments(); // Ana departmanları yükle
        }

        private void LoadMainDepartments() {
            // Ana departmanları yükle
            var mainDepartments = hospitalService.GetMainDepartments();

            cboMainDepartment.Items.Clear(); // Önceki öğeleri temizle
            foreach (var item in mainDepartments) {
                cboMainDepartment.Items.Add(item); // Ana departmanları ekle
            }

            // Yeni ana departman eklemek için uygun bir seçenek
            cboMainDepartment.Items.Add("Yeni Ana Departman Ekle");
            if (cboMainDepartment.Items.Count > 0) {
                cboMainDepartment.SelectedIndex = 0; // İlk öğeyi seç
            }
        }

        private void cboMainDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            listBoxSubDepartments.Items.Clear(); // Önceki alt departmanları temizle

            // Seçilen ana departmana ait alt departmanları yükle
            var selectedDepartment = cboMainDepartment.SelectedItem?.ToString();
            if (selectedDepartment == "Yeni Ana Departman Ekle") {
                listBoxSubDepartments.Enabled = false; // Yeni ana departman ekle seçilirse alt departmanları devre dışı bırak
                return;
            } else {
                listBoxSubDepartments.Enabled = true; // Alt departmanları etkinleştir
            }

            var subDepartments = hospitalService.GetSubDepartments(selectedDepartment);
            foreach (var sub in subDepartments) {
                listBoxSubDepartments.Items.Add(sub);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e) {
            string newDepartment = txtNewDepartment.Text.Trim();

            if (string.IsNullOrEmpty(newDepartment)) {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mainDepartment = cboMainDepartment.SelectedItem.ToString();
            if (mainDepartment == "Yeni Ana Departman Ekle") {
                // Yeni ana departman ekleme işlemi
                hospitalService.AddDepartment("Hastane", newDepartment); // Ana departman olarak "Hastane"ye ekle
                MessageBox.Show($"'{newDepartment}' adlı ana departman eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                // Mevcut bir ana departmana alt departman ekleme işlemi
                hospitalService.AddDepartment(mainDepartment, newDepartment);
                MessageBox.Show($"'{newDepartment}' adlı alt departman '{mainDepartment}' ana departmanına eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Formu kapat
            this.Close();
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e) {
            string selectedDepartment = cboMainDepartment.SelectedItem?.ToString();
            string selectedSubDepartment = listBoxSubDepartments.SelectedItem?.ToString();

            if (selectedSubDepartment == null && selectedDepartment == "Yeni Ana Departman Ekle") {
                MessageBox.Show("Lütfen silinecek bir departman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Alt departman silme
            if (selectedSubDepartment != null) {
                hospitalService.DeleteDepartment(selectedSubDepartment);
                MessageBox.Show($"'{selectedSubDepartment}' adlı alt departman silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Ana departman silme
            else if (selectedDepartment != "Yeni Ana Departman Ekle") {
                hospitalService.DeleteDepartment(selectedDepartment);
                MessageBox.Show($"'{selectedDepartment}' adlı ana departman silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadMainDepartments(); // Ana departmanları yeniden yükle
            cboMainDepartment_SelectedIndexChanged(sender, e); // Seçenekleri güncelle
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // İptal butonuna basıldığında formu kapat
        }

        Formatter formatter = new Formatter();
        private void txtNewDepartment_TextChanged(object sender, EventArgs e) {
            // Olayı geçici olarak devre dışı bırak
            txtNewDepartment.TextChanged -= txtNewDepartment_TextChanged;

            // Formatlama işlemini gerçekleştir
            formatter.FormatDepartmentName(txtNewDepartment);

            // Olayı tekrar etkinleştir
            txtNewDepartment.TextChanged += txtNewDepartment_TextChanged;
        }
    }
}

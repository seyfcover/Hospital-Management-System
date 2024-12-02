using System;
using System.Windows.Forms;

namespace Smart_Hospital_Management_System
{
    public partial class MainForm : Form
    {
        private HospitalService hospitalService;// HospitalService örneği
        private LoadDepartments loadDepartments;
        private int Id = 0;
        public MainForm() {
            InitializeComponent();
            hospitalService = new HospitalService(); // Servisi burada başlat
            loadDepartments = new LoadDepartments(hospitalService);
        }

        private void btnAddDepartment_Click(object sender, EventArgs e) {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(hospitalService);
            addDepartmentForm.ShowDialog(); // Departman ekleme formunu aç
        }

        private void btnAddAppointment_Click(object sender, EventArgs e) {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(hospitalService);
            addAppointmentForm.ShowDialog(); // Randevu alma formunu aç
        }

        private void btnViewQueue_Click(object sender, EventArgs e) {
            ViewQueueForm viewQueueForm = new ViewQueueForm(hospitalService,++Id);
            viewQueueForm.ShowDialog(); // Sırayı görme formunu aç
            
        }

        private void btnLabResults_Click(object sender, EventArgs e) {
            LabResultsForm labResultsForm = new LabResultsForm(hospitalService);
            labResultsForm.ShowDialog(); // Laboratuvar sonuçları formunu aç
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit(); // Uygulamayı kapat
        }
    }
}

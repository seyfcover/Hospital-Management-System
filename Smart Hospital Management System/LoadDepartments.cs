using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Hospital_Management_System
{
    public class LoadDepartments
    {
        private HospitalService HospitalService { get; set; }
        public LoadDepartments(HospitalService HospitalService) {
            this.HospitalService = HospitalService; 
            LoadDepartment();
        }

        public void LoadDepartment() {
            // Ana departmanlar
            HospitalService.AddDepartment("Hastane", "Kardiyoloji");
            HospitalService.AddDepartment("Hastane", "Ortopedi");
            HospitalService.AddDepartment("Hastane", "Pediatri");
            HospitalService.AddDepartment("Hastane", "Nöroloji");
            HospitalService.AddDepartment("Hastane", "Radyoloji");
            HospitalService.AddDepartment("Hastane", "Onkoloji");
            HospitalService.AddDepartment("Hastane", "Acil Servis");
            HospitalService.AddDepartment("Hastane", "Kadın Doğum ve Jinekoloji");
            HospitalService.AddDepartment("Hastane", "Gastroenteroloji");
            HospitalService.AddDepartment("Hastane", "Pulmonoloji");

            // Kardiyoloji alt departmanları
            HospitalService.AddDepartment("Kardiyoloji", "Girişimsel Kardiyoloji");
            HospitalService.AddDepartment("Kardiyoloji", "Non-Invaziv Kardiyoloji");
            HospitalService.AddDepartment("Kardiyoloji", "Elektrofizyoloji");
            HospitalService.AddDepartment("Kardiyoloji", "Kardiyak Görüntüleme");

            // Ortopedi alt departmanları
            HospitalService.AddDepartment("Ortopedi", "Eklem Değişimi");
            HospitalService.AddDepartment("Ortopedi", "Pediatrik Ortopedi");
            HospitalService.AddDepartment("Ortopedi", "Spor Hekimliği");
            HospitalService.AddDepartment("Ortopedi", "Travma ve Kırık Bakımı");

            // Pediatri alt departmanları
            HospitalService.AddDepartment("Pediatri", "Pediatrik Kardiyoloji");
            HospitalService.AddDepartment("Pediatri", "Pediatrik Nöroloji");
            HospitalService.AddDepartment("Pediatri", "Pediatrik Onkoloji");
            HospitalService.AddDepartment("Pediatri", "Pediatrik Cerrahi");

            // Nöroloji alt departmanları
            HospitalService.AddDepartment("Nöroloji", "İnme Ünitesi");
            HospitalService.AddDepartment("Nöroloji", "Epilepsi İzleme");
            HospitalService.AddDepartment("Nöroloji", "Nöro-Onkoloji");
            HospitalService.AddDepartment("Nöroloji", "Nörokritik Bakım");

            // Radyoloji alt departmanları
            HospitalService.AddDepartment("Radyoloji", "MR Görüntüleme");
            HospitalService.AddDepartment("Radyoloji", "Bilgisayarlı Tomografi (BT)");
            HospitalService.AddDepartment("Radyoloji", "Ultrason");
            HospitalService.AddDepartment("Radyoloji", "Nükleer Tıp");

            // Onkoloji alt departmanları
            HospitalService.AddDepartment("Onkoloji", "Medikal Onkoloji");
            HospitalService.AddDepartment("Onkoloji", "Radyasyon Onkolojisi");
            HospitalService.AddDepartment("Onkoloji", "Cerrahi Onkoloji");
            HospitalService.AddDepartment("Onkoloji", "Pediatrik Onkoloji");

            // Acil Servis alt departmanları
            HospitalService.AddDepartment("Acil Servis", "Travma Merkezi");
            HospitalService.AddDepartment("Acil Servis", "Yoğun Bakım");
            HospitalService.AddDepartment("Acil Servis", "Acil Bakım");
            HospitalService.AddDepartment("Acil Servis", "Zehir Danışma Merkezi");

            // Kadın Doğum ve Jinekoloji alt departmanları
            HospitalService.AddDepartment("Kadın Doğum ve Jinekoloji", "Genel Obstetrik");
            HospitalService.AddDepartment("Kadın Doğum ve Jinekoloji", "Jinekolojik Onkoloji");
            HospitalService.AddDepartment("Kadın Doğum ve Jinekoloji", "Maternal-Fetal Tıp");
            HospitalService.AddDepartment("Kadın Doğum ve Jinekoloji", "Üreme Endokrinolojisi");

            // Gastroenteroloji alt departmanları
            HospitalService.AddDepartment("Gastroenteroloji", "Hepatoloji");
            HospitalService.AddDepartment("Gastroenteroloji", "İnflamatuvar Bağırsak Hastalığı (IBH) Kliniği");
            HospitalService.AddDepartment("Gastroenteroloji", "Endoskopi");
            HospitalService.AddDepartment("Gastroenteroloji", "Pediatrik Gastroenteroloji");

            // Pulmonoloji alt departmanları
            HospitalService.AddDepartment("Pulmonoloji", "Uyku Bozuklukları Merkezi");
            HospitalService.AddDepartment("Pulmonoloji", "Akciğer Kanseri Kliniği");
            HospitalService.AddDepartment("Pulmonoloji", "Pulmoner Rehabilitasyon");
            HospitalService.AddDepartment("Pulmonoloji", "Girişimsel Pulmonoloji");

        }

    }
}

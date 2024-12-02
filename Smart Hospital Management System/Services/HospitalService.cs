using System;
using System.Collections.Generic;
using System.Linq;

public class HospitalService
{
    private DepartmentNode hospitalDepartments;
    private Dictionary<string, AppointmentQueue> appointmentQueues;
    private LabResultsTable labResults;

    public HospitalService() {
        hospitalDepartments = new DepartmentNode("Hastane");
        appointmentQueues = new Dictionary<string, AppointmentQueue>();
        labResults = new LabResultsTable();
    }

    public List<string> GetMainDepartments() {
        List<string> departments = new List<string>();
        // Sadece birinci seviyedeki departmanları al
        foreach (var child in hospitalDepartments.SubDepartments) {
            departments.Add(child.DepartmentName);
        }
        return departments;
    }

    public List<string> GetSubDepartments() {
        List<string> departments = new List<string>();
        // Sadece birinci seviyedeki departmanları al
        foreach (var child in hospitalDepartments.SubDepartments) {
            foreach (var childs in child.SubDepartments) {
                departments.Add(childs.DepartmentName);
            }
        }
        return departments;
    }

    private void GetDepartmentsRecursive(DepartmentNode node, List<string> departments) {
        foreach (var sub in node.SubDepartments) {
            departments.Add(sub.DepartmentName); // Sadece alt departmanları ekle
            GetDepartmentsRecursive(sub, departments); // Alt departmanları da ekle
        }
    }

    public string[] GetSubDepartments(string mainDepartment) {
        var department = FindDepartment(hospitalDepartments, mainDepartment);
        return department?.SubDepartments.Select(d => d.DepartmentName).ToArray() ?? new string[0];
    }

    public void AddDepartment(string mainDepartment, string newDepartment) {
        var department = FindDepartment(hospitalDepartments, mainDepartment);
        if (department != null) {
            if (!department.SubDepartments.Any(sub => sub.DepartmentName.Equals(newDepartment, StringComparison.OrdinalIgnoreCase))) {
                department.AddSubDepartment(new DepartmentNode(newDepartment));
            } else {
                throw new Exception($"'{newDepartment}' adlı alt departman zaten mevcut.");
            }
        } else {
            throw new Exception($"'{mainDepartment}' adlı ana departman bulunamadı.");
        }
    }

    public void DeleteDepartment(string departmentName) {
        if (hospitalDepartments.DepartmentName == departmentName) {
            throw new InvalidOperationException("Ana departman silinemez."); // Ana departmanı silme
        }

        if (RemoveDepartment(hospitalDepartments, departmentName)) {
            // Silme başarılıysa burada başka bir işlem yapmaya gerek yok
        } else {
            throw new Exception("Departman bulunamadı.");
        }
    }

    private bool RemoveDepartment(DepartmentNode node, string departmentName) {
        for (int i = 0; i < node.SubDepartments.Count; i++) {
            if (node.SubDepartments[i].DepartmentName == departmentName) {
                node.SubDepartments.RemoveAt(i); // Departmanı sil
                return true;
            }

            // Alt departmanda silme işlemi dene
            if (RemoveDepartment(node.SubDepartments[i], departmentName)) {
                return true;
            }
        }
        return false; // Silme işlemi başarısız
    }

    private DepartmentNode FindDepartment(DepartmentNode node, string departmentName) {
        if (node.DepartmentName == departmentName) return node;
        foreach (var subDepartment in node.SubDepartments) {
            var result = FindDepartment(subDepartment, departmentName);
            if (result != null) return result;
        }
        return null;
    }

    public void AddPatientToQueue(string departmentName, string patientName) {
        if (!appointmentQueues.ContainsKey(departmentName)) {
            appointmentQueues[departmentName] = new AppointmentQueue();
        }
        appointmentQueues[departmentName].AddPatient(patientName);
    }

    public string GetNextPatient(string departmentName) {
        if (appointmentQueues.ContainsKey(departmentName)) {
            return appointmentQueues[departmentName].GetNextPatient();
        }
        return "Randevu kuyruğu boş veya mevcut değil.";
    }
    public string GetBackPatient(string departmentName) {
        if (appointmentQueues.ContainsKey(departmentName)) {
            return appointmentQueues[departmentName].GetBackPatient();
        }
        return "Randevu kuyruğu boş veya mevcut değil.";
    }

    public int GetPatientCount(string departmentName) {
        if (appointmentQueues.ContainsKey(departmentName)) {
            return appointmentQueues[departmentName].WaitingCount();
        }
        return 0;
    }

    public void AddLabResult(LabResult result) {
        labResults.AddResult(result); // Sadece sonucu ekle
        System.Windows.Forms.MessageBox.Show(result.ToString());
    }

    public List<LabResult> GetLabResults(string patientId) {
        return labResults.GetResults(patientId);
    }
}

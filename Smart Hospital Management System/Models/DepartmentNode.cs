using System.Collections.Generic;

public class DepartmentNode
{
    public string DepartmentName { get; set; }
    public List<DepartmentNode> SubDepartments { get; set; }

    public DepartmentNode(string name) {
        DepartmentName = name;
        SubDepartments = new List<DepartmentNode>();
    }

    public void AddSubDepartment(DepartmentNode department) {
        SubDepartments.Add(department);
    }
}

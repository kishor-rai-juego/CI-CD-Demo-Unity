using UnityEngine;

[CreateAssetMenu(fileName = "NewStudent", menuName = "Student Data", order = 0)]
public class StudentData : ScriptableObject
{
    [Header("Student Info")]
    public string studentName;
    public int rollNo;
    public int age;
}

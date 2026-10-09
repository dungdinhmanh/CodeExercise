public class StudentNameComparer : IComparer<Student>
{
  public int Compare(Student x, Student y)
  {
    return x.Name.CompareTo(y.Name);
  }
}
Use:
student.Sort(new StudentNameComparer());

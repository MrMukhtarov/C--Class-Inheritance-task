namespace ClassInherutance_Task.Models;

internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public int Point;
    public bool isGraduated;

    public Student(string name, string surname, string group, int point, bool IsGraduated)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        isGraduated = IsGraduated;
    }

    public string FullName()
    {
        return $"{Name} {Surname}";
    }
    public string Info()
    {
        if (isGraduated == true)
        {

            return $"{FullName()} {Group} {Point} {isGraduated} Mezun olub";
        }
        else
        {
            return $"{FullName()} {Group} {Point} {isGraduated} Mezun olmayib";
        }
    }
    public string Exam()
    {
        if (Point > 80)
        {
            return $"Baliniz {Point} dir, ikinci imtahana gire bilersiniz";
        }
        return $"Baliniz {Point} dir, ikinci imtahana gire bilmezsiniz";
    }
}

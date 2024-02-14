// See https://aka.ms/new-console-template for more info{
class vechicle
{
    private string name;
    private readonly string mark;
    private int assemblyYear;

    public vechicle(string name, string mark, int assemblyYear)
    {
        this.name = name;
        this.mark = mark;
        this.assemblyYear = assemblyYear;
    }

    public string Mark
    {
        get { return mark; }
    }

    public string Name()
    {
        return $"samochod o nazwie{name}";
    }

    public string isYungerThan10()
    {
        string a = "starszy niz 10";
        string b = "nie jest starszy niz 10";
        int currentY = DateTime.Now.Year;
        int vechicleAge = currentY - assemblyYear;
        if (vechicleAge > 10)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

}

class student
{
    public int id { get; }
    public string name { get; set; }
    public string surname { get; set; }
    public int iq { get; set; }

    public student(int id, string name, string surname, int iq)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.iq = iq;
    }

}
class studMang
{
    private List<student> studentList = new List<student>();

    public List<student> returnList()
    {
        return studentList;
    }

    public void addMore(int id, string name, string surname, int iq)
    {
        student newstudent = new student(id, name, surname, iq);
        studentList.Add(newstudent);
    }


}

class Program
{
    static void Main(string[] args)
    {
        vechicle myVechicle = new vechicle("Ople Corsa", "Opel", 2012);
        Console.WriteLine(myVechicle.Name());
        Console.WriteLine(myVechicle.isYungerThan10());

        studMang mang = new studMang();

        mang.addMore(1, "Ronaldinho", "Gaucho", 200);
        mang.addMore(2, "Donald", "Trump", 100);

        foreach (var student in mang.returnList())
        {
            Console.WriteLine($"id{student.id}, name{student.name}, surname{student.surname}, iq{student.iq}");
        }
    }
}


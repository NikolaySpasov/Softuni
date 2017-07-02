public class Person
{
    private readonly string firstName;
    private readonly string lastName;
    private readonly int age;
    private double salary;

    public string FirstName => this.firstName;
    public string LastName => this.lastName;
    public int Age => this.age;
    public double Salary { get => salary; set => salary = value;}
    

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age > 30)
        {
            this.Salary += (this.Salary * bonus / 100.00);
        }
        else
        {
            this.Salary += (this.Salary * bonus / 200.00);
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary:f2} leva";
    }
}
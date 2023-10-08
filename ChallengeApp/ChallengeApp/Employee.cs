
namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        private List<int> employeeScore = new List<int>();

        public Employee(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public int Score
        {
            get
            {
                return this.employeeScore.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.employeeScore.Add(score);
        }
    }
}

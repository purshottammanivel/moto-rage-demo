using SQLite;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

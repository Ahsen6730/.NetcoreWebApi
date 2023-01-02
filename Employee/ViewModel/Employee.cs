using System.ComponentModel.DataAnnotations;

namespace Employee.ViewModel
{
    public class Employees
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        private string FirstName;
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string Name)
        {
            if (Name.Length < 50)
            {
                this.FirstName = Name;
            }
            else
            {
                throw new Exception("Error String Length size");
            }
        }
    }
}

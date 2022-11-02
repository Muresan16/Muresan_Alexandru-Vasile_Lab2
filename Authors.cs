using Muresan_Alexandru_Vasile_Lab2.Models;

namespace Muresan_Alexandru_Vasile_Lab2
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Authors>? Authors { get; set; }
    }
}

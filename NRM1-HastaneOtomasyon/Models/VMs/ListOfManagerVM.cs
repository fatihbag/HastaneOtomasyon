using Hastane.Core.Enums;

namespace NRM1_HastaneOtomasyon.Models.VMs
{
    public class ListOfManagerVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
        private decimal Salary { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

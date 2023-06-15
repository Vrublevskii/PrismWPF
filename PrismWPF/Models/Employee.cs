using wpf_test;

namespace PrismWPF.Models
{
    public partial class Employee
    {
        public long IdEmployee { get; set; }

        string lastName { get; set; } = null!;

        string name { get; set; } = null!;

        string? patronymic { get; set; }

        string dateOfBirth { get; set; } = null!;

        long telephone { get; set; }

        string email { get; set; } = null!;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string? Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
            }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
            }
        }

        public long Telephone
        {
            get { return telephone; }
            set
            {
                telephone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public long IdDepartment { get; set; }

        public long IdPosition { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; } = null!;

        public virtual Position IdPositionNavigation { get; set; } = null!;
    }
}

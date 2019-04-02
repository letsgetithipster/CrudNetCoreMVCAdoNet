using System.ComponentModel.DataAnnotations;

namespace StudentRecordManagementSystem.Models
{
    public class Student
    {
        public int Id { set; get; }
        [Required(ErrorMessage = @"O campo ""Nome"" é necessário.")]
        [Display(Name = "Nome")]
        public string FirstName { set; get; }
        [Required(ErrorMessage = @"O campo ""Sobrenome"" é necessário.")]
        [Display(Name = "Sobrenome")]
        public string LastName { set; get; }
        [Required(ErrorMessage = @"O campo ""Sobrenome"" é necessário.")]
        public string Email { set; get; }
        [Required(ErrorMessage = @"O campo ""Telefone"" é necessário.")]
        [Display(Name = "Telefone")]
        public string Mobile { set; get; }
        [Display(Name = "Endereço")]
        public string Address { set; get; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage= "İsiminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mail Adresi giriniz")]
        [EmailAddress(ErrorMessage = "Email Adresinizi düzgün giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage="Telefon No giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage= "Katılma durumunuz Nedir?")]
        public bool? Confirm { get; set; } 
    }
}
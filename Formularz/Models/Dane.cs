using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Haslo", ErrorMessage = "Hasła nie są zgodne.")]
        [DataType(DataType.Password)]
        public string PotwHaslo { get; set; }

        [Required(ErrorMessage = "Nr telefonu jest wymagany.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Nr telefonu musi składać się z dokładnie 9 cyfr.")]
        public int Tel {  get; set; }

        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80 lat.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            [Display(Name = "Warszawa")]
            Warszawa,
            [Display(Name = "Kraków")]
            Krakow,
            [Display(Name = "Gdańsk")]
            Gdansk,
            [Display(Name = "Wrocław")]
            Wroclaw,
            [Display(Name = "Poznań")]
            Poznan
        }

    }
}

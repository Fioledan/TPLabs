using System.ComponentModel.DataAnnotations;

namespace TPlab1.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Введите первый операнд")]
        public uint? Operand1 { get; set; }

        [Compare("Operand1", ErrorMessage = "Второй операнд должен быть равен первому")]
        public uint? Operand2 { get; set; }

        public string Operation { get; set; }

        public float? Result { get; set; }
    }
}
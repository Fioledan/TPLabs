using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TPlab2.Models
{
    public class StudentModel
    {
        [DisplayName("Номер")]
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string FullName { get; set; }

        [DisplayName("Группа")]
        public string Group { get; set; }

        [DisplayName("Возраст")]
        public int Age { get; set; }

        [DisplayName("Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Средний балл")]
        public double AverageScore { get; set; }
    }
}
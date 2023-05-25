using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace laba2tp.Models
{
    [DisplayName("Пользователь")]
    public class Dannie
    {
        [DisplayName("ID пользователя")]
        public int UserId { get; set; }
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Адрес")]
        public string HomeAddress { get; set; }
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail адрес")]
        public string EmailAddress { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace LabaVrode.Data
{
    [Table("студенты")]
    public class Student
    {
        [Column("ключ")]
        public int Id { get; set; }
        [Column("имя")]
        public string Name { get; set; }
        [Column("фамилия")]
        public string Surename { get; set; }

        [Column("отчество")]
        public string? MiddleName { get; set; }
        [Column("дата_рождения")]
        public DateTime BirthDay { get; set;}

        [Column("ключ_группы")]
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public List<Marks> Marks { get; set; }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaVrode.Data
{
    [Table("оценки")]
    public class Marks
    {
        [Column("ключ")]
        public int Id { get; set; }
        public Student Student { get; set; }    
        [Column("ключ_студента")]
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        [Column("ключ_предмета")]
        public int SubjectId { get; set; }
        [Column("балл")]
        public int Value { get; set; }
    }
}

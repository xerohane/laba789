using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace LabaVrode.Data
{
    [Table("предметы")]
    public class Subject
    {
        [Column("ключ")]
        public int Id { get; set; }
        [Column("название")]
        public string Name { get; set; }

        public List<Marks> Marks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

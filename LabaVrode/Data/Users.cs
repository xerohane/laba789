using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LabaVrode.Data
{
    [Table("Пользователи")]

    public class User
    {
        [Column("Ключ")]
        public int Id { get; set; }

        [Column("Имя_пользователя")]
        public string Login { get; set; }

        [Column("Пароль")]
        public string Password { get; set; }

        [Column("Является_Администратором")]
        public bool isAdmin { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCproyect.Models
{

    public enum Lista
    {

        Conocido,
        CompaneroEstudio,
        ColegaTrabajo,
        Amigo,
        AmigoInfancia,
        Pariente


    }


    public class ChristianYabetaFriends
    {

        [Key]

        public int FriendID { get; set; }

        [Required]

        public string Name { get; set; }

        public Lista Type { get; set; }

        public string Nickname { get; set; }

        public DateTime BirthDate { get; set; }



    }
}
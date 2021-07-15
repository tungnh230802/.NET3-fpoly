using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bai2
{
    public class Book
    {
        [Key]
        public int Ma_Sach { get; set; }
        public string Tieu_De { get; set; }
        public float Gia { get; set; }
        public int So_Luong { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

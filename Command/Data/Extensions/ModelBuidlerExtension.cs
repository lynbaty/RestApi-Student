using Command.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Data.Extensions
{
    public static class ModelBuidlerExtension
    {
        public static void Seed(this ModelBuilder builder) {
            builder.Entity<Student>().HasData(
                new Student() { Id=1,Name = "Diem khung", Mark = 5, Address = "Cong ty Hoa Nhan", Birthday = new DateTime(1990,12,14)},
                new Student() { Id=2,Name = "An khong khung", Mark = 10, Address = "Ly Tu Tan", Birthday = new DateTime(1990, 08, 22) },
                new Student() { Id=3,Name = "Vinh dien", Mark = 6, Address = "Go Vap", Birthday = new DateTime(1991, 9, 1)}
              );
        }
    }
}

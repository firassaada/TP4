using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication4.Models
{
    public class Student
    {
        [Key]
        public int  Id { get; set; }
        public string first_Name  { get; set; }
        public string last_Name   { get; set; }
        public string Course      { get; set; }
        public int phonenumber    {get; set ;}
        //     public TimestampAttribute universitytimestamp { get; set; }
        public Student(int id, string first_name, string last_name, int phone_number, string university, string timestamp, string course)
        {
            this.Id = id;
            this.first_Name = first_name;
            this.last_Name = last_name;
            this.phonenumber = phone_number;
            this.Course = course;
        }
    }
}

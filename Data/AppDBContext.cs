using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>().HasData(
                new StudentInfo { Id = 1, FullName = "Jane Doe", CollegeProgram = "Information Technology", Instructor = "Dr. Smith", YearInProgram = "Junior", FavoriteMajorCourse = "Web Development", FavoriteElectiveCourse = "Digital Photography" },
                new StudentInfo { Id = 2, FullName = "John Smith", CollegeProgram = "Computer Science", Instructor = "Dr. Jones", YearInProgram = "Sophomore", FavoriteMajorCourse = "Data Structures", FavoriteElectiveCourse = "Music Theory" },
                new StudentInfo { Id = 3, FullName = "Maria Garcia", CollegeProgram = "Cybersecurity", Instructor = "Prof. Lee", YearInProgram = "Freshman", FavoriteMajorCourse = "Network Security", FavoriteElectiveCourse = "Art History" },
                new StudentInfo { Id = 4, FullName = "Alex Johnson", CollegeProgram = "Software Engineering", Instructor = "Dr. Patel", YearInProgram = "Senior", FavoriteMajorCourse = "System Design", FavoriteElectiveCourse = "Philosophy" },
                new StudentInfo { Id = 5, FullName = "Sam Williams", CollegeProgram = "Information Technology", Instructor = "Dr. Smith", YearInProgram = "Junior", FavoriteMajorCourse = "Database Systems", FavoriteElectiveCourse = "Psychology" }
            );
            modelBuilder.Entity<Hobby>().HasData(
               new Hobby { Id = 1, Name = "Rock Climbing", Category = "Outdoor", Description = "Scaling natural and artificial rock faces" },
               new Hobby { Id = 2, Name = "Painting", Category = "Creative", Description = "Acrylic and watercolor painting" },
               new Hobby { Id = 3, Name = "Chess", Category = "Strategy", Description = "Competitive and casual chess play" },
               new Hobby { Id = 4, Name = "Hiking", Category = "Outdoor", Description = "Trail hiking and backpacking" },
               new Hobby { Id = 5, Name = "Guitar", Category = "Music", Description = "Acoustic and electric guitar" }
           );
        }
    }
}

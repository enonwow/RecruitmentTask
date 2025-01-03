﻿namespace RecruitmentTask.DataAccessLayer
{
    public class Employee
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required decimal Salary { get; set; }
        public required string JobLevel { get; set; }
        public required string City { get; set; }
    }
}

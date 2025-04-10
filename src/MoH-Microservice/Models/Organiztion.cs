﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MoH_Microservice.Models
{
    public class Organiztion
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Organization { get; set; }
        [Required, MaxLength(200)]
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

    public class OrganiztionalUsers
    {
        public int Id { get; set; }
        [Required, MaxLength(200), DataType(DataType.Text)]
        public string EmployeeID { get; set; }
        [Required, MaxLength(200), DataType(DataType.Text)]
        public string EmployeeName { get; set; }
        [Required, MaxLength(200), DataType(DataType.Text)]
        public string EmployeePhone { get; set; }
        [Required, MaxLength(200), DataType(DataType.Text)]
        public string EmployeeEmail { get; set; }
        [Required, MaxLength(200), DataType(DataType.MultilineText)]
        public string AssignedHospital { get; set; } // Hospiatl Name
        [AllowNull,MaxLength(255)]
        public string UploadedBy { get; set; }
        [AllowNull]
        public DateTime UploadedOn { get; set; }
    }

    public class OrganiztionalUsersReg
    {
        public List<string>? EmployeeID { get; set; }
        public List<string>? EmployeeName { get; set; }
        public List<string>? EmployeePhone { get; set; }
        public List<string>? EmployeeEmail { get; set; }
        public string UploadedBy { get; set; }
    }
    public class OrganiztionReg
    { 
        public string Organization { get; set; }
        public string CreatedBy { get; set; }
    }
    public class OrganiztionUpdate
    {
        public int Id { get; set; }
        public string Organization { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
    public class OrganiztionDelete
    {
        public int Id { get; set; }
        public string deletedBy { get; set; }
    }


}

﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MoH_Microservice.Models
{
    public class ProvidersMapUsers
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? provider { get; set; }
        [Required]
        [MaxLength(100)]
        public string service { get; set; } // link to payment puposes
        [Required]
        [MaxLength(100)]
        public string MRN { get; set; } // link to payment puposes
        [MaxLength(100)]
        [AllowNull]
        public string? Kebele { get; set; }

        [MaxLength(100)]
        [AllowNull]
        public string? Goth { get; set; }

        [MaxLength(100)]
        [AllowNull]
        public string? IDNo { get; set; }

        [MaxLength(100)]
        [AllowNull]
        public string? ReferalNo { get; set; }
        [MaxLength(100)]
        [AllowNull]
        public string? letterNo { get; set; }
        [AllowNull]
        [DataType(DataType.MultilineText)]
        public string? Examination { get; set; }
        public DateTime ExpDate { get; set; } // cbhi expire date

        [MaxLength(100)]
        [Required]
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; }
    }
    public class Providers
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? provider { get; set; }
        [Required]
        [MaxLength(100)]
        public string service { get; set; } // link to payment puposes
        [MaxLength(100)]
        [AllowNull]
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
    public class ProvidersMapReg
    {
        [Required]
        public string? provider { get; set; }
        [Required]
        public string? service { get; set; } // link to payment puposes

        [AllowNull]
        public string? Kebele { get; set; }

        [AllowNull]
        public string? Goth { get; set; }
  
        [AllowNull]
        public string? IDNo { get; set; }
        [AllowNull]
        public string? ReferalNo { get; set; }
        [AllowNull]
        public string? letterNo { get; set; }
        [AllowNull]
        [DataType(DataType.MultilineText)]
        public string? Examination { get; set; }
        public string ExpDate { get; set; } // cbhi expire date
        [Required]
        public string CardNumber { get; set; }
    }
    public class ProvidersReg
    {
        [Required, MaxLength(100)]
        public string? provider { get; set; }
        [Required, MaxLength(100)]
        public string service { get; set; } // link to payment puposes
    }

    public class ProvidersUpdate

    {
        [Required]
        public long id {  get; set; }
        [Required, MaxLength(100)]
        public string? provider { get; set; }
        [Required, MaxLength(100)]
        public string service { get; set; } // link to payment puposes
    }
    public class ProvidersDelete
    {
        public long id {  get; set; }
    }


    public class ProvidersParam
    {
        [Required]
        public string cardnumber {get; set; }
        //[Required]
        //public string provider { get; set; }
    }

}

﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_Project_Code_First.Models
{   
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [DataType("nvarchar(MAX)")]
        [Required]
        public string Title { get; set; }
        [DataType("decimal(5,3)")]
        [Required]
        public decimal Rate { get; set; }
        [DataType(DataType.ImageUrl)]
        [Required]
        public string Photo_Url { get; set; }
        [DataType("nvarchar(max)")]
        [Required]
        public string Author_Name { get; set; }
        [JsonIgnore]
        //Navigation
        public virtual ICollection<Genre> Genres { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserHaveBook> UserHaveBooks { get; set; }
        [InverseProperty("UserWantBooks")]
        [JsonIgnore]
        public virtual ICollection<User> UserWantBooks { get; set; }
    }
}
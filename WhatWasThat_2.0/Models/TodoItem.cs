using System.ComponentModel.DataAnnotations;

namespace WhatWasThat_2._0.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }  
        public bool IsDone { get; set; }
    }
}

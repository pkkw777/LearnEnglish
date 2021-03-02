﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABCCorrectAnswer")]
    [Index(nameof(IdTasksGapsAbcpossibleAnswer), Name = "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABCPossibleAnswer")]
    public partial class TasksGapsZabccorrectAnswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public string Number { get; set; }
        [Column("idTasksGapsABCPossibleAnswer")]
        public int? IdTasksGapsAbcpossibleAnswer { get; set; }

        [ForeignKey(nameof(IdTasksGapsAbcpossibleAnswer))]
        [InverseProperty(nameof(TasksGapsZabcpossibleAnswer.TasksGapsZabccorrectAnswers))]
        public virtual TasksGapsZabcpossibleAnswer IdTasksGapsAbcpossibleAnswerNavigation { get; set; }
    }
}

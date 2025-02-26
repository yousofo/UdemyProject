﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Udemy.Core.Enums;

namespace Udemy.Core.Entities
{
    public class Lesson : BaseEntity
    {

        [StringLength(100)]
        public required string Title { get; set; }
        public int Duration { get; set; }
        public LessonType Type { get; set; }
        public string? VideoUrl { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string? ArticleContent { get; set; }


        // Navigation Properties
        [ForeignKey("Section")]
        public int SectionId { get; set; }
        public Section Section { get; set; }


        // new table 'progress' navigational property
        public List<Progress> Progresses { get; set; }
    }
}

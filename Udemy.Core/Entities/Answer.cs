﻿namespace Udemy.Core.Entities;
public class Answer : BaseEntity
{
    public string AnswerContent { get; set; }
    public int QuestionId { get; set; }
    public int UserId { get; set; }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Core.Entities;
using Udemy.Service.DataTransferObjects.Create;
using Udemy.Service.DataTransferObjects.Read;
using Udemy.Service.DataTransferObjects.Update;

namespace Udemy.Service.IService
{
   public interface ILessonService
    {
        public Task<IEnumerable<LessonRDto>> GetAllAsync(bool trackChanges);
        public Task<LessonRDto> GetByIdAsync(int lessonId, bool trackchange);

        Task<IEnumerable<LessonRDto>> GetLessonsBySectionIdAsync(int sectionId, bool trackChanges);
        Task<bool> CreatelessonAsync(LessonCDto lessonc);
        Task<bool> UpdateAsync(int id, LessonUDto lessonD);
        Task<bool> DeletelesssonAsync(int id);
        
    }
}

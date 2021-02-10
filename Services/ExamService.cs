using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ExamService : BaseService<Exam>, IExamService
    {
        private ProjectContext _context;
        public ExamService(ProjectContext context) : base(context)
        {
            this._context = context;
        }
    }
}

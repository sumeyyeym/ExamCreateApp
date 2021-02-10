using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Core
{
    public interface IEntity
    {

    }
    public class CoreEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}

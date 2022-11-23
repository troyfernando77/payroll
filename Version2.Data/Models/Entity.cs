using System;
using System.Collections.Generic;
using System.Text;

namespace Version2.Data.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
    }
    public  class Entity : IEntity
    {
        public int Id { get; set; }
    }
}

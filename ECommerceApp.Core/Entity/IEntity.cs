using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Core.Entity
{
    public interface IEntity
    {
        [UIHint("hidden")]
        [Key]
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}

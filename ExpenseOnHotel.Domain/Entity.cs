using System;

namespace ExpenseOnHotel.Domain
{
    public abstract class ModelBase : IEntity
    {
        protected ModelBase()
        {
        }

        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

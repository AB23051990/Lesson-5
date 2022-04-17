using System;

namespace HW3.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; private set; }

        public void Delete()
        {
            if (IsDeleted)
                return;
            IsDeleted = true;
        }
    }
}
/*
namespace HW3.DAL.Entities
{
    public class PersonsEntity<TUniqueId> where TUniqueId : struct
    {
        [Column("id")]
        public TUniqueId Id { get; set; }

        [Column("isdeleted")]
        public bool IsDeleted { get; set; }

        
    }
    [Table("user", Schema = "vma")]
    public sealed class Persons : PersonsEntity<int>
    {
        [Column("comment")]
        public string? Comment { get; set; }

        [Column("firstname")]
        public string? FirstName { get; set; }

        [Column("lastname")]
        public string? LastName { get; set; }

        [Column("middlename")]
        public string? MiddleName { get; set; }
    }
}*/
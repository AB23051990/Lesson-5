using HW3.Controllers.Models;

namespace HW3
{
    // Фабрик создания сущностей
    public class SheetDDDFactory
    {
        public SheetDDD Create(Guid guid) => new SheetDDD(guid);
    }
    
    //"Rich Model"
    public class SheetDDD
    {
        private readonly Guid _id;
        private DateTime _approveDate;
        private bool _isApproved;
        private int _amount;
        internal SheetDDD(Guid guid)
        {
            _id = guid;
            _isApproved = false;
        }

        public Guid Id => _id;
        public DateTime ApproveDate => _approveDate;
        public bool IsApproved => _isApproved;

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public void Approve()
        {
            if (_isApproved)
                throw new CannotUnloadAppDomainException();
            _isApproved = true;
            _approveDate = DateTime.Now;
        }
    }
    // Агрегат Person
    public class PersonAggregate : Persons
    {
        private readonly IEnumerable<SheetDDD> _sheets;

        public PersonAggregate(IEnumerable<SheetDDD> sheets)
        {
            _sheets = sheets;
        }

        public bool IsApproved()
        {
            return _sheets.All(x => x.IsApproved);
        }

        public int PendingApprovePages()
        {
            return _sheets.Count(x => !x.IsApproved);
        }
    }
    
}
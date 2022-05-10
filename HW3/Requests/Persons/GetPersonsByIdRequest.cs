namespace HW3.Requests
{
    public class GetPersonsByIdRequest
    {
        public long Id { get; set; }
        public long PersonsId { get; internal set; }
    }
}

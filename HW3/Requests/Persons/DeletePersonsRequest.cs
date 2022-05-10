namespace HW3.Requests
{
    public class DeletePersonsRequest
    {
        public long Id { get; set; }
        public long PersonsId { get; internal set; }
    }
}

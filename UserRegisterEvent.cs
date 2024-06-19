namespace Contracts
{
    public record UserRegisterEvent
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}

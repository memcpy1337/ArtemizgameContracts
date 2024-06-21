namespace Contracts.Events.UserEvents
{
    public record UserRegisterEvent
    {
        public required string Id { get; set; }
        public required string UserName { get; set; }
    }
}

namespace HW3
{
    internal sealed class AuthResponse
    {
        public string? Password { get; set; }

        public RefreshToken? LatestRefreshToken { get; set; }
    }
}

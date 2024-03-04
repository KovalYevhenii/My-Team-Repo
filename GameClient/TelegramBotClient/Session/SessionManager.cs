namespace TelegramBotClient.Session;
internal class SessionManager
{
    private readonly Dictionary<long, UserSession> _sessions = new();

    public UserSession CreateSession(long userId, long chatId)
    {
        var session = new UserSession
        {
            ChatId = chatId,
            UserId = userId,
            SessionId = Guid.NewGuid().ToString(),
        };
        _sessions[userId] = session;
        return session;
    }
    public UserSession GetSession(long userId)
    {
        _sessions.TryGetValue(userId, out var session);
        return session;
    }
    public void DeleteSession(long userId)
    {
        _sessions.Remove(userId);
    }
}

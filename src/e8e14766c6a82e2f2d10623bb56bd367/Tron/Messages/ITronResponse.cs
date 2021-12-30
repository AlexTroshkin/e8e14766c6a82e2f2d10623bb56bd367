namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Базовый интерфейс полученного сообщения из Tron
    /// </summary>
    public interface ITronResponse : ITronMessage
    {
        string Error { get; set; }
    }
}
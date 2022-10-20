namespace TemplateSelectorMAUI.Models
{
    public record ChatModel(string From, string To, string Message, string Image = null)
    {
        public bool ShowImage => Image != null;
    }
}

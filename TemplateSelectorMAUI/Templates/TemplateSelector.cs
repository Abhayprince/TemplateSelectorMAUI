using TemplateSelectorMAUI.Models;

namespace TemplateSelectorMAUI.Templates
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate IncomingMessageTemplate { get; set; }
        public DataTemplate OutgoingMessageTemplate { get; set; }
        public DataTemplate IncomingMessageWithImageTemplate { get; set; }
        public DataTemplate OutgoingMessageWithImageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ChatModel chat)
            {
                if (chat.From != null)
                    return !string.IsNullOrWhiteSpace(chat.Image) 
                            ? IncomingMessageWithImageTemplate 
                            : IncomingMessageTemplate;
                else
                    return !string.IsNullOrWhiteSpace(chat.Image)
                            ? OutgoingMessageWithImageTemplate
                            : OutgoingMessageTemplate;
            }
            throw new NotImplementedException();
        }
    }
}

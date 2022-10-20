using System.Collections.ObjectModel;
using TemplateSelectorMAUI.Models;

namespace TemplateSelectorMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Chats = GetChats();
		BindingContext = this;
    }
	public ObservableCollection<ChatModel> Chats { get; set; }

	private static ObservableCollection<ChatModel> GetChats() =>
		new ObservableCollection<ChatModel>(
			new List<ChatModel>
			{
				new ChatModel("User 1", null, "Did you see the new .Net MAUI video from Abhay Prince?"),
				new ChatModel(null, "User 1", "No I didn't. When was the new video got uploaded?"),
				new ChatModel("User 1", null, "Just now"),
				new ChatModel(null, "User 1", "I did not get the notification. Let me check."),
				new ChatModel(null, "User 1", "Oh yes, I see it","fab_maui.jpg"),				
				new ChatModel(null, "User 1", "Talk to you later, first let me watch the video"),
				new ChatModel("User 1", null, "Seeya"),
			}
		);
}


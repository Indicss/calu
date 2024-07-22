using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Chat
{
    public partial class LoginPage : ContentPage
    {
        public ObservableCollection<string> Messages { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            Messages = new ObservableCollection<string>();
            MessagesCollectionView.ItemsSource = Messages;
        }

        private void OnSendButtonClicked(object sender, EventArgs e)
        {
            string message = MessageEntry.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                Messages.Add(message);
                MessageEntry.Text = string.Empty; // Golește câmpul de text după trimitere
                MessagesCollectionView.ScrollTo(Messages.Count - 1, -1, ScrollToPosition.End, true); // Derulează la ultimul mesaj
            }
        }
    }
}

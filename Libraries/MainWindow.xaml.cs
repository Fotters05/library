using LibraryJson;
using System.Windows;
using Path = System.IO.Path;

namespace Libraries
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void serializationBtn_Click(object sender, RoutedEventArgs e)
        {
            string textToSerialize = inputText.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string jsonFilePath = Path.Combine(desktopPath, "serialized_text.json");
            Json.SerializeToFile(textToSerialize, jsonFilePath);
            inputText.Text = "";
        }

        private void deserializationBtn_Click(object sender, RoutedEventArgs e)
        {
            string jsonFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serialized_text.json");
            string deserializedText = Json.DeserializeFromFile<string>(jsonFilePath);
            if (!string.IsNullOrEmpty(deserializedText))
            {
                dataLbx.Items.Add(deserializedText);
            }
        }

        private void indigoTheme_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "Red";
        }

        private void aquamarineTheme_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "White";
        }
    }
}

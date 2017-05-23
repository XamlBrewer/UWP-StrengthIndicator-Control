using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.StrengthIndicatorClient
{
    public sealed partial class GalleryPage : Page
    {
        public GalleryPage()
        {
            this.InitializeComponent();
        }

        private void StrengthIndicator_ManipulationCompleted(object sender, Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            if (e.Cumulative.Translation.X > 30)
            {
                InteractiveIndicator.Value++;
            }
            else if (e.Cumulative.Translation.X < -30)
            {
                InteractiveIndicator.Value--;
            }
        }
    }
}

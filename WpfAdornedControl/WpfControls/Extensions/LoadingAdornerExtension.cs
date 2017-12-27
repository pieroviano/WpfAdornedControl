using System.Windows;

namespace WpfAdornedControl.WpfControls.Extensions
{
    public static class LoadingAdornerExtension
    {
        public static void StartStopWait(this WpfAdornedControl.AdornedControl loadingAdorner, UIElement uiElement)
        {
            loadingAdorner.IsAdornerVisible = !loadingAdorner.IsAdornerVisible;

            uiElement.Visibility = uiElement.Visibility == Visibility.Visible // condition
                ? Visibility.Collapsed // if-case
                : Visibility.Visible; // else-case
        }
    }
}
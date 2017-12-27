using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using WpfAdornedControl.WpfControls;

namespace WpfAdornedControl
{
    public sealed class AdornedControlWithLoadingWait : AdornedControl
    {
        private AdornedControlWithLoadingWait(FrameworkElement control)
        {
            var loadingWait = new LoadingWait();
            AdornerContent = loadingWait;
            ExternalGrid = new Grid();
            ExternalGrid.Children.Add(control);
            AddChild(ExternalGrid);
        }

        public Grid ExternalGrid { get; set; }

        public static AdornedControlWithLoadingWait AdornControl(IAddChild parentElement, FrameworkElement control)
        {
            var adornedControlWithLoadingWait = new AdornedControlWithLoadingWait(control);
            parentElement.AddChild(adornedControlWithLoadingWait);
            return adornedControlWithLoadingWait;
        }
    }
}
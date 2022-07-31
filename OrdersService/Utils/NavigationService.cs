using System.Windows;
using System.Windows.Controls;

namespace OrdersService.Utils
{
    public class NavigationService
    {
        private ContentControl mainPage;
        private FrameworkElement previousView;
        public void Initialize(ContentControl frame)
        {
            mainPage = frame;
        }
        public void NavigateTo(FrameworkElement view)
        {
            if (mainPage.Content != null)
                previousView = (FrameworkElement)mainPage.Content;
            mainPage.Content = view;
        }
        public void NavigateToPrevious()
        {
            mainPage.Content = previousView;
        }

    }
}

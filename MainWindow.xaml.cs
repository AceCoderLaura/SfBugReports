using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace SfBugReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            OpenPageCommand = new RelayCommand<Type>(OpenPage);
            InitializeComponent();
        }

        private void OpenPage(Type pageType)
        {
            Content = Activator.CreateInstance(pageType);
        }

        public ICommand OpenPageCommand { get; }
    }
}
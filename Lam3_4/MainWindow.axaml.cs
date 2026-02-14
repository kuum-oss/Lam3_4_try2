using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System;
using System.Threading.Tasks;

namespace Lam3_4
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += (s, e) => {
                var statusTime = this.FindControl<TextBlock>("StatusTime");
                if (statusTime != null)
                    statusTime.Text = $"Час: {DateTime.Now.ToLongTimeString()}";
            };
            _timer.Start();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Exit_Click(object? sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void Objekt_Click(object? sender, RoutedEventArgs e)
        {
            await ShowSimpleDialog("Інформація", "Пункт меню Об'єкт");
        }

        private async void New_Click(object? sender, RoutedEventArgs e)
        {
            await ShowSimpleDialog("Новий об'єкт", "Створення нового об'єкта...");
        }

        private async void Edit_Click(object? sender, RoutedEventArgs e)
        {
            await ShowSimpleDialog("Редагування", "Редагування вибраного об'єкта...");
        }

        private async void Save_Click(object? sender, RoutedEventArgs e)
        {
            await ShowSimpleDialog("Збереження", "Дані успішно збережено!");
        }

        private async void About_Click(object? sender, RoutedEventArgs e)
        {
            var about = new AboutWindow();
            await about.ShowDialog(this);
        }

        private async void Undo_Click(object? sender, RoutedEventArgs e)
        {
            await ShowSimpleDialog("Undo", "Дія Undo виконана");
        }

        private async void Remove_Click(object? sender, RoutedEventArgs e)
        {
            var result = await ShowConfirmDialog("Попередження", "Видалити дані по співробітнику?");
            await ShowSimpleDialog("Результат", result ? "Видалення даних" : "Скасування видалення даних");
        }

        private async Task ShowSimpleDialog(string title, string text)
        {
            var dialog = new Window
            {
                Title = title,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                Background = Brushes.White,
                Content = new StackPanel
                {
                    Margin = new Avalonia.Thickness(20),
                    Spacing = 15,
                    Children =
                    {
                        new TextBlock { Text = text, Foreground = Brushes.Black, HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center },
                        new Button 
                        { 
                            Content = "OK", 
                            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                            Width = 60
                        }
                    }
                }
            };

            var stack = (StackPanel)dialog.Content;
            var okBtn = (Button)stack.Children[1];
            okBtn.Click += (s, e) => dialog.Close();

            await dialog.ShowDialog(this);
        }

        private async Task<bool> ShowConfirmDialog(string title, string text)
        {
            var dialog = new Window
            {
                Title = title,
                SizeToContent = SizeToContent.WidthAndHeight,
                MinWidth = 250,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                Background = Brushes.White,
                Content = new StackPanel
                {
                    Margin = new Avalonia.Thickness(20),
                    Spacing = 15,
                    Children =
                    {
                        new TextBlock { Text = text, Foreground = Brushes.Black, TextWrapping = TextWrapping.Wrap },
                        new StackPanel
                        {
                            Orientation = Avalonia.Layout.Orientation.Horizontal,
                            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Right,
                            Spacing = 10,
                            Children =
                            {
                                new Button { Content = "Так", Width = 60 },
                                new Button { Content = "Ні", Width = 60 }
                            }
                        }
                    }
                }
            };

            var stack = (StackPanel)dialog.Content;
            var buttons = (StackPanel)stack.Children[1];
            var yesBtn = (Button)buttons.Children[0];
            var noBtn = (Button)buttons.Children[1];

            bool result = false;
            yesBtn.Click += (s, e) => { result = true; dialog.Close(); };
            noBtn.Click += (s, e) => { result = false; dialog.Close(); };

            await dialog.ShowDialog(this);
            return result;
        }
    }
}

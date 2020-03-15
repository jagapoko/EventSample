using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace EventSample.ViewModels
{
    public class ReactivePropertyViewModel : BindableBase
    {
        public ReactivePropertySlim<string> InputText { get; } = new ReactivePropertySlim<string>("");

        public ReactiveProperty<string> OutputText { get; } = new ReactiveProperty<string>("TextBoxに入力した文字をここに表示します\r\nボタンを押すと文字をすべて消去します");

        public ReactiveCommand<RoutedEventArgs> ButtonClickCommand { get; } = new ReactiveCommand<RoutedEventArgs>();

        public ReactiveCommand<TextCompositionEventArgs> PreviewTextInputCommand { get; } = new ReactiveCommand<TextCompositionEventArgs>();
        public ReactivePropertyViewModel()
        {
            this.ButtonClickCommand.Subscribe(e =>
            {
                this.OutputText.Value = "";
            });

            this.PreviewTextInputCommand.Subscribe(e =>
            {
                this.OutputText.Value += e.Text;
            });
        }
    }
}

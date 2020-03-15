using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace EventSample.ViewModels
{
    public class PrismViewModel : BindableBase
    {
        private string inputText = "";
        public string InputText
        {
            get { return inputText; }
            set { SetProperty(ref inputText, value); }
        }

        private string outputText = "TextBoxに入力した文字をここに表示します\r\nボタンを押すと文字をすべて消去します";
        public string OutputText
        {
            get { return outputText; }
            set { SetProperty(ref outputText, value); }
        }

        private DelegateCommand<RoutedEventArgs> buttonClickCommand;
        public DelegateCommand<RoutedEventArgs> ButtonClickCommand =>
            buttonClickCommand ?? (buttonClickCommand = new DelegateCommand<RoutedEventArgs>(ExecuteButtonClickCommand));

        private DelegateCommand<TextCompositionEventArgs> previewInputTextCommand;
        public DelegateCommand<TextCompositionEventArgs> PreviewTextInputCommand =>
            previewInputTextCommand ?? (previewInputTextCommand = new DelegateCommand<TextCompositionEventArgs>(ExecutePreviewInputText));


        public PrismViewModel()
        {

        }

        void ExecuteButtonClickCommand(RoutedEventArgs e)
        {
            OutputText = "";
        }

        void ExecutePreviewInputText(TextCompositionEventArgs e)
        {
            OutputText += e.Text;
        }

    }
}

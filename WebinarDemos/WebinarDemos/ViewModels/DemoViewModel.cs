using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebinarDemos.ViewModels
{
    class DemoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DemoViewModel(string text = null)
        {
            _text = text;
            _colors = new List<string>();
            foreach (var field in typeof(Xamarin.Forms.Color).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                _colors.Add(field.Name);
            }

        }

        string _text;
        public virtual string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;

                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public List<string> Colors { get => _colors; }
        public string SelectedColor { get => _selectedColor;
            set {
                _selectedColor = value;
                OnPropertyChanged(nameof(SelectedColor));
            }
        }

        List<string> _colors;

        private string _selectedColor = "Red";

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

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
				if(field != null && !String.IsNullOrEmpty(field.Name))
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
		        
		private string _selectedColor = "Red";
		public string SelectedColor { 
			get { 
				return _selectedColor; 
			}
            set {
				if (!string.IsNullOrEmpty(value) && _selectedColor != value)
				{
					_selectedColor = value;
					OnPropertyChanged(nameof(SelectedColor));
				}
            }
        }

        List<string> _colors;
		public List<string> Colors { get { return _colors; } }

        

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

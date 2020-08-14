using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace To_doListApp.Models
{
    class ToDoModelClass : INotifyPropertyChanged
    {
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDateColum { get; set; } = DateTime.Now;   //respond for colums in MainWindow.xaml

        
        private bool _IsDone;
        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _IsDone; }
            set 
            {
                if (_IsDone == value)
                    return;
                _IsDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        private string _MyTask;
        [JsonProperty(PropertyName = "myTask")]
        public string MyTask
        { 
            get { return _MyTask; }
            set 
            {
                if (_MyTask == value)
                    return;
                _MyTask = value;
                OnPropertyChanged("MyTask");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = " ")   //appeal to PropertyChangedEventHandler and calling him
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));                      
        }
    }
}

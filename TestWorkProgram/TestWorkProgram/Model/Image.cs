using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkProgram
{
    public class Image : INotifyPropertyChanged
    {
        private int id;

        private int fromId;

        private int toId;

        private byte[] buffer;

        public virtual User From { get; set; } = null;

        public virtual User To { get; set; } = null;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("id");
            }
        }
        public int FromId
        {
            get
            {
                return fromId;
            }
            set
            {
                fromId = value;
                OnPropertyChanged("fromId");
            }
        }
        public int ToId
        {
            get
            {
                return toId;
            }
            set
            {
                toId = value;
                OnPropertyChanged("toId");
            }
        }
        public byte[] Buffer
        {
            get
            {
                return buffer;
            }
            set
            {
                buffer = value;
                OnPropertyChanged("buffer");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

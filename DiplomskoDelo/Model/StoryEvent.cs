﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace DiplomskoDelo
{
    internal class StoryEvent : INotifyPropertyChanged
    {
        private string eventName;
        private string timeAndDate;
        private bool affectOthers;
        private bool isProactive;

#nullable enable
        private string? eventMap;// nullable
#nullable disable

        private List<Relation> interactions;

        private List<string> notes;

        public StoryEvent(string name, string timeDate)
        {
            eventName = name;
            timeAndDate = timeDate;

            eventMap = null;
            interactions = new List<Relation>();
            notes = new List<string>();
        }

        public string StoryEventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
                OnPropertyChanged("StoryEventName");
            }
        }

        public string StoryEventTime
        {
            get
            {
                return timeAndDate;
            }
            set
            {
                timeAndDate = value;
                OnPropertyChanged("StoryEventTime");
            }
        }

        public bool AffectOthers
        {
            get
            {
                return affectOthers;
            }
            set
            {
                affectOthers = value;
                OnPropertyChanged("AffectOthers");
            }
        }

        public bool StoryEventProactivity
        {
            get
            {
                return isProactive;
            }
            set
            {
                isProactive = value;
                OnPropertyChanged("StoryEventProactivity");
            }
        }

        public string StoryEventMapSource
        {
            get
            {
                return eventMap;
            }
            set
            {
                eventMap = value;
                OnPropertyChanged("StoryEventMapSource");
            }
        }

        public List<Relation> StoryEventRelations
        {
            get
            {
                return interactions;
            }
            set
            {
                interactions = value;
                OnPropertyChanged("StoryEventRelations");
            }
        }

        public List<string> StoryEventNotes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
                OnPropertyChanged("StoryEventNotes");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}
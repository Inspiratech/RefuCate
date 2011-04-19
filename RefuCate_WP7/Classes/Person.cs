using System;
using System.ComponentModel;//for property changed

namespace RefuCate_WPF.Classes
{
    public class Person : INotifyPropertyChanged
    {
        //Saved in same order as table in functional spec
        public enum Gender { MALE, FEMALE };
        public enum HairLength { BALD, VERY_SHORT, SHORT, MEDIUM, LONG, VERY_LONG };
        public enum LifeStatus { ALIVE, DECEASED, UNKNOWN };
        public enum MaritalStatus { MARRIED, SINGLE, DIVORCED };
        public enum SkinColour { CAUCASIAN, ASIAN, BLACK };

        private Gender m_gender;
        public Gender gender
        {
            get { return m_gender; }
            set
            {
                m_gender = value;
                NotifyPropertyChanged("gender");
            }
        }

        private HairLength m_hairLength;
        public HairLength hairLength
        {
            get { return m_hairLength; }
            set
            {
                m_hairLength = value;
                NotifyPropertyChanged("hairLength");
            }
        }

        private LifeStatus m_lifeStatus;
        public LifeStatus lifeStatus
        {
            get { return m_lifeStatus; }
            set
            {
                m_lifeStatus = value;
                NotifyPropertyChanged("lifeStatus");
            }
        }

        private MaritalStatus m_maritalStatus;
        public MaritalStatus maritalStatus
        {
            get { return m_maritalStatus; }
            set
            {
                m_maritalStatus = value;
                NotifyPropertyChanged("maritalStatus");
            }
        }

        private SkinColour m_skinColour;
        public SkinColour skinColour
        {
            get { return m_skinColour; }
            set
            {
                m_skinColour = value;
                NotifyPropertyChanged("skinColour");
            }
        }

        private String m_firstName;
        public String firstName 
        { 
            get{ return m_firstName; }
            set
            {
                m_firstName = value;
                NotifyPropertyChanged("firstName");
            }
        }

        private String m_lastName;
        public String lastName 
        {
            get { return m_lastName; }
            set 
            {
                m_lastName = value;
                NotifyPropertyChanged("lastName");
            }
        }

        private String m_otherNames;
        public String otherNames 
        {
            get { return m_otherNames; }
            set
            {
                m_otherNames = value;
                NotifyPropertyChanged("otherNames");
            }
        }

        private String m_commonName;
        public String commonName 
        {
            get { return m_commonName; }
            set
            {
                m_commonName = value;
                NotifyPropertyChanged("commonName");
            }
        }
       
        //TODO
        public Age age { get; set; }


       // private Image image { get; set; } //TODO: Need some sort of image class that also works on WP7/WPF
        public float height { get; set; }
       // private Color eyeColour { get; set; } //TODO: Need some sort of colour class that also works on WP7/WPF
        private String m_addressOfAsylum;
        public String addressOfAsylum 
        {
            get { return m_addressOfAsylum; }
            set
            {
                m_addressOfAsylum = value;
                NotifyPropertyChanged("addressOfAsylum");
            }
        }
        private String m_addressOfOrigin;
        public String addressOfOrigin
        {
            get { return m_addressOfOrigin; }
            set
            {
                m_addressOfOrigin = value;
                NotifyPropertyChanged("addressOfOrigin");
            }
        }

        private String m_contactDetails;
        public String contactDetails
        {
            get { return m_contactDetails; }
            set
            {
                m_contactDetails = value;
                NotifyPropertyChanged("contactDetails");
            }
        }

        private String m_nationality;
        public String nationality
        {
            get { return m_nationality; }
            set
            {
                m_nationality = value;
                NotifyPropertyChanged("nationality");
            }
        }

        private String m_motherTongue;
        public String motherTongue
        {
            get { return m_motherTongue; }
            set
            {
                m_motherTongue = value;
                NotifyPropertyChanged("motherTongue");
            }
        }

        private String m_lookingFor;
        public String lookingFor
        {
            get { return m_lookingFor; }
            set
            {
                m_lookingFor = value;
                NotifyPropertyChanged("lookingFor");
            }
        }

        private String m_nextOfKin;
        public String nextOfKin
        {
            get { return m_nextOfKin; }
            set
            {
                m_nextOfKin = value;
                NotifyPropertyChanged("nextOfKin");
            }
        }

        private String m_notes;
        public String notes
        {
            get { return m_notes; }
            set
            {
                m_notes = value;
                NotifyPropertyChanged("notes");
            }
        }

        private String m_definingCharacteristics;
        public String definingCharacteristics
        {
            get { return m_definingCharacteristics; }
            set
            {
                m_definingCharacteristics = value;
                NotifyPropertyChanged("definingCharacteristics");
            }
        }

        //TODO Automatically handled, not bound as no input?
        public DateTime timeOfCapture { get; set; }
        public DateTime timeOfLastHit { get; set; }

        public class Age
        {
            public Age(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            //If age in years provided year is calculated, other fields null
            private int day { get; set; }
            private int month { get; set; }
            private int year { get; set; }
        }

        //Used in databinding
        private void NotifyPropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //used in databinding
        public event PropertyChangedEventHandler PropertyChanged;

        public void clear()
        {
            addressOfAsylum = null;
            addressOfOrigin = null;
            commonName = null;
            contactDetails = null;
            definingCharacteristics = null;
            firstName = null;
            gender = 0;
            hairLength = 0;
            lastName = null;
            lifeStatus = 0;
            lookingFor = null;
            maritalStatus = 0;
            motherTongue = null;
            nationality = null;
            nextOfKin = null;
            notes = null;
            otherNames = null;
            skinColour = 0;
        }
    }
}

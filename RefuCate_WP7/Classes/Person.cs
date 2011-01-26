using System;

namespace RefuCate_WPF.Classes
{
    public class Person
    {
        //Saved in same order as table in functional spec
        public enum Gender { MALE, FEMALE };
        public enum HairLength { BALD, VERY_SHORT, SHORT, MEDIUM, LONG, VERY_LONG };
        public enum LifeStatus { ALIVE, DECEASED, UNKNOWN };
        public enum MaritalStatus { MARRIED, SINGLE, DIVORCED };
        public enum SkinColour { CAUCASIAN, ASIAN, BLACK }; //TODO alter, not pc

        public String firstName { get; set; }
        public String lastName { get; set; }
        public String otherNames { get; set; }
        public String commonName { get; set; }
        public Age age { get; set; }
        public Gender gender { get; set; }
       // private Image image { get; set; } //TODO: Need some sort of image class that also works on WP7/WPF
        public float height { get; set; }
       // private Color eyeColour { get; set; } //TODO: Need some sort of colour class that also works on WP7/WPF
        public HairLength hairLength { get; set; }
        public String addressOfAsylum { get; set; }
        public String addressOfOrigin { get; set; }
        public String contactDetails { get; set; }
        public LifeStatus lifeStatus { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public SkinColour skinColour { get; set; }
        public String nationality { get; set; }
        public String motherTongue { get; set; }
        public String lookingFor { get; set; }
        public String nextOfKin { get; set; }
        public String notes { get; set; }
        public String definingCharacteristics { get; set; }
        public DateTime timeOfCapture { get; set; }
        public DateTime timeOfLastHit { get; set; }

        public class Age
        {
            //If age in years provided year is calculated, other fields null
            private int day { get; set; }
            private int month { get; set; }
            private int year { get; set; }
        }
    }
}

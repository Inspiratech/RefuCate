using System;
namespace RefuLib
{
    public class Person
    {
        //Saved in same order as table in functional spec
        private enum Gender { MALE, FEMALE };
        private enum HairLength { BALD, VERY_SHORT, SHORT, MEDIUM, LONG, VERY_LONG };
        private enum LifeStatus { ALIVE, DECEASED, UNKNOWN };
        private enum MaritalStatus { MARRIED, SINGLE };
        private enum SkinColour { CAUCASIAN, ASIAN, BLACK}; //TODO alter, not pc

        private String firstName { get; set; }
        private String lastName { get; set; }
        private String otherNames { get; set; }
        private String commonName { get; set; }
        private Age age { get; set; }
        private Gender gender { get; set; }
        //private Image image { get; set; }
        private float height { get; set; }
        //private Color eyeColour { get; set; }
        private HairLength hairLength { get; set; }
        private String futureLocation { get; set; }
        private String lastKnownLocation { get; set; }
        private String contactDetails { get; set; }
        private LifeStatus lifeStatus { get; set; }
        private MaritalStatus maritalStatus { get; set; }
        private SkinColour skinColour { get; set; }
        private String nationality { get; set; }
        private String motherTongue { get; set; }
        private String lookingFor { get; set; }
        private String nextOfKin { get; set; }
        private String notes { get; set; }
        private String definingCharacteristics { get; set; }
        private DateTime timeOfCapture { get; set; }
        private DateTime timeOfLastHit { get; set; }

        private class Age
        {
            //If age in years provided year is calculated, other fields null
            private int day { get; set; }
            private int month { get; set; }
            private int year { get; set; }
        }
    }
}

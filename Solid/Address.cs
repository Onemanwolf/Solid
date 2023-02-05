using System.Text.RegularExpressions;
using System;
namespace Solid
{
    // Single Responsibility Principle
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private Regex _streetRegex = new Regex(@"\d+ \w+ \w+");
        private Regex _zipRegex = new Regex(@"\d{5}");
        private Regex _stateRegex = new Regex(@"\w{2}");
        private Regex _cityRegex = new Regex(@"\w+");

        public bool ValidateStreet(string street)
        {
           if(_streetRegex.IsMatch(street)){
                return true;
           } ;
           return false;
        }

        public bool ValidateCity(string city)
        {
            if(_cityRegex.IsMatch(city)){
                return true;
            };
            return false;
        }

        public bool ValidateState(string state)
        {
           if(_stateRegex.IsMatch(state)){
                return true;
           };
              return false;
        }

        public bool ValidateZip(string zip)
        {
           if(_zipRegex.IsMatch(zip)){
                return true;
           };
              return false;
        }

        public Address(string street, string city, string state, string zip)
        {
            Street = ValidateStreet(street) == true ? street : throw new ArgumentException("Invalid street");
            City =  ValidateCity(city) == true ? city : throw new ArgumentException("Invalid city");
            State = ValidateState(state) == true ? state : throw new ArgumentException("Invalid state");
            Zip = ValidateZip(zip) == true ? zip : throw new ArgumentException("Invalid zip");
        }

    }
}
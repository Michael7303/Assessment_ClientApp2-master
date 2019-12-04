using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_ClientApp2
{
    /// <summary>
    /// monster entity class
    /// </summary>
    public class Monster
    {
        public enum Tribe
        {
            claw,
            ward,
            brood
        }
        public enum EmotionalState
        {
            none,
            happy,
            sad,
            angry,
            bored
        }

        #region FIELDS

        private string _name;
        private int _age;
        private EmotionalState _attitude;
        private string _birthMonth;
        private Tribe _tribes;

        #endregion

        #region PROPERTIES

        public string BirthMonth
        {
            get { return _birthMonth; }
            set { _birthMonth = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public EmotionalState Attitude
        {
            get { return _attitude; }
            set { _attitude = value; }
        }

        public Tribe Tribes
        {
            get { return _tribes; }
            set { _tribes = value; }
        }


        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name, int age, EmotionalState attitude)
        {
            _name = name;
            _age = age;
            _attitude = attitude;
        }

        #endregion
        
        #region METHODS

        public string Greeting()
        {
            string greeting;

            switch (_attitude)
            {
                case EmotionalState.happy:
                    greeting = $"Hello, my name is {_name} and I am having a great day!";
                    break;

                case EmotionalState.sad:
                    greeting = $"{_name} is feeling bad.";
                    break;

                case EmotionalState.angry:
                    greeting = $"I'm {_name}, and stay away from me!";
                    break;

                case EmotionalState.bored:
                    greeting = $"I don't know what to do at {_age} years old.";
                    break;

                default:
                    greeting = $"Hello, my name is {_name}.";
                    break;
            }
                       
            return greeting;
        }

        #endregion
    }
}

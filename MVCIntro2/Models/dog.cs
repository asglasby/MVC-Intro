using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro2.Models
{
    /// <summary>
    /// This is the dog class
    /// </summary>
    public class Dog
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Sound { get; set; }
       // public int Legs { get; set; }
        private int legs;

        public int Legs
        {
            get { return legs; }
            set
            {
                if (value <= 4)
                { legs = value; }
                else
                {
                    legs = 4;
                }
            }
        }

        /// <summary>
        /// This is the default Constructor
        /// </summary>
        public Dog() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        public Dog(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
            this.legs = 15;
            this.Sound = "Woof";
        }
        public Dog(string sound)
        {

            this.Sound = sound;
        }
        public string Speak()
        {
            return this.Sound;
        }
    }
}
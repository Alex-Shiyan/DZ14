using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ14
{
    internal class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string voice;
        public string Voice
        {
            get { return voice; }
            set { voice = value; }
        }
        public Dog(string name, string voice)
            : base(name)
        {
            this.Voice = voice;
        }
        public override void Say()
        {
            Console.WriteLine("Громко лает: \t{0}",Voice);
        }
    }
}

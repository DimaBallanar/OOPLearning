using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
    public class PatterPrototype : IAnimal
    {
        private string name;
        public PatterPrototype() { }
        private PatterPrototype(PatterPrototype donor) => name = donor.name;
        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public IAnimal Clone() => new PatterPrototype(this);

    }
}


using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace NumeneraCharacterSheet

{

    class Attribute

    {

        public int Current { get; set; }

        public int Max { get; set; }

        public int Edge { get; set; }



        public Attribute()

        {

            this.Current = 10;

            this.Max = 10;

            this.Edge = 0;

        }

    }

}

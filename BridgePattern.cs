using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_BridgePattern
{
    public interface ISaris
    {
        void Display();
    }

    public class BanarasiSari : ISaris
    {

        public void Display()
        {
            Console.WriteLine("This is banarasi sari");
        }
    }

    public class CottonSari : ISaris
    {

        public void Display()
        {
            Console.WriteLine("This is Cotton sari");
        }
    }


    public abstract class cloths
    {
        protected ISaris saris;
        public cloths(ISaris saris)
        {
            this.saris = saris;
        }

        public abstract void Show();
    }

    public class SarisClothing : cloths
    {
        public SarisClothing(ISaris saris) :base(saris)
        {

        }

        public override void Show()
        {
            saris.Display();
        }
    }


    public class Program
    {
        public void Main()
        {
            cloths cloths = new SarisClothing(new BanarasiSari());
            cloths.Show();
            cloths = new SarisClothing(new CottonSari());
            cloths.Show();
            
        }
    }
}

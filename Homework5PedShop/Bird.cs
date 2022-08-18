namespace Homework5PedShop
{
    public class Bird : Animal
    {
        public override void Eat()
        {
            Energy += 10;
            Size += 2;
            Price += 3;
        }

        public override void Play()
        {
            Energy -= 15;
        }

        public override void Sleep()
        {
            Energy += 30;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

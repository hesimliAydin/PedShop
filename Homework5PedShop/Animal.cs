namespace Homework5PedShop
{
    public abstract class Animal
    {
        public string NickName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Energy { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();

        public override string ToString()
        {
            return $@"Nick Name: {NickName}
                      Age: {Age}
                      Gender: {Gender}
                      Energy: {Energy}
                      Price: {Price}
                      Size: {Size}";
        }
    }
}

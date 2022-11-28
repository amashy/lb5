namespace lb52
{
    public class GoodPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Good pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. Can read a small book");
        }

        public override void Relax()
        {
            Console.WriteLine("2. Can relax sometimes");
        }

        public override void Study()
        {
            Console.WriteLine("3. Obviously like studying");
        }

        public override void Write()
        {
            Console.WriteLine("4. Can write a text");
        }
    }
}
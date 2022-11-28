namespace lb52
{
    public class BadPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Bad pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. Can't read anything");
        }

        public override void Relax()
        {
            Console.WriteLine("2. Loves relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("3. Don't like studying");
        }

        public override void Write()
        {
            Console.WriteLine("4. Can't write anything");
        }
    }
}
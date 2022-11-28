namespace lb52
{
    public class ExcelentPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Excelent pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. Can read a big book");
        }

        public override void Relax()
        {
            Console.WriteLine("2. Never relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("3. Loves studying");
        }

        public override void Write()
        {
            Console.WriteLine("4. Can write a book");
        }
    }
}
namespace lb52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new List<Pupil> { new BadPupil(), new GoodPupil(), new ExcelentPupil() });
            classRoom.Print();
        }
    }
}
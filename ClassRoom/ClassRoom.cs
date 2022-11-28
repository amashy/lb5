namespace lb52
{
    public class ClassRoom
    {
        public List<Pupil> Pupils;

        public ClassRoom(List<Pupil> pupils)
        {
            Pupils = pupils;
        }

        public void Print()
        {
            foreach (Pupil pupil in Pupils)
            {
                pupil.Level();
                pupil.Read();
                pupil.Relax();
                pupil.Study();
                pupil.Write();
                Console.WriteLine();
            }
        }
    }
}
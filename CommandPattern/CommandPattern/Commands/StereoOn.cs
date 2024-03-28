namespace CommandPattern
{
    public class StereoOn : ICommand
    {
        Stereo Stereo { get; set; }
        public StereoOn(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void execute()
        {
            Stereo.On();
            Stereo.setCd();
        }

        public void undo()
        {
            Stereo.Off();
        }
    }
}
namespace CommandPattern
{
    public class StereoOff : ICommand
    {
        Stereo Stereo { get; set; }
        public StereoOff(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void execute()
        {
            Stereo.Off();

        }

        public void undo()
        {
            Stereo.On();
        }
    }
}
namespace CommandPattern;

public class LightOffCommand : ICommand
{
    Light Light { get; set; }
    public LightOffCommand(Light light)
    {
        Light = light;
    }
    public void execute()
    {
        Light.Off(); 

    }
}
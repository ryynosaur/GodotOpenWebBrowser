using Godot;

public class TwitterButtonPress : TextureButton
{
    [Export]
    public string TwitterHandler;
	private void _on_TwitterButton_pressed()
	{
        OS.ShellOpen($"https://twitter.com/{TwitterHandler}");
	}
}




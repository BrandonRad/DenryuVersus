using Godot;

namespace Cameras
{
  public partial class MainCamera : Camera2D
  {
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
      if (Input.IsActionPressed("zoom_in"))
      {
        Zoom *= 1.01f;
      }

      if (Input.IsActionPressed("zoom_out"))
      {
        Zoom /= 1.01f;
      }
    }
  }
}
using Godot;
using System;

public partial class Disclaimer : Control
{
	[Export] private RichTextLabel DisclaimerLabel;
	[Export] private AnimationPlayer AnimPlayer;

	[Export] private bool CanProgress = false;

	public override void _Ready()
	{
		AnimPlayer.Play("reveal");
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept") && CanProgress == true)
		{
			LoadingScreenManager.Instance.LoadScene("res://Scenes/MainMenu.tscn");
		}
	}
}

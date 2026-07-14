using Godot;
using System;

public partial class ArrowHolder : Node2D
{
	public override void _Ready()
	{
		GetNode<AnimationPlayer>("AnimationPlayer").Play("bounce");
	}
}

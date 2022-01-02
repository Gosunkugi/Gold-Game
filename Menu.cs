using Godot;
using System;

//githubtest
public class Menu : Control
{

	

	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		
	}

		private void _on_StartButton_pressed()
	{
		 GetTree().ChangeScene("res://Shop.tscn");
	}

	
	private void _on_AboutButton_pressed()
	{
		var about = this.GetNode<VBoxContainer>("AboutContainer");
		var menu = this.GetNode<VBoxContainer>("MainMenuContainer");
		about.Visible = true;
		menu.Visible = false;
	}

	private void _on_AbackButton_pressed()
	{
		var about = this.GetNode<VBoxContainer>("AboutContainer");
		var menu = this.GetNode<VBoxContainer>("MainMenuContainer");
		about.Visible = false;
		menu.Visible = true;
	}


}

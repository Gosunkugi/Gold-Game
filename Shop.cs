using Godot;
using System;
using Engine.Factories;



public class Shop : Node2D
{
	int survivalPoints = 0;

	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	

	//BUY SHIT WITH MONEY
	private void _on_BuyButton_pressed()
	{
		var greeting = this.GetNode<Label>("GreetingLabel");
		greeting.Text = "what would you like to buy?";

		survivalPoints = survivalPoints + 1;
		var survivalLabel = this.GetNode<Label>("SurvivaLLabel/SurvivalPtLabel");
		survivalLabel.Text = survivalPoints.ToString();

	}

	//SELL NUGGETS FOR MONEY
	private void _on_SellButton_pressed()
	{
		var greeting = this.GetNode<Label>("GreetingLabel");
		greeting.Text = "what would you like to sell?";


	}

	//GO BACK TO MAP MENU
	private void _on_LeaveButton_pressed()
	{
		GetTree().ChangeScene("res://Map.tscn");
	}
}










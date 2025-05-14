using Godot;
using System;

public partial class Matrices : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		int [ , ] matrices = new int [11,11];
		
		for (int i = 1 ; i < 11; i++){
			GD.Print(" ");
			 for (int y = 1; y < 11; y++){
				 matrices [i,y]= i * y;
				GD.Print((y) + " * " + (i) + " = " + matrices [i,y] + " " );
				
				
				}
			
			
			}
		
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

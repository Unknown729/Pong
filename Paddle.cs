using Godot;
using System;

public class Paddle : KinematicBody2D
{
    private const int MoveSpeed = 400;

    public override void _Ready()
    {

    }

    public Vector2 velocity = new Vector2();
    public void GetInput()
    {
        velocity = new Vector2();
        if (Input.IsActionPressed("_down"))
            { velocity.y += 1;         }
        if (Input.IsActionPressed("_up"))
            velocity.y -= 1;
        velocity = velocity.Normalized() *MoveSpeed;
    }

    public override void _PhysicsProcess(float delta)
    {
        GetInput();
        velocity = MoveAndSlide(velocity);
    }

}

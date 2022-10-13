using Godot;
using System;

public class Ball : KinematicBody2D
{
    private const int speed = 600;
    public Vector2 direction = Vector2.Left;

    private Vector2 _initialPosition;
    private float _speed = speed;
        
    public override void _Ready()
    {
        _initialPosition = Position;
    }

    public override void _Process(float delta)
    {
        _speed += delta*2;
        Position += _speed * delta * direction;
    }

    public void Reset()
    {
        direction = Vector2.Left;
        Position = _initialPosition;
        _speed = speed;
    }

}
// how to make the ball move onto random direction. wtf!!!!

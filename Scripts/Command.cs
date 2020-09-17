using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Rigidbody Player;
    public abstract void Exe();
}

class MoveLeft : Command
{
    private float Force;
    
    public MoveLeft(Rigidbody player, float force)
    {
        Player = player;
        Force = force;
    }

    public override void Exe()
    {
        Player.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class MoveRight : Command
{
    private float Force;

    public MoveRight(Rigidbody player, float force)
    {
        Player = player;
        Force = force;
    }

    public override void Exe()
    {
        Player.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
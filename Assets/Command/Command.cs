using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command 
{
    public abstract void Excute(Animator anim);
}
public class PerformJump:Command
{
    public override void Excute(Animator anim)
    {
        anim.SetTrigger("isJumping");
    }
}
public class PerformPunch : Command
{
    public override void Excute(Animator anim)
    {
        anim.SetTrigger("isPunching");
    }
}
public class PerformKick : Command
{
    public override void Excute(Animator anim)
    {
        anim.SetTrigger("isKicking");
    }
}
public class MoveForward : Command
{
    public override void Excute(Animator anim)
    {
        anim.SetTrigger("isWalking");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private Command comm;

    public void SetCommand(Command command)
    {
        comm = command;
    }

    public void ExeCommand()
    {
        CommandLog.commands.Enqueue(comm);
        comm.Exe();
    }
}


﻿namespace Assignment.InterfaceCommand;

public interface RobotCommand
{
    void Run(Robot robot); // Interfaces are public and abstract by default.
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot) => robot.IsPowered = false;
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot) => robot.IsPowered = true;
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors.Data
{
    public enum PhysicsLayers
    {
        Wall,
        PlayerMove,
        PlayerHurt,
        PlayerShot,
        EnemyMove,
        EnemyHurt,
        EnemyShot,
        FollowCamJunk,
        LiterallyNothing,
        Pickups,
        PlayerTrigger
    }

    public enum RenderLayers
    {
        UI = -10,
        Foreground,
        Object,
        Tiles,
        Background,
        FurtherBackground
    }
}

using Microsoft.Xna.Framework;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors.Data
{
    public static class Input
    {
        #region move
        public static Vector2 LeftStick => Vector2Ext.Normalize(new Vector2(IsLeftDown ? -1 : IsRightDown ? 1f : 0, IsUpDown ? -1 : IsDownDown ? 1 : 0));

        //left
        public static bool IsLeftDown => Nez.Input.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.A);
        public static bool IsLeftPressed => Nez.Input.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.A);
        public static bool IsLeftReleased => Nez.Input.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.A);
        //right
        public static bool IsRightDown => Nez.Input.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.D);
        public static bool IsRightPressed => Nez.Input.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.D);
        public static bool IsRightReleased => Nez.Input.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.D);
        //Up
        public static bool IsUpDown => Nez.Input.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.W);
        public static bool IsUpPressed => Nez.Input.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.W);
        public static bool IsUpReleased => Nez.Input.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.W);
        //Down
        public static bool IsDownDown => Nez.Input.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.S);
        public static bool IsDownPressed => Nez.Input.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.S);
        public static bool IsDownReleased => Nez.Input.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.S);
        #endregion

        #region shoot
        #endregion

    }
}

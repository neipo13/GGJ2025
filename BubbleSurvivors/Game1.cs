using BubbleSurvivors.Scenes;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors
{
    public class Game1 : Core
    {
        public const int DESIGN_WIDTH = 1920;
        public const int DESIGN_HEIGHT = 1080;
        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;
            Scene = new GameScene();
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors.Scenes
{
    public class GameScene : Scene
    {
        public override void OnStart()
        {
            base.OnStart();
            ClearColor = Color.Black;
            var testEntity = new Entity("test").SetPosition(500,500);
            var testSpr = Content.Load<Texture2D>("img/bubble.png");
            var spriteRendered = new SpriteRenderer(testSpr);
            testEntity.AddComponent(spriteRendered);
            AddEntity(testEntity);
        }
    }
}

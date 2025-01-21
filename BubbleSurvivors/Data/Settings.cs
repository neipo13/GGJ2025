using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors.Data
{
    public class Settings
    {
        public Settings()
        {
            musicVolume = 50;
            sfxVolume = 50;
            isFullscreen = false;
            windowWidth = Game1.DESIGN_WIDTH;
            windowHeight = Game1.DESIGN_HEIGHT;
            isScreenshakeOn = true;
        }

        public bool isFullscreen { get; set; }
        public int musicVolume { get; set; }
        public int sfxVolume { get; set; }
        public float sfxVolumeMultiplier => (Mathf.Exp(sfxVolume / 100f) - 1f) / ((float)System.Math.E - 1f);
        public float musicVolumeMultiplier => (Mathf.Exp(musicVolume / 100f) - 1f) / ((float)System.Math.E - 1f);

        public int windowWidth { get; set; }
        public int windowHeight { get; set; }

        public bool isScreenshakeOn { get; set; }

    }
}

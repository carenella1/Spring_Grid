using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Springing_Background
{
    static class Art
    {
       public static Texture2D Pixel {get; private set;}
       public static Texture2D Player { get; private set; }

		public static void Load(ContentManager content)
        {
            Player = content.Load<Texture2D>("Art/Player");

            Pixel = new Texture2D(Player.GraphicsDevice, 1, 1);
            Pixel.SetData(new[] {Color.White});
		}
	}
 }


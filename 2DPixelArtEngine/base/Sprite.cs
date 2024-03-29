﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2DPixelArtEngine
{
    public class Sprite
    {
        public Texture2D Texture;
        public Rectangle Cropping;

        public Sprite(Texture2D texture, Rectangle? cropping = null)
        {
            Texture = texture;
            if (cropping != null)
                Cropping = (Rectangle)cropping;
            else
                Cropping = Texture.Bounds;
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color, Vector2 scale, Vector2 offset = new Vector2())
        {
            spriteBatch.Draw(Texture, new Rectangle((int)offset.X, (int)offset.Y, (int)(Cropping.Width * scale.X), (int)(Cropping.Height * scale.Y)), Cropping, color);
        }

        public virtual Sprite Clone()
        {
            return new Sprite(Texture, Cropping);
        }
    }
}

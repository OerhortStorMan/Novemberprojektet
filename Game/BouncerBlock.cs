using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Game
{
    public class BouncerBlock : GameObject
    {
        public KeyboardKey leftKey;
        public KeyboardKey rightKey;
        
        public BouncerBlock(float xStart, float yStart, KeyboardKey left, KeyboardKey right)
        {
            rectangle = new Rectangle(xStart, yStart, 100, 20);
            // x = xStart;
            // y = yStart;
            leftKey = left;
            rightKey = right;

            gameObjects.Add(this);
        }

        public override void Update()
        {
            if (Raylib.IsKeyDown(leftKey))
            {
                rectangle.x -= 20f;
            }

            if (Raylib.IsKeyDown(rightKey))
            {
                rectangle.x += 20f;
            }
        }

    
    }
}

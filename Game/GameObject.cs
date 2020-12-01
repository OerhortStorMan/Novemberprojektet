using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Game
{
    public class GameObject
    {
        public Rectangle rectangle;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public virtual void Update()
        {

        }

        public static void UpdateAll()
        {
            foreach (GameObject thing in gameObjects)
            {
                thing.Update();
            }
        }

        public virtual void Draw()
        {
            Raylib.DrawRectangleRec(rectangle, Color.WHITE);
        }

         public static void DrawAll()
        {
            foreach (GameObject thing in gameObjects)
            {
                thing.Draw();
            }
        }


    }
}

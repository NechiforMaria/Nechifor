using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Nechifor
{
    class Cub
    {
        KeyboardState lastKeyPress;
        private Color colorisation;
        private Color colorisation1;
        private Color colorisation2;
        private bool visibility;
        // CONST
        private readonly Color GRIDCOLOR = Color.AntiqueWhite;

        public Cub()
        {
            colorisation = GRIDCOLOR;
            colorisation2 = Color.AntiqueWhite;
            visibility = true;
        }

        public void Show()
        {
            visibility = true;
        }

        public void Hide()
        {
            visibility = false;
        }

        public void ToggleVisibility()
        {
            visibility = !visibility;
        }
        public void ChangeColor(Color col)
        {

            colorisation = col;
        }
        public void ChangeColor2(Color col)
        {

            colorisation2 = col;
        }
        public void ChangeColor1(int r, int g, int b)
        {
            if (r < 256 && g < 256 && b < 256)
                colorisation1 = Color.FromArgb(r, g, b);
        }

        public void Draw()
        {
            if (visibility)
            {
                GL.Begin(PrimitiveType.Quads);

                GL.Color3(colorisation);
                GL.Vertex3(-1.0f, -1.0f, -1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f);

                GL.Color3(colorisation);
                GL.Vertex3(-1.0f, -1.0f, -1.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f);

                GL.Color3(colorisation2);

                GL.Vertex3(-1.0f, -1.0f, -1.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f);

                GL.Color3(colorisation2);
                GL.Vertex3(-1.0f, -1.0f, 1.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f);

                GL.Color3(colorisation);
                GL.Vertex3(-1.0f, 1.0f, -1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f);

                GL.Color3(colorisation1);
                GL.Vertex3(1.0f, -1.0f, -1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f);

                GL.End();
            }

        }
    
}
}

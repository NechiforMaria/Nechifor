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

namespace Sample_1
{
    class Triangle
    {
        private Color colorisation;
        private Color colorisation1;
        private Color colorisation2;
        private Color colorisation3;
        private bool visibility;
        // CONST
        private readonly Color GRIDCOLOR = Color.WhiteSmoke;


        public Triangle()
        {
            colorisation1 = GRIDCOLOR;
            colorisation2 = GRIDCOLOR;
            colorisation3 = GRIDCOLOR;
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
        public void ChangeColor1(int r, int g, int b)
        {
            if (r < 256 && g < 256 && b < 256)
                colorisation1 = Color.FromArgb(r, g, b);
        }
        public void ChangeColor2(int r, int g, int b)
        {
            if (r < 256 && g < 256 && b < 256)
                colorisation2 = Color.FromArgb(r, g, b);
        }
        public void ChangeColor3(int r, int g, int b)
        {
            if (r < 256 && g < 256 && b < 256)
                colorisation3 = Color.FromArgb(r, g, b);
        }
        public void Draw()
        {
            if (visibility)
            {
                GL.Begin(BeginMode.Triangles);
                GL.Color3(colorisation1);

                GL.Vertex3(0F, 1F, 0);

                GL.Color3(colorisation2);

                GL.Vertex3(1, 0f, 0);

                GL.Color3(colorisation3);

                GL.Vertex3(0, 0, 1);
                GL.End();
            }

        }

    }
}

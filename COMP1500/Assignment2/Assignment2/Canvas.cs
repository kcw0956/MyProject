using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Assignment2.EShape;

namespace Assignment2
{
    public class Canvas
    {
        public static char[,] BackGround(uint width, uint height)
        {
            char bar = char.Parse("-");
            char stick = char.Parse("|");
            char spaceBar = char.Parse(" ");
            char[,] backGround = new char[height + 4, width + 4];


            for (int i = 0; i < height + 4; i++)
            {
                for (int j = 0; j < width + 4; j++)
                {
                    backGround[i, j] = bar;
                }
            }
            for (int i = 1; i < height + 3; i++)
                backGround[i, 0] = stick;

            for (int i = 1; i < height + 3; i++)
                backGround[i, width + 3] = stick;

            for (int i = 1; i < height + 3; i++)
            {
                for (int j = 1; j < width + 3; j++)
                {
                    backGround[i, j] = spaceBar;
                }
            }
            return backGround;
        }
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            char r = char.Parse("*");
            char spaceBar = char.Parse(" ");
            char[,] canvas = new char[0, 0];
            char[,] backGround = BackGround(width, height);

            switch (shape)
            {

                case EShape.Rectangle:
                    {
                        BackGround(width, height);
                        for (int i = 2; i < height + 2; i++)
                        {
                            for (int j = 2; j < width + 2; j++)
                            {
                                backGround[i, j] = r;
                                canvas = backGround;
                            }
                        }
                        break;
                    }

                case EShape.IsoscelesRightTriangle:
                    {

                        BackGround(width, height);

                        if (width != height)
                            return canvas;

                        for (int i = 2; i < height + 2; i++)
                        {

                            for (int k = 2; k < i + 1; k++)
                            {
                                backGround[i, k] = r;
                                canvas = backGround;
                            }
                        }


                    }
                    break;

                case EShape.Circle:
                    {
                        BackGround(width, height);
                        if (width != height || width % 2 == 0)
                            return canvas;

                        for (int i = -(int)(width / 2 + 3); i <= (width / 2 + 3); i++)
                            for (int j = -(int)(width / 2 + 3); j <= -(int)(width / 2 + 3); j++)
                            {
                                if (i * i + j * j <= (width / 2 + 2) * (width / 2 + 2)){
                                    backGround[i, j] = r;
                                    canvas = backGround;
                                    return canvas;
                                }
                            }

                        break;
                    }

                case EShape.IsoscelesTriangle:
                    {
                        BackGround(width, height);

                        if (width != height * 2 - 1)
                            return canvas;

                        if (width == 1 || height == 1)
                        {
                                                 
                            backGround[2, 2] = r;
                        }
                


                        for (int i = 2; i < height + 2; i++)
                        {
                            for (int j = 2; j < width + 2; j++)
                            {
                                backGround[i, j] = r;
                                
                            }
                            for (int k = 2; k <= width / 2 + 3 - i; k++)
                            {
                                backGround[i, k] = spaceBar;
                                canvas = backGround;
                            }
                            for (int j = (int)(width / 2 + 1 + i); j < width + 2; j++)
                            {
                                backGround[i, j] = spaceBar;
                                canvas = backGround;
                            }
                        }
                        break;
                    }
            }
            return canvas;
        }
        public static bool IsShape(char[,] canvas, EShape shape)
        {
            uint height = (uint)canvas.GetLength(0);
            uint width = (uint)canvas.GetLength(1);
            char[,] newCanvas = Canvas.Draw((uint)canvas.GetLength(0), (uint)canvas.GetLength(1), EShape.shape);


            switch (shape)
            {
                case Circle:
                    {
                        if (canvas == newCanvas)
                            return true;
                        else
                            return false;

                    }
                case Rectangle:
                    {
                        if (canvas == newCanvas)
                            return true;
                        else
                            return false;
                    }
                case IsoscelesRightTriangle:
                    {
                        if (canvas == newCanvas)
                            return true;
                        else
                            return false;
                    }
                case IsoscelesTriangle:
                    {
                        if (canvas == newCanvas)
                            return true;
                        else
                            return false;
                    }
                    
            }
            
            return false;
        }
    }
}

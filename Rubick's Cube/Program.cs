using System;
using System.Threading;

namespace Rubick_s_Cube
{
    class Program
    {
        public struct Cube
        {
            public int Tiles;
            public string[,] Top;
            public string[,] Left;
            public string[,] Front;
            public string[,] Right;
            public string[,] Back;
            public string[,] Bottom;

            public bool forUse;

            public static void Generate(ref Cube cube, int s)
            {
                cube.forUse = true;

                cube.Tiles = s;
                cube.Top = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Top[i, j] = "White";
                    }
                }
                cube.Left = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Left[i, j] = "Magenta";
                    }
                }
                cube.Front = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Front[i, j] = "Green";
                    }
                }
                cube.Right = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Right[i, j] = "Red";
                    }
                }
                cube.Back = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Back[i, j] = "Blue";
                    }
                }
                cube.Bottom = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        cube.Bottom[i, j] = "Yellow";
                    }
                }
            }
            private static void Color(Cube cube, string side, int x, int y)
            {
                string color = null;

                if (side == "Top")
                {
                    color = cube.Top[x, y];
                }
                else if (side == "Left")
                {
                    color = cube.Left[x, y];
                }
                else if (side == "Front")
                {
                    color = cube.Front[x, y];
                }
                else if (side == "Right")
                {
                    color = cube.Right[x, y];
                }
                else if (side == "Back")
                {
                    color = cube.Back[x, y];
                }
                else if (side == "Bottom")
                {
                    color = cube.Bottom[x, y];
                }

                if (color == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color == "Magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (color == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
            public static void Draw(Cube cube)
            {
                if (cube.forUse)
                {
                    Console.Clear();
                }

                //title
                if (cube.forUse == false)
                {
                    Console.Write(" ");
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Top", cube.Tiles - 1, i);
                        Console.Write(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
                    }
                    Console.WriteLine();
                    for (int h = 0; h < cube.Tiles; h++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Color(cube, "Left", h, cube.Tiles - 1);
                            Console.Write("█");
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                Color(cube, "Front", h, i);
                                Console.Write(" ██████████████ ");                                
                            }
                            Color(cube, "Right", h, 0);
                            Console.Write("█");
                            Console.WriteLine();
                        }
                        if (h < cube.Tiles - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.Write(" ");
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Bottom", 0, i);
                        Console.Write(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ");
                    }
                }

                //big
                else if (cube.Tiles * 4 + 2 < Console.LargestWindowHeight)
                {                    
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Top", cube.Tiles - 1, i);
                        Console.Write(" ─────── ");
                    }
                    Console.WriteLine();                    
                    for (int h = 0; h < cube.Tiles; h++)
                    {
                        for (int j = 0; j < 3; j++)
                        {                            
                            Color(cube, "Left", h, cube.Tiles - 1);
                            Console.Write("│");
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                Color(cube, "Front", h, i);
                                Console.Write("███████");
                                if (i < cube.Tiles - 1)
                                {
                                    Console.Write("  ");
                                }
                            }
                            Color(cube, "Right", h, 0);
                            Console.Write("│");
                            Console.WriteLine();
                        }
                        if (h < cube.Tiles - 1)
                        {
                            Console.WriteLine();
                        }
                    }                    
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Bottom", 0, i);
                        Console.Write(" ─────── ");
                    }
                }

                //medium
                else if (cube.Tiles * 3 + 2 < Console.LargestWindowHeight)
                {
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Top", cube.Tiles - 1, i);
                        Console.Write(" ───── ");
                    }
                    Console.WriteLine();

                    for (int h = 0; h < cube.Tiles; h++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Color(cube, "Left", h, cube.Tiles - 1);
                            Console.Write("│");
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                Color(cube, "Front", h, i);
                                Console.Write("█████");
                                if (i < cube.Tiles - 1)
                                {
                                    Console.Write("  ");
                                }
                            }
                            Color(cube, "Right", h, 0);
                            Console.Write("│");
                            Console.WriteLine();
                        }
                        if (h < cube.Tiles - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Bottom", 0, i);
                        Console.Write(" ───── ");
                    }
                }

                //small
                else if (cube.Tiles * 2 + 2 < Console.LargestWindowHeight)
                {
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Top", cube.Tiles - 1, i);
                        Console.Write(" ── ");
                    }
                    Console.WriteLine();

                    for (int h = 0; h < cube.Tiles; h++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Color(cube, "Left", h, cube.Tiles - 1);
                            Console.Write("│");
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                Color(cube, "Front", h, i);
                                Console.Write("██");
                                if (i < cube.Tiles - 1)
                                {
                                    Console.Write("  ");
                                }
                            }
                            Color(cube, "Right", h, 0);
                            Console.Write("│");
                            Console.WriteLine();
                        }
                        if (h < cube.Tiles - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Bottom", 0, i);
                        Console.Write(" ── ");
                    }
                }

                //disorientingly small
                else
                {
                    Console.Write(" ");
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Top", cube.Tiles - 1, i);
                        Console.Write("──");
                    }
                    Console.WriteLine();

                    for (int h = 0; h < cube.Tiles; h++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Color(cube, "Left", h, cube.Tiles - 1);
                            Console.Write("│");
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                Color(cube, "Front", h, i);
                                Console.Write("██");
                            }
                            Color(cube, "Right", h, 0);
                            Console.Write("│");
                            Console.WriteLine();
                        }
                    }
                    Console.Write(" ");
                    for (int i = 0; i < cube.Tiles; i++)
                    {
                        Color(cube, "Bottom", 0, i);
                        Console.Write("──");
                    }
                }
                Console.WriteLine();
            }
            public static void Turn(Cube cube, string layer, string turn)
            {
                //generate
                Cube delta = new Cube();
                int s = cube.Tiles;
                delta.Tiles = s;
                delta.Top = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Top[i, j] = cube.Top[i, j];
                    }
                }
                delta.Left = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Left[i, j] = cube.Left[i, j];
                    }
                }
                delta.Front = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Front[i, j] = cube.Front[i, j];
                    }
                }
                delta.Right = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Right[i, j] = cube.Right[i, j];
                    }
                }
                delta.Back = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Back[i, j] = cube.Back[i, j];
                    }
                }
                delta.Bottom = new string[s, s];
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        delta.Bottom[i, j] = cube.Bottom[i, j];
                    }
                }
                //generate

                //turn
                if (cube.Tiles > 1)
                {
                    if (layer == "U")
                    {
                        if (turn == "right")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[i, j] = delta.Top[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[0, i] = delta.Left[0, i];

                                cube.Left[0, i] = delta.Back[0, i];

                                cube.Back[0, i] = delta.Right[0, i];

                                cube.Right[0, i] = delta.Front[0, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[i, j] = delta.Top[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[0, i] = delta.Right[0, i];

                                cube.Right[0, i] = delta.Back[0, i];

                                cube.Back[0, i] = delta.Left[0, i];

                                cube.Left[0, i] = delta.Front[0, i];
                            }
                        }
                    }
                    else if (layer == "E")
                    {
                        if (turn == "right")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Left[i, j];

                                    cube.Left[i, j] = delta.Back[i, j];

                                    cube.Back[i, j] = delta.Right[i, j];

                                    cube.Right[i, j] = delta.Front[i, j];
                                }
                            }
                        }
                        else if (turn == "left")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Right[i, j];

                                    cube.Right[i, j] = delta.Back[i, j];

                                    cube.Back[i, j] = delta.Left[i, j];

                                    cube.Left[i, j] = delta.Front[i, j];
                                }
                            }
                        }
                    }
                    else if (layer == "D")
                    {
                        if (turn == "right")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Bottom[i, j] = delta.Bottom[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[cube.Tiles - 1, i] = delta.Left[cube.Tiles - 1, i];

                                cube.Left[cube.Tiles - 1, i] = delta.Back[cube.Tiles - 1, i];

                                cube.Back[cube.Tiles - 1, i] = delta.Right[cube.Tiles - 1, i];

                                cube.Right[cube.Tiles - 1, i] = delta.Front[cube.Tiles - 1, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Bottom[i, j] = delta.Bottom[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[cube.Tiles - 1, i] = delta.Right[cube.Tiles - 1, i];

                                cube.Right[cube.Tiles - 1, i] = delta.Back[cube.Tiles - 1, i];

                                cube.Back[cube.Tiles - 1, i] = delta.Left[cube.Tiles - 1, i];

                                cube.Left[cube.Tiles - 1, i] = delta.Front[cube.Tiles - 1, i];
                            }
                        }
                    }

                    else if (layer == "L")
                    {
                        if (turn == "up")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Left[i, j] = delta.Left[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, 0] = delta.Bottom[i, 0];

                                cube.Bottom[i, 0] = delta.Back[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Back[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Top[i, 0];

                                cube.Top[i, 0] = delta.Front[i, 0];
                            }
                        }
                        else if (turn == "down")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Left[i, j] = delta.Left[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, 0] = delta.Top[i, 0];

                                cube.Top[i, 0] = delta.Back[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Back[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Bottom[i, 0];

                                cube.Bottom[i, 0] = delta.Front[i, 0];
                            }
                        }
                    }
                    else if (layer == "M")
                    {
                        if (turn == "up")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[j, i] = delta.Bottom[j, i];

                                    cube.Bottom[j, i] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                    cube.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Top[j, i];

                                    cube.Top[j, i] = delta.Front[j, i];
                                }
                            }
                        }
                        else if (turn == "down")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[j, i] = delta.Top[j, i];

                                    cube.Top[j, i] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                    cube.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Bottom[j, i];

                                    cube.Bottom[j, i] = delta.Front[j, i];
                                }
                            }
                        }
                    }
                    else if (layer == "R")
                    {
                        if (turn == "up")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Right[i, j] = delta.Right[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, cube.Tiles - 1] = delta.Bottom[i, cube.Tiles - 1];

                                cube.Bottom[i, cube.Tiles - 1] = delta.Back[cube.Tiles - (i + 1), 0];

                                cube.Back[cube.Tiles - (i + 1), 0] = delta.Top[i, cube.Tiles - 1];

                                cube.Top[i, cube.Tiles - 1] = delta.Front[i, cube.Tiles - 1];
                            }
                        }
                        else if (turn == "down")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Right[i, j] = delta.Right[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, cube.Tiles - 1] = delta.Top[i, cube.Tiles - 1];

                                cube.Top[i, cube.Tiles - 1] = delta.Back[cube.Tiles - (i + 1), 0];

                                cube.Back[cube.Tiles - (i + 1), 0] = delta.Bottom[i, cube.Tiles - 1];

                                cube.Bottom[i, cube.Tiles - 1] = delta.Front[i, cube.Tiles - 1];
                            }
                        }
                    }

                    else if (layer == "F")
                    {
                        if (turn == "right")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Front[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[cube.Tiles - 1, i] = delta.Left[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Left[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Bottom[0, cube.Tiles - (i + 1)];

                                cube.Bottom[0, cube.Tiles - (i + 1)] = delta.Right[i, 0];

                                cube.Right[i, 0] = delta.Top[cube.Tiles - 1, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Front[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[cube.Tiles - 1, i] = delta.Right[i, 0];

                                cube.Right[i, 0] = delta.Bottom[0, cube.Tiles - (i + 1)];

                                cube.Bottom[0, cube.Tiles - (i + 1)] = delta.Left[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Left[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Top[cube.Tiles - 1, i];
                            }
                        }
                    }
                    else if (layer == "S")
                    {
                        if (turn == "right")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[cube.Tiles - (i + 1), j] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                    cube.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Bottom[i, cube.Tiles - (j + 1)];

                                    cube.Bottom[i, cube.Tiles - (j + 1)] = delta.Right[j, i];

                                    cube.Right[j, i] = delta.Top[cube.Tiles - (i + 1), j];
                                }
                            }
                        }
                        else if (turn == "left")
                        {
                            for (int i = 1; i < cube.Tiles - 1; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[cube.Tiles - (i + 1), j] = delta.Right[j, i];

                                    cube.Right[j, i] = delta.Bottom[i, cube.Tiles - (j + 1)];

                                    cube.Bottom[i, cube.Tiles - (j + 1)] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                    cube.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Top[cube.Tiles - (i + 1), j];
                                }
                            }
                        }
                    }
                    else if (layer == "B")
                    {
                        if (turn == "right")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Back[i, j] = delta.Back[j, cube.Tiles - (i + 1)];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[0, i] = delta.Left[cube.Tiles - (i + 1), 0];

                                cube.Left[cube.Tiles - (i + 1), 0] = delta.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)];

                                cube.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)] = delta.Right[i, cube.Tiles - 1];

                                cube.Right[i, cube.Tiles - 1] = delta.Top[0, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //face
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Back[i, j] = delta.Back[cube.Tiles - (j + 1), i];
                                }
                            }

                            //side
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[0, i] = delta.Right[i, cube.Tiles - 1];

                                cube.Right[i, cube.Tiles - 1] = delta.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)];

                                cube.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)] = delta.Left[cube.Tiles - (i + 1), 0];

                                cube.Left[cube.Tiles - (i + 1), 0] = delta.Top[0, i];
                            }
                        }
                    }

                    if (layer.Length >= 2)
                    {
                        string[] split;
                        int slice = 0;
                        char lyr = layer[0];

                        if (lyr == 'E')
                        {
                            split = layer.Split('E');
                            slice = Convert.ToInt32(split[1]);
                            if (turn == "right")
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[slice, j] = delta.Left[slice, j];

                                    cube.Left[slice, j] = delta.Back[slice, j];

                                    cube.Back[slice, j] = delta.Right[slice, j];

                                    cube.Right[slice, j] = delta.Front[slice, j];
                                }
                            }
                            else if (turn == "left")
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[slice, j] = delta.Right[slice, j];

                                    cube.Right[slice, j] = delta.Back[slice, j];

                                    cube.Back[slice, j] = delta.Left[slice, j];

                                    cube.Left[slice, j] = delta.Front[slice, j];
                                }
                            }
                        }
                        else if (lyr == 'M')
                        {
                            split = layer.Split('M');
                            slice = Convert.ToInt32(split[1]);
                            if (turn == "up")
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[j, slice] = delta.Bottom[j, slice];

                                    cube.Bottom[j, slice] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)];

                                    cube.Back[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)] = delta.Top[j, slice];

                                    cube.Top[j, slice] = delta.Front[j, slice];
                                }
                            }
                            else if (turn == "down")
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[j, slice] = delta.Top[j, slice];

                                    cube.Top[j, slice] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)];

                                    cube.Back[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)] = delta.Bottom[j, slice];

                                    cube.Bottom[j, slice] = delta.Front[j, slice];
                                }
                            }
                        }
                        else if (lyr == 'S')
                        {
                            if (turn == "right")
                            {
                                split = layer.Split('S');
                                slice = Convert.ToInt32(split[1]);
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[cube.Tiles - (slice + 1), j] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)];

                                    cube.Left[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)] = delta.Bottom[slice, cube.Tiles - (j + 1)];

                                    cube.Bottom[slice, cube.Tiles - (j + 1)] = delta.Right[j, slice];

                                    cube.Right[j, slice] = delta.Top[cube.Tiles - (slice + 1), j];
                                }
                            }
                            else if (turn == "left")
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[cube.Tiles - (slice + 1), j] = delta.Right[j, slice];

                                    cube.Right[j, slice] = delta.Bottom[slice, cube.Tiles - (j + 1)];

                                    cube.Bottom[slice, cube.Tiles - (j + 1)] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)];

                                    cube.Left[cube.Tiles - (j + 1), cube.Tiles - (slice + 1)] = delta.Top[cube.Tiles - (slice + 1), j];
                                }
                            }
                        }
                    }

                    if (layer == "Cube")
                    {
                        if (turn == "up")
                        {
                            //LEFT                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Left[i, j] = delta.Left[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, 0] = delta.Top[i, 0];

                                cube.Top[i, 0] = delta.Back[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Back[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Bottom[i, 0];

                                cube.Bottom[i, 0] = delta.Front[i, 0];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Front[j, i] = delta.Top[j, i];

                                        cube.Top[j, i] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                        cube.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Bottom[j, i];

                                        cube.Bottom[j, i] = delta.Front[j, i];
                                    }
                                }
                            }

                            //RIGHT
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Right[i, j] = delta.Right[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, cube.Tiles - 1] = delta.Top[i, cube.Tiles - 1];

                                cube.Top[i, cube.Tiles - 1] = delta.Back[cube.Tiles - (i + 1), 0];

                                cube.Back[cube.Tiles - (i + 1), 0] = delta.Bottom[i, cube.Tiles - 1];

                                cube.Bottom[i, cube.Tiles - 1] = delta.Front[i, cube.Tiles - 1];
                            }
                        }
                        else if (turn == "down")
                        {
                            //LEFT                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Left[i, j] = delta.Left[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, 0] = delta.Bottom[i, 0];

                                cube.Bottom[i, 0] = delta.Back[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Back[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Top[i, 0];

                                cube.Top[i, 0] = delta.Front[i, 0];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Front[j, i] = delta.Bottom[j, i];

                                        cube.Bottom[j, i] = delta.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                        cube.Back[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Top[j, i];

                                        cube.Top[j, i] = delta.Front[j, i];
                                    }
                                }
                            }

                            //RIGHT                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Right[i, j] = delta.Right[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[i, cube.Tiles - 1] = delta.Bottom[i, cube.Tiles - 1];

                                cube.Bottom[i, cube.Tiles - 1] = delta.Back[cube.Tiles - (i + 1), 0];

                                cube.Back[cube.Tiles - (i + 1), 0] = delta.Top[i, cube.Tiles - 1];

                                cube.Top[i, cube.Tiles - 1] = delta.Front[i, cube.Tiles - 1];
                            }
                        }
                        else if (turn == "right")
                        {
                            //TOP                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[i, j] = delta.Top[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[0, i] = delta.Right[0, i];

                                cube.Right[0, i] = delta.Back[0, i];

                                cube.Back[0, i] = delta.Left[0, i];

                                cube.Left[0, i] = delta.Front[0, i];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Front[i, j] = delta.Right[i, j];

                                        cube.Right[i, j] = delta.Back[i, j];

                                        cube.Back[i, j] = delta.Left[i, j];

                                        cube.Left[i, j] = delta.Front[i, j];
                                    }
                                }
                            }

                            //BOTTOM                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Bottom[i, j] = delta.Bottom[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[cube.Tiles - 1, i] = delta.Right[cube.Tiles - 1, i];

                                cube.Right[cube.Tiles - 1, i] = delta.Back[cube.Tiles - 1, i];

                                cube.Back[cube.Tiles - 1, i] = delta.Left[cube.Tiles - 1, i];

                                cube.Left[cube.Tiles - 1, i] = delta.Front[cube.Tiles - 1, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //TOP
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Top[i, j] = delta.Top[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[0, i] = delta.Left[0, i];

                                cube.Left[0, i] = delta.Back[0, i];

                                cube.Back[0, i] = delta.Right[0, i];

                                cube.Right[0, i] = delta.Front[0, i];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Front[i, j] = delta.Left[i, j];

                                        cube.Left[i, j] = delta.Back[i, j];

                                        cube.Back[i, j] = delta.Right[i, j];

                                        cube.Right[i, j] = delta.Front[i, j];
                                    }
                                }
                            }

                            //BOTTOM                                                      
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Bottom[i, j] = delta.Bottom[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Front[cube.Tiles - 1, i] = delta.Left[cube.Tiles - 1, i];

                                cube.Left[cube.Tiles - 1, i] = delta.Back[cube.Tiles - 1, i];

                                cube.Back[cube.Tiles - 1, i] = delta.Right[cube.Tiles - 1, i];

                                cube.Right[cube.Tiles - 1, i] = delta.Front[cube.Tiles - 1, i];
                            }
                        }
                    }
                    else if (layer == "[Cube]")
                    {
                        if (turn == "right")
                        {
                            //FRONT                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Front[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[cube.Tiles - 1, i] = delta.Left[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Left[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Bottom[0, cube.Tiles - (i + 1)];

                                cube.Bottom[0, cube.Tiles - (i + 1)] = delta.Right[i, 0];

                                cube.Right[i, 0] = delta.Top[cube.Tiles - 1, i];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Top[cube.Tiles - (i + 1), j] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                        cube.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Bottom[i, cube.Tiles - (j + 1)];

                                        cube.Bottom[i, cube.Tiles - (j + 1)] = delta.Right[j, i];

                                        cube.Right[j, i] = delta.Top[cube.Tiles - (i + 1), j];
                                    }
                                }
                            }

                            //BACK                            
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Back[i, j] = delta.Back[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[0, i] = delta.Left[cube.Tiles - (i + 1), 0];

                                cube.Left[cube.Tiles - (i + 1), 0] = delta.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)];

                                cube.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)] = delta.Right[i, cube.Tiles - 1];

                                cube.Right[i, cube.Tiles - 1] = delta.Top[0, i];
                            }
                        }
                        else if (turn == "left")
                        {
                            //FRONT
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Front[i, j] = delta.Front[j, cube.Tiles - (i + 1)];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[cube.Tiles - 1, i] = delta.Right[i, 0];

                                cube.Right[i, 0] = delta.Bottom[0, cube.Tiles - (i + 1)];

                                cube.Bottom[0, cube.Tiles - (i + 1)] = delta.Left[cube.Tiles - (i + 1), cube.Tiles - 1];

                                cube.Left[cube.Tiles - (i + 1), cube.Tiles - 1] = delta.Top[cube.Tiles - 1, i];
                            }

                            //MID
                            if (cube.Tiles > 2)
                            {
                                for (int i = 1; i < cube.Tiles - 1; i++)
                                {
                                    for (int j = 0; j < cube.Tiles; j++)
                                    {
                                        cube.Top[cube.Tiles - (i + 1), j] = delta.Right[j, i];

                                        cube.Right[j, i] = delta.Bottom[i, cube.Tiles - (j + 1)];

                                        cube.Bottom[i, cube.Tiles - (j + 1)] = delta.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)];

                                        cube.Left[cube.Tiles - (j + 1), cube.Tiles - (i + 1)] = delta.Top[cube.Tiles - (i + 1), j];
                                    }
                                }
                            }

                            //BACK
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                for (int j = 0; j < cube.Tiles; j++)
                                {
                                    cube.Back[i, j] = delta.Back[cube.Tiles - (j + 1), i];
                                }
                            }
                            for (int i = 0; i < cube.Tiles; i++)
                            {
                                cube.Top[0, i] = delta.Right[i, cube.Tiles - 1];

                                cube.Right[i, cube.Tiles - 1] = delta.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)];

                                cube.Bottom[cube.Tiles - 1, cube.Tiles - (i + 1)] = delta.Left[cube.Tiles - (i + 1), 0];

                                cube.Left[cube.Tiles - (i + 1), 0] = delta.Top[0, i];
                            }
                        }
                    }
                }
            }
            public static void Scramble(Cube cube)
            {
                string layer = null, turn = null;
                for (int l = 0; l < cube.Tiles * 100; l++)
                {
                    if (cube.Tiles == 2)
                    {
                        var generate = new Random();
                        int random = generate.Next(0, 5);

                        if (random == 0)//U
                        {
                            layer = "U";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 1)//D
                        {
                            layer = "E";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 2)//L
                        {
                            layer = "L";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "up";
                            }
                            else
                            {
                                turn = "down";
                            }
                        }
                        else if (random == 3)//R
                        {
                            layer = "R";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "up";
                            }
                            else
                            {
                                turn = "down";
                            }
                        }
                        else if (random == 4)//F
                        {
                            layer = "F";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 5)//B
                        {
                            layer = "B";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                    }
                    else if (cube.Tiles >= 3)
                    {
                        var generate = new Random();
                        int random = generate.Next(0, 8);

                        if (random == 0)//U
                        {
                            layer = "U";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 1)//E
                        {
                            layer = "E";
                            if (cube.Tiles > 3)
                            {
                                random = generate.Next(1, cube.Tiles - 2);
                                layer = layer + random.ToString();
                            }
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 2)//D
                        {
                            layer = "D";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {

                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 3)//L
                        {
                            layer = "L";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "up";
                            }
                            else
                            {
                                turn = "down";
                            }
                        }
                        else if (random == 4)//M
                        {
                            layer = "M";
                            if (cube.Tiles > 3)
                            {
                                random = generate.Next(1, cube.Tiles - 2);
                                layer = layer + random.ToString();
                            }
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "up";
                            }
                            else
                            {
                                turn = "down";
                            }
                        }
                        else if (random == 5)//R
                        {
                            layer = "R";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "up";
                            }
                            else
                            {
                                turn = "down";
                            }
                        }
                        else if (random == 6)//F
                        {
                            layer = "F";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 7)//S
                        {
                            layer = "S";
                            if (cube.Tiles > 3)
                            {
                                random = generate.Next(1, cube.Tiles - 2);
                                layer = layer + random.ToString();
                            }
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                        else if (random == 8)//B
                        {
                            layer = "B";
                            random = generate.Next(0, 1);
                            if (random == 0)
                            {
                                turn = "right";
                            }
                            else
                            {
                                turn = "left";
                            }
                        }
                    }
                    Turn(cube, layer, turn);
                }
            }
        }
        static void Main(string[] args)
        {
            while (Console.WindowHeight != Console.LargestWindowHeight)
            {
                Console.Clear();                    
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("You can press ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ALT ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("+ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("to put the app on ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Full-Screen mode");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }

            bool esc = false;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Escape || esc)
            {
                esc = false;
                Menu();
                key = Console.ReadKey();
                Check();
                if (key.Key == ConsoleKey.S)
                {
                    string temp = null;
                    bool ask = true;
                    while(ask)
                    {
                        ask = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only 1 dimension has to be entered, like: \"3\" for a 3x3, and cubes larger than 23x23 are either disorienting, or completely broken");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Please enter your cube's size: ");
                        temp = Console.ReadLine();
                        if (temp == "")
                        {
                            ask = true;
                        }
                        else
                        {
                            for (int i = 0; i < temp.Length; i++)
                            {
                                if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' && temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9')
                                {
                                    ask = true;
                                }
                            }
                        }
                        Check();
                    }
                    int num = Convert.ToInt32(temp);
                    Console.Clear();
                    Cube cube = new Cube();
                    Cube.Generate(ref cube, num);
                    
                    string layer = " ";
                    string turn;
                    while (key.Key != ConsoleKey.Escape)
                    {
                        Check();
                        turn = null;

                        Cube.Draw(cube);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Selected layer: " + layer);

                        key = Console.ReadKey();
                        Set(cube, key, ref layer, ref turn);
                        Cube.Turn(cube, layer, turn);
                    }
                    esc = true;
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Check();
                    Guide();
                }               
            }
            Console.Clear();
        }

        public static void Check()
        {
            while (Console.WindowHeight != Console.LargestWindowHeight)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("You can press ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ALT ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("+ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("to put the app on ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Full-Screen mode");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
        }

        public static void Set(Cube cube, ConsoleKeyInfo key, ref string layer, ref string turn)
        {
            //layer
            if (key.Key == ConsoleKey.U)
            {
                layer = "U";
            }
            else if (key.Key == ConsoleKey.D)
            {
                layer = "D";
            }

            else if (key.Key == ConsoleKey.L)
            {
                layer = "L";
            }
            else if (key.Key == ConsoleKey.R)
            {
                layer = "R";
            }

            else if (key.Key == ConsoleKey.F)
            {
                layer = "F";
            }
            else if (key.Key == ConsoleKey.B)
            {
                layer = "B";
            }

            else if (key.Key == ConsoleKey.C)
            {
                layer = "Cube";
            }
            else if (key.Key == ConsoleKey.Spacebar)
            {
                layer = "[Cube]";
            }

            else if (cube.Tiles >= 3)
            {
                if (key.Key == ConsoleKey.E)
                {
                    layer = "E";
                }
                else if (key.Key == ConsoleKey.M)
                {
                    layer = "M";
                }
                else if (key.Key == ConsoleKey.S)
                {
                    layer = "S";
                }

                if (cube.Tiles > 3)
                {
                    if (layer[0] == 'E')
                    {
                        if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.D0)
                        {
                            string num = key.Key.ToString();
                            string[] split = num.Split('D');
                            int slice = Convert.ToInt32(split[1]);

                            string s = layer + slice.ToString();
                            split = s.Split('E');
                            int overload = Convert.ToInt32(split[1]);
                            if ((layer.Length == 1 || overload > cube.Tiles - 2) && key.Key == ConsoleKey.D0)
                            {

                            }
                            else if (slice < cube.Tiles - 1)
                            {

                                layer = layer + slice.ToString();
                                split = layer.Split('E');
                                overload = Convert.ToInt32(split[1]);
                                if (overload > cube.Tiles - 2)
                                {
                                    layer = "E" + slice.ToString();
                                }
                            }
                        }
                    }
                    else if (layer[0] == 'M')
                    {
                        if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.D0)
                        {
                            string num = key.Key.ToString();
                            string[] split = num.Split('D');
                            int slice = Convert.ToInt32(split[1]);

                            string s = layer + slice.ToString();
                            split = s.Split('M');
                            int overload = Convert.ToInt32(split[1]);
                            if ((layer.Length == 1 || overload > cube.Tiles - 2) && key.Key == ConsoleKey.D0)
                            {

                            }
                            else if (slice < cube.Tiles - 1)
                            {

                                layer = layer + slice.ToString();
                                split = layer.Split('M');
                                overload = Convert.ToInt32(split[1]);
                                if (overload > cube.Tiles - 2)
                                {
                                    layer = "M" + slice.ToString();
                                }
                            }
                        }
                    }
                    else if (layer[0] == 'S')
                    {
                        if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.D0)
                        {
                            string num = key.Key.ToString();
                            string[] split = num.Split('D');
                            int slice = Convert.ToInt32(split[1]);

                            string s = layer + slice.ToString();
                            split = s.Split('S');
                            int overload = Convert.ToInt32(split[1]);
                            if ((layer.Length == 1 || overload > cube.Tiles - 2) && key.Key == ConsoleKey.D0)
                            {

                            }
                            else if (slice < cube.Tiles - 1)
                            {

                                layer = layer + slice.ToString();
                                split = layer.Split('S');
                                overload = Convert.ToInt32(split[1]);
                                if (overload > cube.Tiles - 2)
                                {
                                    layer = "S" + slice.ToString();
                                }
                            }
                        }
                    }
                }
            }

            //turn
            if (key.Key == ConsoleKey.RightArrow)
            {
                turn = "right";
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                turn = "left";
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                turn = "up";
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                turn = "down";
            }

            //scramble
            if (key.Key == ConsoleKey.F1)
            {
                Cube.Scramble(cube);
            }
        }

        public static void Menu()
        {
            static void Color()
            {
                var generate = new Random();
                int random = generate.Next(0, 5);
                if (random == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (random == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (random == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (random == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (random == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (random == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }


            Console.Clear();
            Console.WriteLine("a");
            Console.Clear();
            Console.WriteLine();
            Console.Write("  ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  ");
            Color();
            Console.Write("██  ");
            Console.Write("    ");
            Color();
            Console.Write("██    ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  "); 
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  "); 
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("  ");
            Color();
            Console.Write("██            ");
            Color();
            Console.Write("██      ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██    ");
            }
            Console.Write("  ");
            for (int i = 0; i < 2; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("      ");
            for (int i = 0; i < 2; i++)
            {
                Color();
                Console.Write("██    ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("  ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  ");
            for (int i = 0; i < 3; i++)
            {
                Color();
                Console.Write("██  ");
            }
            Console.Write("  ");
            for (int i = 0; i < 2; i++)
            {
                Color();
                Console.Write("██      ");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Cube showoff = new Cube();
            Cube.Generate(ref showoff, 3);
            Cube.Scramble(showoff);
            showoff.forUse = false;
            Cube.Draw(showoff);

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("  Start - S");
            Console.WriteLine("  Guide - G");
            Console.WriteLine("  Exit - Esc");
        }

        public static void Guide()
        {
            Console.Clear();
            Cube lol = new Cube();
            Cube.Generate(ref lol,4);
            ConsoleKeyInfo show = new ConsoleKeyInfo();
            string layer = " ";
            string turn = null; // unused
            while (show.Key != ConsoleKey.Escape)
            {
                Console.Clear();

                //1
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("     ___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "B" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write(" ___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "B" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write(" ___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write(" ___");                
                Console.WriteLine();

                //2
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("    /");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "S" || layer == "B" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "M" || layer == "B" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "B" || layer == "M1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "B" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "B" || layer == "M2" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "B" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "B" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/|");
                Console.WriteLine();

                //3
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "S" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("   /");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "S" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "M" || layer == "S" || layer == "M1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "M1" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "M1" || layer == "M2" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "M2" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "S" || layer == "M2" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "S2" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //4
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("  /");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "F" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "M" || layer == "S" || layer == "M1" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "S" || layer == "M1" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "S" || layer == "M1" || layer == "M2" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "S" || layer == "M2" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "S" || layer == "M2" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "F" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "S" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "R" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "B" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //5
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write(" /___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("__ /");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "F" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "R" || layer == "S" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "B" || layer == "E1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "B" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //6
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L"  || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "R" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "E1" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "B" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //7
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "L" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "L" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "F" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "M" || layer == "R" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "R" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "U" || layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "S" || layer == "E1" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "B" || layer == "E2" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "B" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //8
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "M" || layer == "F" || layer == "E1" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "R" || layer == "F" || layer == "E1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "E2" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "R" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //9
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "F" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "M" || layer == "F" || layer == "E1" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "E2" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E1" || layer == "E2" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "R" || layer == "F" || layer == "E1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E1" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "S" || layer == "F" || layer == "E2" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "R" || layer == "S" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "S" || layer == "B" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "B" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.WriteLine();

                //10
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "M" || layer == "F" || layer == "E2" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E2" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "R" || layer == "F" || layer == "E2" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "R" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "S" || layer == "S1" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "S" || layer == "S2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.WriteLine();

                //11
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "L" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "L" || layer == "M" || layer == "F" || layer == "E2" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "M" || layer == "F" || layer == "E2" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "F" || layer == "E2" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "M" || layer == "F" || layer == "E2" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "M" || layer == "R" || layer == "F" || layer == "E2" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "R" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "R" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E" || layer == "D" || layer == "R" || layer == "F" || layer == "E2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "S" || layer == "F" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "S" || layer == "S1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                Console.WriteLine();

                //12
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "L" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "L" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "F" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "R" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("| /");
                Console.WriteLine();

                //13
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "L" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "L" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "F" || layer == "M1" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "F" || layer == "M1" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "M" || layer == "R" || layer == "F" || layer == "M2" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D" || layer == "R" || layer == "F" || layer == "Cube" || layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("___|/");
                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Layers: ");
                if (layer == "U")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("U");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("U");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The U layer/ -LeftArrow to turn left, RightArrow to turn right");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("E");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("E");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The whole E layer/ -LeftArrow to turn left, RightArrow to turn right");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E1")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("E1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("E,1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The first E layer/  -LeftArrow to turn left, RightArrow to turn right");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "E2")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("E2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("E,2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The second E layer/  -LeftArrow to turn left, RightArrow to turn right");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "D")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("D");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("D");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The D layer/  -LeftArrow to turn left, RightArrow to turn right");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "L")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("L");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("L");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The L layer/ -UpArrow to turn upwards, DownArrow to turn downwards");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "M")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("M");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("M");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The whole M layer/ -UpArrow to turn upwards, DownArrow to turn downwards");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "M1")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("M1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("M,1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The first M layer/ -UpArrow to turn upwards, DownArrow to turn downwards");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "M2")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("M2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("M,2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The second M layer/ -UpArrow to turn upwards, DownArrow to turn downwards");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "R")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }       
                Console.Write("R");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("R");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The R layer/ -UpArrow to turn upwards, DownArrow to turn downwards");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "F")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("F");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("F");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The F layer/ -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "S")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("S");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("S");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The whole S layer/ -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "S1")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("S1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("S,1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The first S layer/ -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");
                if (layer == "S2")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("S2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("S,2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]  /The second S layer/ -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "B")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("B");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("B");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /The B layer/ -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "Cube")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("Cube");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("    - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("C");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]           /Turns the whole cube/ -UpArrow to turn to the top side, DownArrow to turn to the bottom side,");
                Console.WriteLine("                                                LeftArrow to turn to the left side, RightArrow to turn to the right side");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (layer == "[Cube]")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("[Cube]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  - [");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Spacebar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("]    /Rotates the whole cube/  -RightArrow to turn clockwise, LeftArrow to turn counterclockwise");

                Console.WriteLine();
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("F1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("] /Scrambles a cube/");
                show = Console.ReadKey();
                Set(lol, show, ref layer, ref turn);
            }
        }
    }
}

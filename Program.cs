﻿using System;
using OpenTK.Windowing.Desktop;

namespace CG_II_OpenGL
{
    class Program
  {
    static void Main(string[] args)
    {
      string HelloMsg = "Choose one of the following OpenGL programs:\n"+
      "1 - Opening a cube\n"+
      "2 - Cube Array\n"+
      "3 - Falling cubes\n"+
      "4 - f(x,y)";
      Console.WriteLine(HelloMsg);
      choose:
      var option = Console.ReadKey(true).KeyChar;
      GameWindow app;
      switch(option)
      {
        case '1':
          app = new WindowCubeUnwrap();
          break;
        case '2':
          app = new WindowCubeArray();
          break;
        case '3':
          app = new WindowBlocks();
          break;
        case '4':
          Console.WriteLine("Type equation you want to solve for");
          string equation = Console.ReadLine();
          app = new WindowFxy(equation);
          break;
        default:
          Console.WriteLine("Choose different key");
          goto choose;
      }
      try
      {
        app.Run();
      }
      catch(Exception ex)
      {
        Console.WriteLine("Exiting gracefully...");
      }
    }
  }
}

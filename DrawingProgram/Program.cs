﻿using System;


namespace DrawingProgram
{
  partial class Program
  {
    static void Main(string[] args)
    {
      IShape s = new Square(new CartPt(30, 40), 40);

      Console.WriteLine("Hello World!");
    }
  }

  }


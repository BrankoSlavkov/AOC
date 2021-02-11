﻿using AOC.Common;
using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputs = new List<string>();

            inputs.GetInputs();

            PasswordPhilosophy passwordPhilosophy = new PasswordPhilosophy(inputs);

            Console.WriteLine(passwordPhilosophy.TotalValidPasswords);
            Console.WriteLine(passwordPhilosophy.TotalValidPasswordsPart2);

        }
    }
}

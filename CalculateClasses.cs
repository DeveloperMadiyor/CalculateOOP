using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculateClasses
{
    class Objects
    {
        public string Input;
        public string Output;
        public int FirstSum;
        public string Element;
        public string Operations {  get; set; }
        public string[] Spl { get; set; }
        public List<string>Mean { get; set; } = new List<string>();

        public void ShowInput()
        {
            Console.Write("Введите пример: ");
            Input = Console.ReadLine();
            Output = Input.Replace(" ", "");
            Spl = Regex.Split(Output, @"([+\-*/])");
            FirstSum = int.Parse(Spl[0]);

            foreach (string spl in Spl) 
            {
                Mean.Add(spl);
            }
        }

        public void ShowOperation()
        {
            for (int i = 1; i < Spl.Length; i++) 
            {
                if (Spl[i] == "+" || Spl[i] == "-" || Spl[i] == "*" || Spl[i] == "/") 
                {
                    Element = Spl[i];
                }
                else
                {
                    int num = int.Parse(Spl[i]);
                    if (Element == "+") FirstSum += num;
                    else if(Element == "-") FirstSum -= num;
                    else if(Element == "*") FirstSum *= num;
                    else if(Element == "/") FirstSum /= num;
                }
            }
            Console.WriteLine(FirstSum);
        }
    }
}

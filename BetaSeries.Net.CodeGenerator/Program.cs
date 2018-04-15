using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaSeries.Net.CodeGenerator
{
    static class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> classes = new Dictionary<string, List<string>>();
            string[] inputs = File.ReadAllLines("inputs/methods");

            foreach (string input in inputs)
            {
                string[] parts = input.Split('/');

                if (classes.ContainsKey(parts[0]))
                {
                    if (!classes[parts[0]].Contains(parts[1]))
                    {
                        classes[parts[0]].Add(parts[1]);
                    }
                }
                else
                {
                    classes.Add(parts[0], new List<string>() { parts[1] });
                }
            }


            foreach (KeyValuePair<string, List<string>> pairs in classes)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("using BetaSeries.Net.Core;");
                sb.AppendLine("using System.Dynamic;");
                sb.AppendLine("\n");

                sb.AppendLine("namespace BetaSeries.Net.Models");
                sb.AppendLine("{");

                sb.AppendLine($"\tpublic class {pairs.Key.ToPascalCase()}");
                sb.AppendLine("\t{");

                foreach (string sub in pairs.Value)
                {
                    sb.AppendLine("\n");
                    sb.AppendLine("\t\t[Rest]");
                    sb.AppendLine($"\t\tpublic class {sub.ToPascalCase()} : DynamicObject {{}}");
                }

                sb.AppendLine("\t}");
                sb.AppendLine("}");

                File.WriteAllText($"inputs/{pairs.Key.ToPascalCase()}.cs", sb.ToString());
            }

        }

        private static string ToPascalCase(this string input)
        {
            return input.Substring(0, 1).ToUpper() + input.Substring(1);
        }
    }
}

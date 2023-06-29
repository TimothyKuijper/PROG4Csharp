using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines) 
            {
                string[] typesplit = line.Split("|");
                string[] consoleMonData = typesplit[0].Split(",");

                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.energy = int.Parse(consoleMonData[2]);
                dataMon.health = int.Parse(consoleMonData[4]);

                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.energy);
                Console.WriteLine(dataMon.health);
            }

        }

        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            //Console.WriteLine(json);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            //Console.WriteLine(templates[0].name);
            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element);

            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom) 
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.element);
            copyResult.skills = new List<Skill>();
            foreach (Skill skill in copyFrom.skills)
            {
                Skill copyOfSkill = CopySkill(skill);
                copyResult.skills.Add(copyOfSkill);
            }

            return copyResult;
        }
    }
}

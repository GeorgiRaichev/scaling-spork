using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Controller
{
    List<Village> village = new List<Village>();
    List<Rebel> rebels = new List<Rebel>();
    public int totalAttacksPerformed = 0;

    public string ProcessVillageCommand(List<string> args)
    {
        Village a = new Village(args[0], args[1]);
        this.village.Add(a);
        return $"Created Village {args[0]}!";

    }

    public string ProcessSettleCommand(List<string> args)
    {
        string name = args[0];
        int age = int.Parse((args[1]));
        int productivity = int.Parse((args[2]));
        string villageName = args[3];
        Peasant peasant = new Peasant(name, age, productivity);
        for (int i = 0; i < this.village.Count; i++)
        {
            if (this.village[i].Name == villageName)
            {
                village[i].AddPeasant(peasant);
            }
        }
        return $"Settled Peasant {peasant.Name} in Village {villageName}!";
    }

    public string ProcessRebelCommand(List<string> args)
    {
        string name = args[0];
        int age = int.Parse(args[1]);
        int harm = int.Parse(args[2]);
        Rebel rebel = new Rebel(name, age, harm);
        rebels.Add(rebel);
        return $"Rebel {name} joined the gang!";
    }

    public string ProcessDayCommand(List<string> args)
    {
        int dailyResource = 0;
        string villageName = args[0];
        for (int i = 0; i < this.village.Count; i++)
        {
            if (this.village[i].Name == villageName)
            {
                this.village[i].Resource += this.village[i].PassDay();
                dailyResource = this.village[i].Resource;
            }
        }
        return $"Village {villageName} resource increased with {dailyResource}!";
    }

    public string ProcessAttackCommand(List<string> args)
    {
        int N = int.Parse(args[0]);
        if (this.rebels.Count != 0)
        {
            int takenResource = 0;
            string villageName = args[1];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += rebels[i].Harm;
            }
            for (int i = 0; i < this.village.Count; i++)
            {
                if (this.village[i].Name == villageName)
                {
                    if (this.village[i].Resource < sum)
                    {
                        this.village[i].Resource = 0;

                    }
                    else
                    {
                        this.village[i].Resource -= sum;
                        takenResource = sum;

                    }
                    this.village[i].KillPeasants(N / 2);
                    break;
                }
                this.totalAttacksPerformed++;
            }

            return $"Village {villageName} lost {takenResource} resources and {N / 2} peasants!";
        }
        else
        {
            return $"No rebels to perform raid...";
        }
    }
    public string ProcessInfoCommand(List<string> args)
    {
        string side = args[0];
        string show = "";
        if (side == "Rebel")
        {
            if (rebels.Count > 0)
            {
                foreach (var rebel in rebels)
                {
                    show += rebel.ToString() + "\n";
                }
            }
            else
            {
                show = "No Rebels";
            }

        }
        else if (side == "Village")
        {
            if (village.Count > 0)
            {
                foreach (var village in village)
                {
                    show += village.ToString() + "\n";
                }
            }
            else
            {
                show = "No Villages";
            }

        }
        return show;
    }

    public string ProcessEndCommand()
    {
        string show = $"Villages: {this.village.Count}\nRebels: {this.rebels.Count}\nAttacks on Villages: {this.totalAttacksPerformed}";
        return show;
    }

}


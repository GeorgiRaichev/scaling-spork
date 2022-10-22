using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Village
{
    public string name;
    public string location;
    public int resource;
    public List<Peasant> peasants = new List<Peasant>();
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }

    }
    public string Location
    {
        get { return location; }
        set
        {
            if (value.Length < 3 || value.Length > 45)
            {
                throw new ArgumentException("Location should be between 3 and 45 characters!");
            }
            location = value;
        }

    }
    public int Resource
    {
        get { return this.resource; }
        set
        {
            resource = value;
        }

    }
    public Village(string name, string location)
    {
        this.Name = name;
        this.Location = location;

    }
    public void AddPeasant(Peasant peasant)
    {
        peasants.Add(peasant);
    }
    public int PassDay()
    {
        int sum = 0;
        foreach (var productivity in this.peasants)
        {
            sum += productivity.productivity;
        }
        resource = sum;
        return resource;
    }
    public List<Peasant> KillPeasants(int count)
    {
        List<Peasant> deadPeasants = new List<Peasant>();
        for (int i = 0; i < count; i++)
        {
            deadPeasants.Add(this.peasants[i]);
            this.peasants.Remove(this.peasants[i]);

        }
        return deadPeasants;
    }
    public override string ToString()
    {
        string show = $"Village - {this.Name} ({this.Location})\n Resources - {this.PassDay()}\n Peasants – ({this.peasants.Count})\n";
        for (int i = 0; i < this.peasants.Count; i++)
        {
            show += this.peasants[i].ToString() + "\n";
        }
        return show;
    }
}


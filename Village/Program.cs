using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static Controller controller = new Controller();
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            List<string> list = input.Split(' ').ToList();
            if (list[0] == "Village")
            {
                Console.WriteLine(Village(list.Skip(1).ToList()));
            }
            else if (list[0] == "Settle")
            {
                Console.WriteLine(Settle(list.Skip(1).ToList()));
            }
            else if (list[0] == "Rebel")
            {
                Console.WriteLine(Rebel(list.Skip(1).ToList()));
            }
            else if (list[0] == "Day")
            {
                Console.WriteLine(Day(list.Skip(1).ToList()));
            }
            else if (list[0] == "Attack")
            {
                Console.WriteLine(Attack(list.Skip(1).ToList()));
            }
            else if (list[0] == "Info")
            {
                Console.WriteLine(Info(list.Skip(1).ToList()));
            }            
            input = Console.ReadLine();
        }
        Console.WriteLine(controller.ProcessEndCommand());
    }
    static string Village(List<string> args)
    {
        try
        {

            return controller.ProcessVillageCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    static string Settle(List<string> args)
    {
        try
        {

            return controller.ProcessSettleCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    static string Rebel(List<string> args)
    {
        try
        {

            return controller.ProcessRebelCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    static string Day(List<string> args)
    {
        try
        {

            return controller.ProcessDayCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    static string Attack(List<string> args)
    {
        try
        {

            return controller.ProcessAttackCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    static string Info(List<string> args)
    {
        try
        {

            return controller.ProcessInfoCommand(args);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

}

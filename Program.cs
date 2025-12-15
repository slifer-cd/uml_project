using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using FH;
using DataImplementation;
class Controller
{
    // start, admin, cardholder_login, student_menu, faculty_menu, issue_card, block_card,unblock_card, admin_data_view, 
    private string position;
    private int position_step = 0;
    private string input_buffer = "";
    public Controller()
    {
        this.position = "start";
    }
    public string next(string input)
    {
        return Model.GetData(this.position);
    }
}
class Model
{
    public static string lastOutputData = "";
    public static readonly string clearConsole = "\x1b[2J\x1b[H";

    public static string GetData(string position)
    {
        if (position == "start")
        {
            lastOutputData = mainScreen;
            return clearConsole + mainScreen;
        }
        return "";
    }
    private static string mainScreen = "[1] Login As Admin\n[2] Login As Card Holder\n[3] Exit\n\nEnter your choice: ";
}
class View
{
    public static void Main()
    {
        Controller controller = new Controller();
        Console.Write(controller.next(""));
    }
}
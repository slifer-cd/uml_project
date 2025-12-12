using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using FH;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
class Student { }
class Faculty { }
class Card {
    public string UserID { get; set; }
    public bool active { get; set; }
    public void swap()
    {
        active = !active;
    }
}
class Transaction { }
class Controller { }
class Model { }
class View
{
    public static void Main()
    {
        FileHandler fh = new FileHandler("students.json", "faculties.json", "cards.json", "transactions.json");
        Card c1 = new Card() { UserID = "C123", active = true };
        fh.Write(c1);
        c1.swap();
        fh.Update(c1);
    }
}
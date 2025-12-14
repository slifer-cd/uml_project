using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using FH;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
class Student { }
class Faculty { }
class Card
{
    public string UserID { get; set; }
    public bool active { get; set; }
    public void swap()
    {
        active = !active;
    }
}
class Transaction { }

class LectureAttendance
{
    private int day, mounth, year;
    private string courseID;
    private List<string> students = new List<string>();
    public LectureAttendance(int day, int mounth, int year, string courseID)
    {
        this.day = day;
        this.mounth = mounth;
        this.year = year;
        this.courseID = courseID;
    }
    public override int GetHashCode()
    {
        string m = mounth < 10 ? $"0{mounth}" : mounth.ToString();
        string date = $"{day}{m}{year}";
        int hash = Convert.ToInt32(date);
        foreach (char c in courseID)
        {
            hash += (int)c;
        }
        return hash;
    }
    public static bool operator ==(LectureAttendance la1, LectureAttendance la2)
    {
        return la1.GetHashCode() == la2.GetHashCode();
    }
    public static bool operator !=(LectureAttendance la1, LectureAttendance la2)
    {
        return la1.GetHashCode() == la2.GetHashCode();
    }
    public void addStudent(string studentID)
    {
        students.Add(studentID);
    }
    public void removeStudent(string studentID) {
        students.Remove(studentID);
    }
}
class Controller { }
class Model { }
class View
{
    const string clearConsole = "\x1b[2J\x1b[H";
    public static void Main()
    {
        FileHandler fh = new FileHandler("students.json", "faculties.json", "cards.json", "transactions.json", "attendance.json");

    }
}
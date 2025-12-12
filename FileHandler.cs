using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace FH
{
    class FileHandler
    {
        private string stfname;
        private string fafname;
        private string cafname;
        private string trfname;
        private string atfname;
        public FileHandler(string stfname, string fafname, string cafname, string trfname, string atfname)
        {
            this.stfname = stfname;
            this.fafname = fafname;
            this.cafname = cafname;
            this.trfname = trfname;
            this.atfname = atfname;
            if (File.Exists(stfname) == false)
            {
                File.Create(stfname).Close();
            }
            if (File.Exists(fafname) == false)
            {
                File.Create(fafname).Close();
            }
            if (File.Exists(trfname) == false)
            {
                File.Create(trfname).Close();
            }
            if (File.Exists(cafname) == false)
            {
                File.Create(cafname).Close();
            }
        }
        //stundet Write
        public bool Write(Student obj)
        {
            try
            {
                List<Student> students;
                Read(out students);
                students.Add(obj);
                FileStream fs = new FileStream(stfname, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, students);

                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //stundet Read
        public bool Read(out List<Student> students)
        {

            FileStream fs = new FileStream(stfname, FileMode.OpenOrCreate, FileAccess.Read);
            bool st = true;
            try
            {
                students = JsonSerializer.Deserialize<List<Student>>(fs) ?? new List<Student>();
            }
            catch
            {
                students = new List<Student>();
                st = false;
            }
            finally
            {
                fs.Close();
            }
            return st;
        }
        //faculty Write
        public bool Write(Faculty obj)
        {
            try
            {
                List<Faculty> faculties;
                Read(out faculties);
                faculties.Add(obj);
                FileStream fs = new FileStream(fafname, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, faculties);

                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //faculty Read
        public bool Read(out List<Faculty> faculties)
        {

            FileStream fs = new FileStream(fafname, FileMode.OpenOrCreate, FileAccess.Read);
            bool st = true;
            try
            {
                faculties = JsonSerializer.Deserialize<List<Faculty>>(fs) ?? new List<Faculty>();
            }
            catch
            {
                faculties = new List<Faculty>();
                st = false;
            }
            finally
            {
                fs.Close();
            }
            return st;
        }
        //Card Write    
        public bool Write(Card obj)
        {
            try
            {
                List<Card> cards;
                Read(out cards);
                cards.Add(obj);
                FileStream fs = new FileStream(cafname, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, cards);

                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //Card Read
        public bool Read(out List<Card> cards)
        {

            FileStream fs = new FileStream(cafname, FileMode.OpenOrCreate, FileAccess.Read);
            bool st = true;
            try
            {
                cards = JsonSerializer.Deserialize<List<Card>>(fs) ?? new List<Card>();
            }
            catch
            {
                cards = new List<Card>();
                st = false;
            }
            finally
            {
                fs.Close();
            }
            return st;
        }
        //Transaction Write    
        public bool Write(Transaction obj)
        {
            try
            {
                List<Transaction> transactions;
                Read(out transactions);
                transactions.Add(obj);
                FileStream fs = new FileStream(trfname, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, transactions);

                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //Transaction Read
        public bool Read(out List<Transaction> transactions)
        {

            FileStream fs = new FileStream(trfname, FileMode.OpenOrCreate, FileAccess.Read);
            bool st = true;
            try
            {
                transactions = JsonSerializer.Deserialize<List<Transaction>>(fs) ?? new List<Transaction>();
            }
            catch
            {
                transactions = new List<Transaction>();
                st = false;
            }
            finally
            {
                fs.Close();
            }
            return st;
        }
        // Card Update
        public bool Update(Card obj)
        {
            try
            {
                List<Card> cards;
                Read(out cards);
                cards.RemoveAll(c => c.UserID == obj.UserID);
                cards.Add(obj);
                FileStream fs = new FileStream(cafname, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, cards);

                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

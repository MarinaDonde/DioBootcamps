using System;

namespace CadastroDeSerie
{
    public class Serie : BasicEntity
    {
        private Gender Gender {get; set; }
        private string Title {get; set; }

        private string Description {get; set; }

        private int Year {get; set; }

        private bool Deleted {get; set; }

        public Serie(int id, Gender gender, string title, string description, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString()
        {
            string returning = "";
            returning += "Gender: " + this.Gender + Environment.NewLine;
            returning += "Title: " + this.Title + Environment.NewLine;
            returning += "Description: " + this.Description + Environment.NewLine;
            returning += "Year: " + this.Year;
            returning += "Deleted: " + this.Deleted;
            return returning;
        }

        public string returningTitle()
        {
            return this.Title;
        }

        public int returningId()
        {
            return this.Id;
        }

        public bool returningDeleted()
        {
            return this.Deleted;
        }

        public void Deleting()
        {
            this.Deleted = true;
        }
    }
}
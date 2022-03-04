namespace TibiaRPG.src.Entities
{
    public abstract class Vocation
    {
         public Vocation(string name, int level, int hpCurrent, int hpMax, string vocationType)

        {
            this.Name = name;
            this.Level = level;
            this.HpMax = hpMax;
            this.HpCurrent = hpCurrent;
            this.VocationType = vocationType;
        }
        public Vocation()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int HpMax { get; set; }
        public int HpCurrent { get; set; }
        public string VocationType { get; set; }



        public override string ToString()
        {
            return "VocationType: " + this.VocationType + "\n" + "Name: " + this.Name +
             "\n" + "HP: " + this.HpCurrent + "/" + this.HpMax + "\n" + "Level: " + this.Level;

        }
        public virtual string Attack()
        {
            return this.Name + " Attack done!";
        }
        public virtual string Defense()
        {
            return this.Name + " Defense done!";
        }
    }
}
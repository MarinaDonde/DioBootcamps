namespace TibiaRPG.src.Entities
{
    public class Druid : Vocation
    {
            public Druid(string name, int level, int hpCurrent, int hpMax, string vocationType)
         
        {
            this.Name = name;
            this.Level = level;
            this.HpMax = hpMax;
            this.HpCurrent = hpCurrent;
            this.VocationType = vocationType;
        }
        public override string Attack()
        {
            return this.Name + " Attack with rod";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Great Attack! Bonus: " + Bonus;
            }
            else
            {
                return this.Name + ": Good Attack! Bonus: " + Bonus;
            }

        }
        public override string Defense()
        {
            return this.Name + ": Defense with shield";
        }
        public string Defense(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Great Defense! Bonus:" + Bonus;
            }
            else
            {
                return this.Name + ": Good Defense! Bonus: " + Bonus;
            }

        } 
    }
}


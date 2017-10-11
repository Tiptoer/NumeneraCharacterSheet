using System;
using System.Collections.Generic;



namespace NumeneraCharacterSheet
{
    class Character
    {
        public List<Skills> skillList;
        public Attribute Geschicklichkeit;
        public Attribute Kraft;
        public Attribute Intellekt;

        public int Rang { get; set; }
        public int Anstrengung { get; set; }
        public int EP { get; set; }
        public int Erholung { get; set; }
        public int Schaden { get; set; }
        public int Ruestung { get; set; }


        public string Hintergrund { get; set; }
        public string Notizen { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public string Archetype { get; set; }
        public string Fokus { get; set; }


        private List<string> chyperList;
        private List<string> sonderfertigkeitSkillList;

        public List<string> ChyperList { get => chyperList; set => chyperList = value; }
        public List<string> SonderfertigkeitSkillList { get => sonderfertigkeitSkillList; set => sonderfertigkeitSkillList = value; }

        public Character()
        {
            skillList = new List<Skills>();
            Geschicklichkeit = new Attribute();
            Kraft = new Attribute();
            Intellekt = new Attribute();
        }

        public void AddSkill(String Name)
        {
            Skills skill = new Skills();
            skill.Name = Name;
            skillList.Add(skill);
        }

        public void ChangeTrainedState(String Name)
        {
            foreach (Skills skill in skillList)
            {
                if (skill.Name.Equals(Name))
                {
                    skill.Trained = !skill.Trained;
                    if (skill.Trained == false)
                    {
                        skill.Expert = false;
                    }
                }
            }
        }

        public void ChangeExpertState(String Name)
        {
            foreach (Skills skill in skillList)
            {
                if (skill.Name.Equals(Name))
                {
                    skill.Trained = true;
                    skill.Expert = !skill.Expert;

                    if (skill.Expert == true)
                    {
                        skill.Trained = true;
                    }
                }
            }
        }
    }
}

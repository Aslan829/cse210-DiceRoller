using System;
using System.Collections.Generic;
using System.Text.Json;

namespace cse210_DiceRoller
{
    public class Character
    {
        public string name = "Pierce";
        // private string characterData = "";
        public List<Skill> SkillsList = new List<Skill>();
        public List<Attack> AttackList = new List<Attack>();


        //Add skills to skill list and attacks to attack lists.
        public void getSkillsList(){
            Skill acrobatics = new Skill();
            acrobatics.setValues("Acrobatics",5);
            SkillsList.Add(acrobatics);

            Skill animalHandling = new Skill();
            animalHandling.setValues("Animal Handling",0);
            SkillsList.Add(animalHandling);

            Skill arcana = new Skill();
            arcana.setValues("Arcana",1);
            SkillsList.Add(arcana);

            Skill athletics = new Skill();
            athletics.setValues("Athletics",5);
            SkillsList.Add(athletics);

            Skill deception = new Skill();
            deception.setValues("Deception",-1);
            SkillsList.Add(deception);

            Skill history = new Skill();
            history.setValues("History",4);
            SkillsList.Add(history);

            Skill insight = new Skill();
            insight.setValues("Insight",0);
            SkillsList.Add(insight);

            Skill intimidation = new Skill();
            intimidation.setValues("Intimidation",-1);
            SkillsList.Add(intimidation);

            Skill investigation = new Skill();
            investigation.setValues("Investigation",4);
            SkillsList.Add(investigation);

            Skill medicine = new Skill();
            medicine.setValues("Medicine",0);
            SkillsList.Add(medicine);

            Skill nature = new Skill();
            nature.setValues("Nature", 1);
            SkillsList.Add(nature);

            Skill perception = new Skill();
            perception.setValues("Perception",0);
            SkillsList.Add(perception);

            Skill religion = new Skill();
            religion.setValues("Religion",1);
            SkillsList.Add(religion);

            Skill sleightOfHand = new Skill();
            sleightOfHand.setValues("Sleight Of Hand",2);
            SkillsList.Add(sleightOfHand);

            Skill stealth = new Skill();
            stealth.setValues("Stealth",2);
            SkillsList.Add(stealth);

            Skill survival = new Skill();
            survival.setValues("Survival",0);
            SkillsList.Add(survival);

        }

        //Update attack list
        //string traitName, int modifier, int damageDiceSize, int damageModifier
        public void setAttackList(){
            Attack soulthorne = new Attack();
            soulthorne.setAttackValues("Soulthorne", 8, 10, 5);
            AttackList.Add(soulthorne);

            Attack waffle = new Attack();
            waffle.setAttackValues("Waffle Maker", 8, 8, 5);
            AttackList.Add(waffle);
            

        }

    }
}
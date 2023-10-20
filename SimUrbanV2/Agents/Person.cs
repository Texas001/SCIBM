using System;
using System.Collections.Generic;
using System.Text;

namespace SimUrbanV2
{
    /// <summary>
    /// Human individual base class
    /// </summary>
    class Person
    {
        private double uid = 0;
        private int age = 0;
        private string gender = "Unknown";
        private string location = "Unknown";
        private string health = "Unknown";
        private string behaviorState = "Unknown";
        private string eduLevel = "Unknown";
        private string lifeStage = "Unknown";
        private bool ifCar = false;
        private string consumLevel = "Unknown";
        private string incomeLevel = "Unknown";



        public Person(){
        }

        public Person(double uid, int age, string gender, string location, string health, string behaviorState,
            string eduLevel, string lifeStage, bool ifCar, string consumLevel, string incomeLevel)
        {
            this.uid = uid;
            this.age = age;
            this.gender = gender ?? throw new ArgumentNullException(nameof(gender));
            this.location = location ?? throw new ArgumentNullException(nameof(location));
            this.health = health ?? throw new ArgumentNullException(nameof(health));
            this.behaviorState = behaviorState ?? throw new ArgumentNullException(nameof(behaviorState));
            this.eduLevel = eduLevel ?? throw new ArgumentNullException(nameof(eduLevel));
            this.lifeStage = lifeStage ?? throw new ArgumentNullException(nameof(lifeStage));
            this.ifCar = ifCar;
            this.consumLevel = consumLevel ?? throw new ArgumentNullException(nameof(consumLevel));
            this.incomeLevel = incomeLevel ?? throw new ArgumentNullException(nameof(incomeLevel));
        }

        public override string ToString()
        {
            return "Uid = " + Uid + ", Age = " + Age + ", Gender = " + Gender 
                + ",Location = " + Location + ", Health = " + Health + ", BehaviorState = " + BehaviorState
                + ", EduLevel = " + EduLevel + ", LifeStage = " + LifeStage
                + ", IfCar = " + IfCar + ", ConsumLevel = " + ConsumLevel + ", IncomeLevel = " + IncomeLevel;
        }


        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Location { get => location; set => location = value; }
        public string Health { get => health; set => health = value; }
        public string BehaviorState { get => behaviorState; set => behaviorState = value; }
        public double Uid { get => uid; set => uid = value; }
        public string EduLevel { get => eduLevel; set => eduLevel = value; }
        public string LifeStage { get => lifeStage; set => lifeStage = value; }
        public bool IfCar { get => ifCar; set => ifCar = value; }
        public string ConsumLevel { get => consumLevel; set => consumLevel = value; }
        public string IncomeLevel { get => incomeLevel; set => incomeLevel = value; }
    }
}

using System;
using System.Collections.Generic;

namespace OverwatchHeroPicker
{
    public class Hero
    {
        string Name { get; }
        string GameClass { get; }

        public Hero(string name, string gameClass)
        {
            Name = name;
            GameClass = gameClass;
        }

        public int Testing()
        {
            return 1;
        }

    }

    public class Heroes : List<Hero>
    {

        public void Seed()
        {
            //Popular with all of the heros
            Hero Ana = new Hero("Ana", "Support");
            this.Add(Ana);

            Hero Ashe = new Hero("Ashe", "Damage");
            this.Add(Ashe);

            Hero Bastion = new Hero("Bastion", "Damage");
            this.Add(Bastion);

            Hero Brigitte = new Hero("Brigitte", "Support");
            this.Add(Brigitte);

            Hero Dva = new Hero("D.va", "Tank");
            this.Add(Dva);

            Hero Doomfist = new Hero("Doomfist", "Damage");
            this.Add(Doomfist);

            Hero Genji = new Hero("Genji", "Damage");
            this.Add(Genji);

            Hero Hanzo = new Hero("Hanzo", "Damage");
            this.Add(Hanzo);

            Hero Junkrat = new Hero("Junkrat", "Damage");
            this.Add(Junkrat);

            Hero Lucio = new Hero("Lucio", "Support");
            this.Add(Lucio);

            Hero Mccree = new Hero("McCree", "Damage");
            this.Add(Mccree);

            Hero Mei = new Hero("Mei", "Damage");
            this.Add(Mei);

            Hero Mercy = new Hero("Mercy", "Support");
            this.Add(Mercy);

            Hero Moira = new Hero("Moira", "Support");
            this.Add(Moira);

            Hero Orisa = new Hero("Orisa", "Tank");
            this.Add(Orisa);

            Hero Pharah = new Hero("Pharah", "Damage");
            this.Add(Pharah);

            Hero Reaper = new Hero("Reaper", "Damage");
            this.Add(Reaper);

            Hero Roadhog = new Hero("Roadhog", "Tank");
            this.Add(Roadhog);

            Hero Soldier = new Hero("Soldier", "Damage");
            this.Add(Soldier);

            Hero Sombra = new Hero("Sombra", "Damage");
            this.Add(Sombra);

            Hero Symmetra = new Hero("Symmetra", "Damage");
            this.Add(Symmetra);

            Hero Torb = new Hero("Torbjorn", "Damage");
            this.Add(Torb);

            Hero Tracer = new Hero("Tracer", "Damage");
            this.Add(Tracer);

            Hero Widowmaker = new Hero("Widowmaker", "Damage");
            this.Add(Widowmaker);

            Hero Winston = new Hero("Winston", "Tank");
            this.Add(Winston);

            Hero Wreckingball = new Hero("Wrecking Ball", "Tank");
            this.Add(Wreckingball);

            Hero Zarya = new Hero("Zarya", "Tank");
            this.Add(Zarya);

            Hero Zenyatta = new Hero("Zenyatta", "Support");
            this.Add(Zenyatta);





        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelslib
{
    public static class TestdatenErzeuger
    {
        public static Testdaten ErzeugeTestdaten()
        {
            // Pfad entsprechend ändern
            var pfadZuBildern = @"D:\Assets\";
            var imagesRuestung = new List<Image>();
            var imagesWaffe = new List<Image>();
            var imagesHelm = new List<Image>();
            var imagesStiefel = new List<Image>();

            var files = Directory.GetFiles(pfadZuBildern).ToList();

            var c = 0;
            foreach (var f in files)
            {
                if (c < 4)
                {
                    imagesHelm.Add(Image.FromFile(f));
                }
                else if (c < 8)
                {
                    imagesRuestung.Add(Image.FromFile(f));

                }
                else if (c < 12)
                {
                    imagesStiefel.Add(Image.FromFile(f));
                }
                else if (c < 16)
                {
                    imagesWaffe.Add(Image.FromFile(f));
                }
                c++;
            }

            var rng = new Random();
            var daten = new Testdaten();

            daten.Character = new Character();

            for (int i = 0; i < 4; i++)
            {
                daten.Ruestungen.Add(new Ruestung() { Name = "Rüstung " + (i + 1), Attack = rng.Next(-5, 5), Defense = rng.Next(1, 10), Health = rng.Next(10, 50), Icon = imagesRuestung[i] });
                daten.Waffen.Add(new Waffe() { Name = "Schwert " + (i + 1), Attack = rng.Next(1, 10), Defense = rng.Next(-5, 5), Health = rng.Next(-5, 5), Icon = imagesWaffe[i] });
                daten.Helme.Add(new Helm() { Name = "Helm " + (i + 1), Attack = rng.Next(-5, 5), Defense = rng.Next(1, 5), Health = rng.Next(1, 20), Icon = imagesHelm[i] });
                daten.Stiefel.Add(new Stiefel() { Name = "Stiefel " + (i + 1), Attack = rng.Next(-5, 5), Defense = rng.Next(1, 5), Health = rng.Next(1, 20), Icon = imagesStiefel[i] });
            }

            return daten;
        }
    }

    public class Testdaten
    {
        public BindingList<Ruestung> Ruestungen { get; set; }
        public BindingList<Waffe> Waffen { get; set; }
        public BindingList<Helm> Helme { get; set; }
        public BindingList<Stiefel> Stiefel { get; set; }

        public Character Character { get; set; }

        public Testdaten()
        {
            Ruestungen = new BindingList<Ruestung>();
            Waffen = new BindingList<Waffe>();
            Helme = new BindingList<Helm>();
            Stiefel = new BindingList<Stiefel>();

            Character = new Character();
        }


    }
}

/* using static System.Console; */

// Uppgift 1.

/* public class Bas {
      string basText;
      
      public Bas() {
            WriteLine("Kallad från Bas Konstruktör");
      }

      public Bas(string nyBasText) {
            basText = nyBasText;
            WriteLine(basText);
      }

      public void BasFunktion() {
            WriteLine("Kallad från BasFunktionen");
      }
}

public class Arv : Bas {
      public Arv() {
            WriteLine("Kallad från Arv Konstruktör");
      }

      public new void BasFunktion() {
            base.BasFunktion();

            WriteLine("Kallad från en ny ArvFunktion");
      }

      static void Main() {
            Arv arv = new Arv();
            arv.BasFunktion();
            ((Bas)arv).BasFunktion();
      }
} */

// Uppgift 2.

/* abstract class Mått {
      public abstract double Area {
            get;
            set;
      }
}
class Kvadrat : Mått {
      public double sida;

      public Kvadrat(double s) {
            sida = s;
      }

      public override double Area {
            get {
                  return sida * sida;
            }
            set {
                  sida = Math.Sqrt(value);
            }
      }
}

class Kub : Mått {
      public double sida;

      public Kub(double s) {
            sida = s;
      }

      public override double Area {
            get {
                  return 6 * sida * sida;
            }
            set {
                  sida = Math.Sqrt(value / 6);
            }
      }
}

class Program {
      static void Main() {
            WriteLine("Ange sidans längd:");
            double sida = double.Parse(ReadLine());
            Kvadrat s = new Kvadrat(sida);
            Kub c = new Kub(sida);

            WriteLine($"Arean av kvadraten är: {s.Area}");
            WriteLine($"Arean av kuben är: {c.Area}");
            WriteLine();
            WriteLine("Ange arean:");
            double area = double.Parse(ReadLine());

            s.Area = area;
            c.Area = area;
            WriteLine($"Sidan av kvadraten är: {s.sida}");
            WriteLine($"Sidan av kuben är: {c.sida}");
      }
} */

// Uppgift 3.
/* 
public class DrawObject() {
      public virtual void Draw() {
            WriteLine("Baskonstruktör ritning");
      }
}

public class Line : DrawObject {
      public override void Draw() {
            WriteLine("Linje ritning");
      }
}

public class Circle : DrawObject {
      public override void Draw() {
            WriteLine("Cirkel ritning");
      }
}

public class Kvadrat : DrawObject {
      public override void Draw() {
            WriteLine("Kvadrat ritning");
      }
}

public class DemoForDrawing {
      public static void Main() {
            DrawObject[] drawObject = new DrawObject[4];
            drawObject[0] = new Line();
            drawObject[1] = new Circle();
            drawObject[2] = new Kvadrat();
            drawObject[3] = new DrawObject();

            foreach (DrawObject drawObj in drawObject) {
                  drawObj.Draw();
            }
      } 
} */
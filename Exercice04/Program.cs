using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercice04
{
    internal class Program

    {
          class Cercle
        {
            private List<Point> centre;
            private double rayon;
            public double Rayon
            {
                get { return rayon; }
                set { rayon = value; }
            }
            public  double calculAire(double rayon){
                double aire = Math.PI * rayon * rayon;
                return aire;
                }
            public void Circonf(double rayon)
            {
                double circonf= 2*Math.PI * rayon;
                Console.WriteLine("la circonference de cercle: " + circonf);
            }
            public Cercle(Point centre, double rayon = 0)
            {
                this.centre =centre;
                this.rayon =rayon;
            }
            public void intersection(Cercle c1,Cercle c2)
            {
               double d=c1.centre.distance(c2);
                if (d> c1.rayon + c2.rayon)
                {
                    Console.WriteLine("il n'y a pas d'intersection");
                }
                else if (d<Math.Abs(c1.rayon - c2.rayon))
                {
                    Console.WriteLine("un cercle est l'interieur de l'autre pas d'intersection !");
                }
                else if (d==0 && (c1.rayon == c2.rayon))
                {
                    Console.WriteLine("il y a  un nombre infini de points d'intersection");
                }
                else
                {
                    Console.WriteLine("il y a deux points d'intersections");
                }

            }
            public Boolean egalite (Cercle c)
            {
                return (c.rayon == this.rayon);
            }
          
        }
        class Droite
        {
            Point p1, p2;
            public Droite(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}

namespace Poblacion3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Ciudadano c;
      List<Ciudadano> ciudadanos = new List<Ciudadano>();
      c = new Ciudadano("QWERT1111111", "ANGELICA", "RUIZ", "PEREZ", 10);
      ciudadanos.Add(c);
      c = new Ciudadano("YUIOP2222222", "JOSE LUIS", "LOPEZ", "MORALES", 38);
      ciudadanos.Add(c);
      c = new Ciudadano("SDFGH3333333", "ENRIQYE", "JIMENEZ", "RODRIGUEZ", 0);
      ciudadanos.Add(c);
      c = new Ciudadano("JKLLK4444444", "BRAYAM", "CRUZ", "GARCIA", 6);
      ciudadanos.Add(c);
      c = new Ciudadano("ZXCVB5555555", "NICOLAS", "SANCHEZ", "MENDEZ", 15);
      ciudadanos.Add(c);
      c = new Ciudadano("NMMNB6666666", "JUAN GABRIEL", "GARCIA", "JIMENEZ", 25);
      ciudadanos.Add(c);
      c = new Ciudadano("QWERT7777777", "RAMIRO", "ESCAMILLA", "RUIZ", 80);
      ciudadanos.Add(c);
      c = new Ciudadano("MNBVC8888888", "ERIKA", "GUTIERREZ", "SANCHEZ", 16);
      ciudadanos.Add(c);
      c = new Ciudadano("XZZXC9999999", "GUADALUPE", "DOMINGUEZ", "MORALES", 43);
      ciudadanos.Add(c);

      int cuentaNinios = 0;
      int cuentaAdoles = 0;
      int cuentaAdultos = 0;
      int cuentaMaduros = 0;
      int cuentaAncianos = 0;
      int totalPoblacion = 0;

      float porcNinios = 0.0F;
      float porcAdoles = 0.0F;
      float porcAdultos = 0.0F;
      float porcMaduros = 0.0F;
      float porcAncianos = 0.0F;

      foreach (Ciudadano ciudadano in ciudadanos)
      {
        if (ciudadano.edad >= 0 && ciudadano.edad <= 12)
        {
          cuentaNinios++;
        }
        if (ciudadano.edad >= 13 && ciudadano.edad <= 17)
        {
          cuentaAdoles++;
        }
        if (ciudadano.edad >= 18 && ciudadano.edad <= 39)
        {
          cuentaAdultos++;
        }
        if (ciudadano.edad >= 40 && ciudadano.edad <= 60)
        {
          cuentaMaduros++;
        }
        if (ciudadano.edad >= 61 && ciudadano.edad <= 120)
        {
          cuentaAncianos++;
        }
      }

      totalPoblacion = ciudadanos.Count();
      porcNinios = (float)cuentaNinios / totalPoblacion * 100;
      porcAdoles = (float)cuentaAdoles / totalPoblacion * 100;
      porcAdultos = (float)cuentaAdultos / totalPoblacion * 100;
      porcMaduros = (float)cuentaMaduros / totalPoblacion * 100;
      porcAncianos = (float)cuentaAncianos / totalPoblacion * 100;

      Console.WriteLine(string.Format("{0:0.00}", porcNinios) + "% Niños");
      Console.WriteLine(string.Format("{0:0.00}", porcAdoles) + "% Adolescentes");
      Console.WriteLine(string.Format("{0:0.00}", porcAdultos) + "% Adultos Jóvenes");
      Console.WriteLine(string.Format("{0:0.00}", porcMaduros) + "% Maduros");
      Console.WriteLine(string.Format("{0:0.00}", porcAncianos) + "% Ancianos");

    }
  }
}

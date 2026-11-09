using System;
using System.Collections.Generic;
using System.Text;

namespace Poblacion3
{
  internal class Ciudadano
  {
    public string curp;
    public string nombre;
    public string apePat;
    public string apeMat;
    public int edad;

    public Ciudadano()
    {
      curp = "###";
      nombre = "(Sin nombre)";
    }

    public Ciudadano(string curp, string nombre, string apePat, string apeMat, int edad)
    {
      this.curp = curp;
      this.nombre = nombre;
      this.apePat = apePat;
      this.apeMat = apeMat;
      this.edad = edad;
    }

  }
}

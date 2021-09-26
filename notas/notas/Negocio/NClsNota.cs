using notas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas.Negocio
{
    class NClsNota
    {

        public string Calculo(ClsNota datos)
        {
            datos.Periodo1 = datos.Lab1 * 0.40 + datos.Parcial1 * 0.60;
            datos.Periodo2 = datos.Lab2 * 0.40 + datos.Parcial2 * 0.60;
            datos.Periodo3 = datos.Lab3 * 0.40 + datos.Parcial3 * 0.60;
            datos.Ciclo1 = (datos.Periodo1 + datos.Periodo1 + datos.Periodo1) / 3;
            datos.Ciclo1 = Convert.ToDouble(datos.Ciclo1);

            return "\nNombre; " + datos.Nombre + "\nApellido; " + datos.Apellido +
                "\nPeriodo 1: " + datos.Periodo1 + " \nPeriodo 2: " + datos.Periodo2 + "\nPeriodo 3: " + datos.Periodo3 + "\nPromedio final; " +datos.Ciclo1;
        }
    }
}

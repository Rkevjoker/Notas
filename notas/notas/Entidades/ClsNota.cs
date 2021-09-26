using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas.Entidades
{
    class ClsNota
    {
        private string nombre;
        private string apellido;
        private string asignatura;


        private double lab1;
        private double parcial1;
        private double periodo1;

        private double lab2;
        private double parcial2;
        private double periodo2;

        private double lab3;
        private double parcial3;
        private double periodo3;

        private double ciclo1;

        public ClsNota()
        {
        }

        public ClsNota(string nombre, string apellido, string asignatura, double lab1, double parcial1, double periodo1, double lab2, double parcial2, double periodo2, double lab3, double parcial3, double periodo3, double ciclo1)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.asignatura = asignatura;
            this.lab1 = lab1;
            this.parcial1 = parcial1;
            this.periodo1 = periodo1;
            this.lab2 = lab2;
            this.parcial2 = parcial2;
            this.periodo2 = periodo2;
            this.lab3 = lab3;
            this.parcial3 = parcial3;
            this.periodo3 = periodo3;
            this.ciclo1 = ciclo1;
        }

        public double Lab1 { get => lab1; set => lab1 = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Periodo1 { get => periodo1; set => periodo1 = value; }
        public double Lab2 { get => lab2; set => lab2 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Periodo2 { get => periodo2; set => periodo2 = value; }
        public double Lab3 { get => lab3; set => lab3 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Periodo3 { get => periodo3; set => periodo3 = value; }
        public double Ciclo1 { get => ciclo1; set => ciclo1 = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
    }
}

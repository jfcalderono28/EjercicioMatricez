using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasNet4._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matrizAleatoria = new Matriz();

            Matriz matrizManual = new Matriz(true);

            Matriz matrizResultado = new Matriz(matrizAleatoria.getX(), matrizManual.getX());

            matrizAleatoria.imprimir();
            Console.WriteLine();
            matrizManual.imprimir();
            Console.WriteLine();
            matrizResultado.imprimir();
        }
    }
}








//CLASE MATRIZ
//
//
//
/// <summary>
/// ////////////////////////////////////////////////////
/// </summary>
class Matriz
{
    int[,] x = new int[3, 3];

    //CONSTRUCTORES
    public Matriz()
    {
        rellenarAleatorio();
    }

    public Matriz(Boolean pedirDatos)
    {
        if (pedirDatos == true)
        {
            this.pedirDatos();
        }
    }

    public Matriz(int [,]a, int [,]b)
    {
        calcular(a, b);
    }



    //MÉTODOS
    public void rellenarAleatorio()
    {
        Random rnd = new Random();

 
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x[i,j] = rnd.Next(10);
            }
        }
    }
    public void pedirDatos()
    {
        int y = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                y++;
                Console.WriteLine("Ingrese el dato: " + y);
                x[i,j] = int.Parse(Console.ReadLine());
            }
        }
    }
    public void imprimir()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write("[" + x[i,j] + "]");

            }
        }
    }
    public int[] traerFila(int x, int [,]a)
    {
        int []fila= { 0, 0, 0 };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == x)
                {
                    fila[j] = a[i,j];
                }

            }
        }
        return fila;
    }

    public int[] traerColumna(int y, int [,]b)
    {
        int [] columna = { 0, 0, 0 };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == y)
                {
                    columna[i] = b[i,j];
                }

            }
        }
        return columna;
    }
    public int calcularCampo(int []x, int []y)
    {
        int resultado = 0;
        for (int i = 0; i < 3; i++)
        {
            resultado += x[i] * y[i];
        }
        return resultado;
    }
    public void calcular(int [,]a, int [,]b)
    {

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int [] fila = traerFila(i, a);
                int [] columna = traerColumna(j, b);

                x[i,j] = calcularCampo(fila, columna);
            }
        }
    }









    //GETTERS AND SETTERS
    public int[,] getX()
    {
        return x;
    }

    public void setX(int[,] x)
    {
        this.x = x;
    }

}

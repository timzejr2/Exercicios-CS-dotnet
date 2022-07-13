using System;
using System.Collections.Generic;
using Cursos.Entities;

namespace Cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aluno;

            HashSet<Curso> cursoA = new HashSet<Curso>();
            HashSet<Curso> cursoB = new HashSet<Curso>();
            HashSet<Curso> cursoC = new HashSet<Curso>();

            Console.Write("How many studnts for course A? ");
            int quantA = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantA; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                cursoA.Add(new Curso(aluno));
            }

            Console.WriteLine("How many studnts for course B?");
            int quantB = int.Parse(Console.ReadLine());
            for( int i = 0; i < quantB; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                cursoB.Add(new Curso(aluno));
            }

            Console.WriteLine("How many studnts for course C?");
            int quantC = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantC; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                cursoC.Add(new Curso(aluno));
            }

            HashSet<Curso> total = new HashSet<Curso>(cursoA);
            total.UnionWith(cursoB);
            total.UnionWith(cursoC);

            Console.WriteLine("Total Students: " + total.Count);

        }
    }
}

namespace Cursos.Entities
{
    internal class Curso
    {
        public int Student { get; set; }

        public Curso(int student)
        {
            Student = student;
        }

        public override int GetHashCode()
        {
            return Student.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Curso))
            {
                return false;
            }
            Curso other = obj as Curso;
            return Student == other.Student;
        }
    }
}

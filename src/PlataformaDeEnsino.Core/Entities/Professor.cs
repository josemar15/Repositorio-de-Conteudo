using System.Collections.Generic;

namespace PlataformaDeEnsino.Core.Entities
{
    public class Professor
    {
        public int IdDoProfessor { get; private set; }
        public string NomeDoProfessor { get; private set; }
        public string SobrenomeDoProfessor { get; private set; }
        public string CpfDoProfessor { get; private set; }
        public string EstadoDoProfessor { get; private set; }

        public ICollection<Unidade> Unidades { get; private set; }


    }
}
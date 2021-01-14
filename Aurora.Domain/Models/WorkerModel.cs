using System;

namespace Aurora.Domain.Models
{
    public class WorkerModel
    {
        public WorkerModel(int id, string name, DateTime birthDate, string cpf, string Namorada)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Nin = cpf;
            Girlfriend = Namorada;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Nin { get; set; }
        public string Girlfriend { get; set; }
    }
}

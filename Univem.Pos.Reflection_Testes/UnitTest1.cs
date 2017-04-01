using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univem.Pos.Reflection;
using Univem.Pos.Reflection.Interfaces;
using Univem.Pos.Reflection_Testes.Entity;

namespace Univem.Pos.Reflection_Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogger log = new Logger(new LogToFile("C:\\"));
            //ILogger log = new Logger(new LogToTrace());

            Person p = new Person(log);
            p.Name = "Pessoa 1";
            p.Weight = 60;
            p.PersonType = PersonType.FISICA;
            p.Languages = new String[3] { "Português", "Inglês", "Francês"};

            Address e = new Address();
            e.Street = "Rua abc";
            e.Number = 100;

            p.Endereco = e;

            decimal imc = p.CalcIMC();

        }
    }
}

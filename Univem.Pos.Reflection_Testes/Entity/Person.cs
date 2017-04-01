using Univem.Pos.Reflection.Interfaces;
using System;

namespace Univem.Pos.Reflection_Testes.Entity
{
    public class Person
    {
        ILogger log;
        public Person(ILogger log)
        {
            this.log = log;
        }
        public String[] Languages { get; set; }
        public String Name { get; set; }
        public Int32 Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public PersonType PersonType { get; set; }
        public Address Endereco { get; set; }


        public decimal CalcIMC()
        {
            try
            {
                return Weight/ ( Height* Height);
            }
            catch (Exception e)
            {
                log.Log("CalcIMC", e, this);
                return -1;
            }

        }

    }
}

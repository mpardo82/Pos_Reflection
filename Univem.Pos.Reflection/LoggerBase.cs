using System;
using System.Reflection;
using System.Text;

namespace Univem.Pos.Reflection
{
    public class LoggerBase
    {
        protected String Log(object obj)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(String.Format("=={0}==", obj.GetType().FullName));

            foreach (PropertyInfo p in obj.GetType().GetProperties())
            {
                object valor = obj.GetType().GetProperty(p.Name).GetValue(obj, null);

                if (valor == null)
                    valor = "null";

                if (p.PropertyType.IsArray)
                {
                    valor = LogArray(valor);
                }
                else if (p.PropertyType.IsClass && p.PropertyType.Assembly == obj.GetType().Assembly)
                {
                    valor = Log(valor);
                }

                retorno.AppendLine(String.Format("{0}({1}):{2}", p.Name, p.PropertyType.Name, valor));
            }
            return retorno.ToString();

        }

        protected String LogArray(Object obj)
        {
            StringBuilder retorno = new StringBuilder();
            string prepend = "";

            Array ar = (Array)obj;
            if (obj != null && ar.Length > 0)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    retorno.Append(prepend);
                    retorno.AppendFormat("{0}", ar.GetValue(i));
                    prepend = ",";
                }
            }

            return String.Format("[{0}]", retorno.ToString());
        }

    }

}

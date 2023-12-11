using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDeDados;
using CapaDeEntidade;

namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsdados = new ClasseDados();
        public DataTable N_Login(ClasseEntidade obje)
        {
            return clsdados.Dlogin(obje);
        }
    }
}

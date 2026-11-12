using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco.CapaDatos
{
    public class cls_cuentacliente
    {
		private int codigo;

		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private float monto;

		public float Monto
		{
			get { return monto; }
			set { monto = value; }
		}

        

    }
}
﻿using Dapper;
using Simisoft.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simisoft.Buins
{
    public class FormaPago
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idFPago { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public FormaPago()
        {

        }


        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_formaspago_add", parametros);


        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", idFPago);
            return dataAccess.Execute("stp_formaspago_delete", parametros);
        }

        public List<FormaPago> GetAll()
        {
            return dataAccess.Query<FormaPago>("stp_formaspago_getall");
        }

        public FormaPago GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", idFPago);
            return dataAccess.QuerySingle<FormaPago>("stp_formaspago_getbyid", parametros);
        }


        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", idFPago);
            parametros.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_formaspago_update", parametros);
        }




    }
}

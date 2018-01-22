using LojaAPI.DAO;
using LojaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaAPI.Controllers
{
    public class CarrinhoController : ApiController
    {
        public string GetBuscaCarrinho(long id)
        {
            try
            {
                CarrinhoDAO dao = new CarrinhoDAO();
                var carrinho = dao.Busca(id);
                return carrinho.ToXml();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public string GetBuscaCarrinho(long id)
        //{
        //    try
        //    {
        //        CarrinhoDAO dao = new CarrinhoDAO();
        //        var carrinho = dao.Busca(id);
        //        return carrinho.ToXml();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}


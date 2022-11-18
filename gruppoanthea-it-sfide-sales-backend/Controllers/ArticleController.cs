using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace gruppoanthea_it_sfide_sales_backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ArticleController : ApiController
    {
        private Data data;

        ArticleController() { this.data = new Data(); }

        public List<Models.Article> GetArticles()
        {
            return this.data.getArticles();
        }

        [HttpPost]
        public List<Models.Cart> PrintReceipt(List<Models.Cart> carts)
        {
            foreach (Models.Cart cart in carts)
            {
                cart.salesTaxes = (cart.article.price / 100) * cart.article.basicSalesTax;

                if (cart.article.isImported)
                    cart.salesTaxes += (cart.article.price / 100) * 5;

                cart.price = Math.Round((cart.article.price + cart.salesTaxes) * cart.quantity, 2);
                cart.salesTaxes = Math.Round((cart.salesTaxes * cart.quantity), 2);
            }

            return carts;
        }
    }
}
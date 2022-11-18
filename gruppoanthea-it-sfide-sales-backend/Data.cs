using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gruppoanthea_it_sfide_sales_backend
{
    public class Data
    {
        public List<Models.Article> getArticles()
        {
            return new List<Models.Article>()
            {
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Book",
                    url = "https://www.estetica-mente.com/wp-content/uploads/2019/12/LIBRO-625x330.jpg",
                    price = 12.49,
                    isImported = false,
                    basicSalesTax = 0
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Music CD",
                    url = "https://www.lafeltrinelli.it/images/0887828045518_0_0_300_50.jpg",
                    price = 14.99,
                    isImported = false,
                    basicSalesTax = 10
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Chocolate Bar",
                    url = "https://www.eatthis.com/wp-content/uploads/sites/4/2021/05/chocolate-bars.jpg?quality=82&strip=1",
                    price = 0.85,
                    isImported = false,
                    basicSalesTax = 0
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Box of Chocolates 1",
                    url = "https://www.nuvoledibellezza.com/wp-content/uploads/2022/10/ColourPop-Not-a-Box-of-Chocolates-01.jpeg",
                    price = 10.00,
                    isImported = true,
                    basicSalesTax = 0
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Bottle of Perfume 1",
                    url = "https://www.3dnatives.com/en/wp-content/uploads/sites/2/perfum_cover-1-1280x720.jpg",
                    price = 47.50,
                    isImported = true,
                    basicSalesTax = 10
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Bottle of Perfume 2",
                    url = "https://media.glamourmagazine.co.uk/photos/613892f35ebdbf876576ad7c/4:3/w_1920,h_1440,c_limit/gettyimages-959786750_sq.jpg",
                    price = 27.99,
                    isImported = true,
                    basicSalesTax = 10
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Bottle of Perfume 3",
                    url = "https://www.idfdesign.it/immagini/complementi-arredo-classici-di-lusso/perfume-bottles-soggiorni-3.jpg",
                    price = 18.99,
                    isImported = false,
                    basicSalesTax = 10
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Packet of Headache Pills",
                    url = "https://c8.alamy.com/comp/T8N1J5/pink-tablets-pill-in-blister-pack-painkiller-medicine-for-treatment-migraine-headache-and-high-fever-non-steroidal-anti-inflammatory-drugs-nsaids-T8N1J5.jpg",
                    price = 9.75,
                    isImported = false,
                    basicSalesTax = 0
                },
                new Models.Article()
                {
                    id = Guid.NewGuid(),
                    name = "Box of Chocolates 2",
                    url = "https://images.newcomernet.com/blogimages/blogimage-636432226971287548.jpg",
                    price = 11.25,
                    isImported = true,
                    basicSalesTax = 0
                }
            };
        }
    }
}
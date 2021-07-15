using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2_3
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        // 생성자
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        // 매출 데이터를 읽어 들이고 Sale 객체의 리스트를 반환한다
        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCatergory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }
        
        // 점포별 매출을 구한다
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        
        // 상품 종류별 매출액을 구한다
        public IDictionary<string, int> GetPerProductSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCatergory))
                    dict[sale.ProductCatergory] += sale.Amount;
                else
                    dict[sale.ProductCatergory] = sale.Amount;
            }
            return dict;    
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3{
    //売上請求データ
    public class SalesCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //List 2-15
        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

            //List 2-17
            //店舗売り上げを求める
            public IDictionary<string, int> GetPerShopSales() {
            var dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                if(dict.ContainsKey(sale.ShopName))
                    //既にコレクションへ店舗が登録されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount; 
            }
            return dict;
        }
        //商品カテゴリ店舗別売り上げを求める
         public IDictionary<string, int> GetPerCategorySales() {
            var dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    //既にコレクションへ店舗が登録されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}

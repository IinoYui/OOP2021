using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上請求データ
    class SalesCounter {

        private List<Sale> _sales;

        public SalesCounster(List<Sale> sales) {
            _sales = sales;
        }
    }
}

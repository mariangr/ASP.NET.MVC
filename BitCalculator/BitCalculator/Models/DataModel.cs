using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator.Models
{
    public class DataModel
    {
        public int Quantity { set; get; }
        public int Type { set; get; }
        public int Kilo { set; get; }
        public double[] kilos = new double[18];

        public void setTableData()
        {
            this.kilos[this.Type] = this.Quantity;

            for (int i = this.Type - 2; i >= 0; i -= 2)
            {
                this.kilos[i] = kilos[i + 2] * this.Kilo;
            }
            for (int i = this.Type + 2; i < kilos.Length; i += 2)
            {
                this.kilos[i] = kilos[i - 2] / this.Kilo;
            }
            if (this.Type % 2 == 0)
            {
                for (int i = 1; i < this.kilos.Length; i += 2)
                {
                    this.kilos[i] = this.kilos[i - 1] / 8;
                }
            }
            else
            {
                for (int i = 0; i < this.kilos.Length - 1; i += 2)
                {
                    this.kilos[i] = this.kilos[i + 1] * 8;
                }
            }

        }
    }
}
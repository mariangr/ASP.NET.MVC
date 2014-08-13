using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator.Models
{
    public class TableDataModel
    {
        public double[] kilos = new double[18];
        private int currentElement;
        private int current;
        public int multiplier;

        public void GetParams(DataModel dataModel)
        {
            current = dataModel.Type;
            multiplier = dataModel.Kilo;
            currentElement = dataModel.Quantity;
            this.setTableData();

        }

        private void setTableData() {
            this.kilos[this.current] = this.currentElement;
            //TO DO bit and byte separation logic and filling
            for (int i = this.current - 2; i >= 0; i-=2) 
            {
                this.kilos[i] = kilos[i + 2] * this.multiplier;
            }
            for (int i = this.current + 2; i<kilos.Length;i+=2)
            {
                this.kilos[i] = kilos[i - 2] / this.multiplier;
            }
            if (this.current % 2 == 0)
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
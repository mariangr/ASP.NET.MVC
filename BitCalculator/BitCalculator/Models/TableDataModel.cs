using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator.Models
{
    public class TableDataModel
    {
        double[] kilos = new double[18];
        private int currentElement;
        private int current;
        private int multiplier;

        public void GetParams(DataModel dataModel)
        {
            current = dataModel.Type;
            multiplier = dataModel.Kilo;
            currentElement = dataModel.Quantity;
        }

        private void setTableData() {
            this.kilos[this.current] = this.currentElement;
            //TO DO bit and byte separation logic and filling
            for (int i = this.current - 1; i >= 0; i-=2) 
            {
                this.kilos[i] = kilos[i + 1] / this.multiplier;

            
            }
        }
    }
}
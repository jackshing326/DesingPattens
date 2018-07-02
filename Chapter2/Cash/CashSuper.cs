using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash
{
    public abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }

    public class CashNormal : CashSuper
    {
        private double moneyRebate = 1d;
        public override double acceptCash(double money)
        {
            return money;
        }
    }
    //打折類別
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }

    }

    //紅利類別
    public class CashReturn : CashSuper
    {
        private double moneyReturn = 0.0d;
        private double moneyCondition = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            }
            return result;
        }
    }

    //現金類別
    public class CashFactoy
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;

                case "滿三百送一百":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;

                case "打八折":
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
            }
            return cs; 
        }
    }

    //改造後
    public class CashContext
    {
        CashSuper cs = null;

        public CashContext (string type)
        {
           
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;

                case "滿三百送一百":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;

                case "打八折":
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
            }
         
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}

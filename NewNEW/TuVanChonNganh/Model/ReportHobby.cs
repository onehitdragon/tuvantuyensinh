using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuVanChonNganh.Model
{
    public class ReportHobby
    {
        private int happyAmount;
        private int unhappyAmount;
        private int total;

        public int HappyAmount { get => happyAmount; set => happyAmount = value; }
        public int UnhappyAmount { get => unhappyAmount; set => unhappyAmount = value; }
        public int Total { get => total; set => total = value; }

        public ReportHobby(int happyAmount, int unhappyAmount, int total)
        {
            this.happyAmount = happyAmount;
            this.unhappyAmount = unhappyAmount;
            this.total = total;
        }

        public double CalcPercentHappy()
        {
            return (HappyAmount * 1.0 / Total * 1.0) * 100.0;
        }
    }
}
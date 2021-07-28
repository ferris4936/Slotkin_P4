using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P4
{
    public class DepreciationStraightLine
    {
        private DateTime dateAddedToInventory;
        private DateTime dateRemovedFromInventory;
        private decimal startOfLifeValue;
        private decimal endOfLifeValue;
        private int lifetimeOfItem;
        private decimal salvageValue;
        private decimal annualDepreciation;

        public string Title { get; set; }

        public decimal AnnualDepreciation
        {
            get { return annualDepreciation; }
            set { Calc(); }
        }

        public DateTime DateAddedToInventory
        {
            get { return dateAddedToInventory; }
            set { dateAddedToInventory = value; Calc(); }
        }

        public DateTime DateRemovedFromInventory
        {
            get { return dateRemovedFromInventory; }
            set { dateRemovedFromInventory = value; Calc(); }
        }

        public decimal StartOfLifeValue
        {
            get { return startOfLifeValue; }
            set { startOfLifeValue = value; Calc(); }
        }

        public decimal EndOfLifeValue
        {
            get { return endOfLifeValue; }
            set { endOfLifeValue = value; Calc(); }
        }

        public int LifetimeOfItem
        {
            get { return lifetimeOfItem; }
            set { lifetimeOfItem = value; Calc(); }
        }

        public decimal SalvageValue
        {
            get { return salvageValue; }
            set { salvageValue = startOfLifeValue - endOfLifeValue; }
        }

        public DepreciationStraightLine(string inventoryItem, DateTime dateAdded, 
            DateTime dateRemoved, decimal endingValue, int life, decimal startingValue)
        {
            this.Title = inventoryItem;
            this.DateAddedToInventory = dateAdded;
            this.DateRemovedFromInventory = dateRemoved;
            this.EndOfLifeValue = endingValue;
            this.LifetimeOfItem = life;
            this.StartOfLifeValue = startingValue;
        }

        public DepreciationStraightLine()
        {
            //this.Title = "Unknown";
            ////this.DateAddedToInventory = DateTime.Parse("00/00/00 00 00 00"); //bad format
            ////this.DateRemovedFromInventory = DateTime.Parse("00/00/00 00 00 00"); //bad format
            //this.EndOfLifeValue = 0.0M;
            //this.LifetimeOfItem = 0;
            //this.StartOfLifeValue = 0.0M;
        }

        public virtual void Calc()
        {
            decimal depreciableAsset = StartOfLifeValue - SalvageValue;
            annualDepreciation = DepreciationStraightLineMethod() * depreciableAsset;
        }

        public decimal DepreciationStraightLineMethod()
        {
            decimal depreciationRatePerYear = 1 / 5; //I want to put in 'LifetimeOfItem' instead of 5 but it defaults to 0 like i's not being read in????
            return depreciationRatePerYear;  
        }

        new public string ToString()  
        {
            return "\"" + Title + "\"" + " - Start value: $" + StartOfLifeValue +
                " End value: $" + EndOfLifeValue + " Lifetime: " + LifetimeOfItem; 
        }
    }
}

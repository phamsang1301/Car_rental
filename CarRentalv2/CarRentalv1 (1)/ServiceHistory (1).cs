using System;
using System.Collections.Generic;
using System.Text;


namespace CarRentalv1
{
    public class ServiceHistory
    {
        private List<Record> _history = new List<Record>();

        public ServiceHistory(DateTime date, float mile, string type, float price, string garage)
        {
            this.AddRecord(date, mile, type, price, garage);
        }

        public ServiceHistory(DateTime date)
        {
            this.AddRecord(date, 0, "Full", 0, "Factory New");
        }

        public void AddRecord(DateTime date, float mile, string type, float price, string garage)
        {
            Record record = new Record(date, mile, type, price, garage);
            this._history.Add(record);
        }

        public float SuctractRecord(int index1, int index2)
        {
            Record record1 = this._history[index1];
            Record record2 = this._history[index2];

            return record1 - record2;
        }

        public bool CompareLesserThanRecord(int index1, int index2)
        {
            Record record1 = this._history[index1];
            Record record2 = this._history[index2];

            return record1 < record2;
        }


        public Record PopRecord()
        {
            return this._history[_history.Count - 1];
        }

        public Record GetRecord(int i)
        {
            return this._history[i];
        }

        public List<Record> PrintServiceHistory()
        {
            return _history;
        }
    }

    
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class StautsOfNetPackages {
        public StautsOfNetPackages(string size_number, string[] packages) {
            Queue queue = new Queue(Convert.ToInt32(size_number.Split(' ')[0]));
            for (int i = 0; i < packages.Length; i++) {
                int arrivalTime = Convert.ToInt32(packages[0].Split(" ")[0]);
                int durationTime = Convert.ToInt32(packages[0].Split(" ")[1]);
                Package package = new Package() { ArrivalTime =arrivalTime, DurationTime = durationTime };
             }

        }
    }

    class Queue {
        public Queue(int size) {
            this.Size = size;
            QueueList = new List<Package>();
        }
        public List<Package> QueueList { get; set; }
        public int Size { get; set; }
        public int OccupiedSize { get; set; } = 0;
        public int Duration { get; set; } = 0;
        public bool AddPackage(Package package) {
            if (Size - OccupiedSize > 0) {
                OccupiedSize++;
                QueueList.Add(package);
                return true;
            }
            return false;
        }
        public bool RemovePackage() {
            if (OccupiedSize > 0) {
                QueueList.RemoveAt(0);
                return true;
            }
            return false;
        }
    }
    class Package {
        public Package()
        {
            
        }
        public Package(int arrivalTime, int durationTime) {
            this.ArrivalTime = arrivalTime;
            this.DurationTime = durationTime;
        }
        public int ArrivalTime { get; set; }
        public int DurationTime { get; set; }
    }
}

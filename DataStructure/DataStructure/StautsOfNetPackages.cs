using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class StautsOfNetPackages {
        Queue queue;
        public StautsOfNetPackages(string size_number, List<string>? packages) {
            queue = new Queue(Convert.ToInt32(size_number.Split(' ')[0]));
            if (packages != null) {
                for (int i = 0; i < packages.Count; i++) {
                    int arrivalTime = Convert.ToInt32(packages[i].Split(" ")[0]);
                    int durationTime = Convert.ToInt32(packages[i].Split(" ")[1]);
                    Package package = new Package() { ArrivalTime = arrivalTime, DurationTime = durationTime };
                    queue.AddPackage(package);
                }
            }


        }
        public List<int> GetOutputString() { return queue.FinalList; }
    }

    class Queue {
        public Queue(int size) {
            this.Size = size;
            QueueList = new List<Package>();
            FinalList = new List<int>();
        }
        public List<Package> QueueList { get; set; }
        public List<int> FinalList { get; set; }
        public int Size { get; set; }

        public void AddPackage(Package package) {
            if (QueueList.Count == 0) {
                package.ProcessStartTime = package.ArrivalTime;
                QueueList.Add(package);
                FinalList.Add(package.ProcessStartTime);
            } else {
                Package previousPackage = QueueList[QueueList.Count - 1];
                if (Size > QueueList.Count) {                    
                    if(package.ArrivalTime>= previousPackage.ProcessStartTime + previousPackage.DurationTime) {
                        package.ProcessStartTime = package.ArrivalTime;
                    } else {
                        package.ProcessStartTime = previousPackage.ProcessStartTime + previousPackage.DurationTime;
                    }
                    QueueList.Add(package);
                    FinalList.Add(package.ProcessStartTime);
                } else {
                    if (package.ArrivalTime >= QueueList[0].ProcessStartTime + QueueList[0].DurationTime) {
                        if (package.ArrivalTime > previousPackage.ProcessStartTime + previousPackage.DurationTime) {
                            package.ProcessStartTime = package.ArrivalTime;
                        } else {
                            package.ProcessStartTime = previousPackage.ProcessStartTime + previousPackage.DurationTime;
                        }
                        FinalList.Add(package.ProcessStartTime);
                        QueueList.Add(package);
                        QueueList.RemoveAt(0);

                    } else {
                        FinalList.Add(-1);
                    }
                }

            }

        }
    }
    class Package {
        public Package() {

        }
        public Package(int arrivalTime, int durationTime) {
            this.ArrivalTime = arrivalTime;
            this.DurationTime = durationTime;
            this.ProcessStartTime = arrivalTime;
        }
        public int ArrivalTime { get; set; }
        public int DurationTime { get; set; }
        public int ProcessStartTime { get; set; }
    }
}

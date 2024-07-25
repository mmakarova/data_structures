using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class StautsOfNetPackages {
        Queue queue;
        public StautsOfNetPackages(string size_number, List<string>? packages) {
            if (packages != null) {
                queue = new Queue(Convert.ToInt32(size_number.Split(' ')[0]));
                for (int i = 0; i < packages.Count; i++) {
                    int arrivalTime = Convert.ToInt32(packages[i].Split(" ")[0]);
                    int durationTime = Convert.ToInt32(packages[i].Split(" ")[1]);
                    Package package = new Package() { ArrivalTime = arrivalTime, DurationTime = durationTime };
                    queue.ProcessPackage();
                    queue.AddPackage(package);
                }
                for (int i = 0; i < queue.QueueList.Count; i++) {
                    queue.ProcessPackage();
                }
            }

        }
        public List<int> GetOutputString() { return queue.FinalList; }
    }

    class Queue {
        public Queue(int size) {
            this.Size = size;
            QueueList = new List<Package>();
        }
        public List<Package> QueueList { get; set; }
        public List<int> FinalList { get; set; }
        public int Size { get; set; }
        public int OccupiedSize { get; set; } = 0;
        public int WorkingTime { get; set; } = 0;

        //1
        public void ProcessPackage() {
            if (QueueList.Count > 0) {
                Package package = QueueList[0];
                if (WorkingTime >= package.DurationTime) {
                    QueueList.RemoveAt(0);
                    FinalList.Add(WorkingTime);
                    // package.ProcessStartTime = WorkingTime;
                }
            }

        }
        public void AddPackage(Package package) {
            if (Size - OccupiedSize > 0 && package.ProcessStartTime != -1) {
                OccupiedSize++;
                WorkingTime = WorkingTime + package.ArrivalTime;
                QueueList.Add(package);
            } else {
                package.ProcessStartTime = -1;
            }

            //} else if (Size - OccupiedSize == 0) {
            //    if (package.ArrivalTime == QueueList[Size - 1].ArrivalTime) {
            //        EveryPackageProcessStartTime = EveryPackageProcessStartTime + "-1" + Environment.NewLine;
            //    } else if (package.ArrivalTime > QueueList[Size - 1].ArrivalTime) {
            //        if (package.ArrivalTime == QueueList[0].DurationTime) {
            //            WorkingTime += QueueList[0].DurationTime;
            //            EveryPackageProcessStartTime = EveryPackageProcessStartTime + Environment.NewLine + WorkingTime.ToString();
            //            QueueList.RemoveAt(0);
            //            QueueList.Add(package);
            //        } else {
            //            EveryPackageProcessStartTime = EveryPackageProcessStartTime + Environment.NewLine + "-1";
            //        }


            //    }

            //}
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

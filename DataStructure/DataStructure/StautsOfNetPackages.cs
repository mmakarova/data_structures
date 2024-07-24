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
                    queue.AddPackage(package);
                }
                foreach (Package p in queue.QueueList) {

                }
            }

        }
        public string GetOutputList() { return queue==null?"":queue.OutputList; }
    }

    class Queue {
        public Queue(int size) {
            this.Size = size;
            QueueList = new List<Package>();
        }
        public string OutputList = String.Empty;
        public List<Package> QueueList { get; set; }
        public int Size { get; set; }
        public int OccupiedSize { get; set; } = 0;
        public int WorkingTime { get; set; } = 0;
        public void AddPackage(Package package) {
            if (Size - OccupiedSize > 0) {
                OccupiedSize++;
                QueueList.Add(package);
                WorkingTime = package.ArrivalTime > WorkingTime ? package.ArrivalTime : WorkingTime;
                OutputList = OutputList + WorkingTime+Environment.NewLine;

            } else if (Size - OccupiedSize == 0) {
                if (package.ArrivalTime == QueueList[Size - 1].ArrivalTime) {
                    OutputList = OutputList + Environment.NewLine + "-1";
                } else if(package.ArrivalTime > QueueList[Size - 1].ArrivalTime) {
                    if (package.ArrivalTime == QueueList[0].DurationTime) {
                        WorkingTime += QueueList[0].DurationTime;
                        OutputList = OutputList + Environment.NewLine + WorkingTime.ToString();                        
                        QueueList.RemoveAt(0);
                        QueueList.Add(package);
                    } else {
                        OutputList = OutputList + Environment.NewLine + "-1";
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
        }
        public int ArrivalTime { get; set; }
        public int DurationTime { get; set; }
    }
}

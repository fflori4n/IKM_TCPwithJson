using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM_TCPwithJson
{
    public class DHT22 {
        public double temp;
        public double humidity;

        public DHT22(double temp, double humidity)
        {
            this.temp = temp;
            this.humidity = humidity;
        }
        public DHT22()
        {

        }

        public string ToString() { 
            return "DHT:" + temp + " " + humidity;
        }
    }    public class RoomSensor
    {
        public DHT22 tempSensor;
        public bool isOcupied;
        public bool isWindowOpen;
        public List<int> ocupiedLastHour;
        public string roomName;
        public string buildingName;
        public double lightLevel;

        public string printOcupArray() {
            string outStr = "";
            foreach (int num in ocupiedLastHour)
            {
                outStr += "[ " + num + " ]";
            }
            return outStr;
        }
        public string ToString() { 
            return tempSensor.ToString() + "\nisWindowOpen: " + isWindowOpen + "\nisOcup: " + isOcupied  + "\nlastHourOcupied: " + this.printOcupArray() + "\nroomName: " + this.roomName + "\nbuildingName: " + this.buildingName + "\nlight: " + this.lightLevel;
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsLibrary
{
    public class DriveInfo
    {
        private int _driveID = 0;
        private string _driveName = "";

        public int DriveID
        {
            get
            {
                return _driveID;
            }
            set
            {
                _driveID = value;
            }
        }

        public string DriveName
        {
            get
            {
                return _driveName;
            }
            set
            {
                _driveName = value;
            }
        }
    }
}

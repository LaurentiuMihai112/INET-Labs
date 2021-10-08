namespace Weather
{
    public class WeatherRow
    {
        private int _dy;
        private int _mxT;
        private int _mnT;
        private int _avT;
        private int _hDDay;
        private double _avDP;
        private int _hrP;
        private double _tPcpn;
        private string _wxType;
        private string _pDir;
        private double _avSp;
        private string _dir;
        private int _mxS;
        private double _skyC;
        private int _mxR;
        private int _mnR;
        private double _avSLP;

        public WeatherRow(int dy, int mxT, int mnT, int avT, int hDDay, double avDp, int hrP, double tPcpn, string wxType, string pDir, double avSp, string dir, int mxS, double skyC, int mxR, int mnR, double avSlp)
        {
            _dy = dy;
            _mxT = mxT;
            _mnT = mnT;
            _avT = avT;
            _hDDay = hDDay;
            _avDP = avDp;
            _hrP = hrP;
            _tPcpn = tPcpn;
            _wxType = wxType;
            _pDir = pDir;
            _avSp = avSp;
            _dir = dir;
            _mxS = mxS;
            _skyC = skyC;
            _mxR = mxR;
            _mnR = mnR;
            _avSLP = avSlp;
        }

        public int Dy
        {
            get => _dy;
            set => _dy = value;
        }

        public int MxT
        {
            get => _mxT;
            set => _mxT = value;
        }

        public int MnT
        {
            get => _mnT;
            set => _mnT = value;
        }

        public int GetTemperatureSpread()
        {
            return MxT - MnT;
        }
    }
}
namespace Weather
{
    public class WeatherRow
    {
        private int _dy;
        private int _mxT;
        private int _mnT;


        public WeatherRow(int dy, int mxT, int mnT)
        {
            _dy = dy;
            _mxT = mxT;
            _mnT = mnT;
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
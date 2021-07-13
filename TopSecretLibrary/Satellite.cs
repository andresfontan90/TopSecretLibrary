
namespace TopSecretLibrary
{
    public class Satellite
    {
        private string _name;
        private double _distance;
        private string[] _message;

        public string name
        {
            get{
                return _name;
            }
            set{
                _name = value;
            }
        }

        public double distance
        {
            get{
                return _distance;
            }
            set{
                _distance = value;
            }
        }

        public string[] message
        {
            get{
                return _message;
            }
            set{
                _message = value;
            }
        }

        public Satellite(string name, double distance, string[] message)
        {
            _name = name;
            _distance = distance;
            _message = message;
        }
    }
}

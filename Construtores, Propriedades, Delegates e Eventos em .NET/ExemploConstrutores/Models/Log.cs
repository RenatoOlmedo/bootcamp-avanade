namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;
        private Log()
        {
              
        }

        public static Log GetInstance(){
            if (_log == null){
                _log = new Log();
            }
            return _log;
        }
    }
}
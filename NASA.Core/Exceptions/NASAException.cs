namespace NASA.Core.Exceptions
{
    public class NASAException : ApplicationException
    {
        public NASAException()
        {
                
        }



        public NASAException(string errorMessage)
            : base(errorMessage)
        {

        }
    }
}


using NASA.Core.Contracts;
using System.Text;

namespace NASA.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ICourse course)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(course.Title.Replace(" ", "-"));
            

            return sb.ToString();
        }

       
    }
}

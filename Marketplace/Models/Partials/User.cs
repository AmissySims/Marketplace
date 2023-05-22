namespace Marketplace.Models
{
    public partial class User
    {
        public string FullName
        {
            get
            {
                return $"{FName} {Name} {MiddleName}";
            }


        }




    }
}



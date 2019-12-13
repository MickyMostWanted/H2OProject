using System;

namespace H2ODASApi.Data
{
    public class PeopleContext
    {
        public object UsersInfo { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
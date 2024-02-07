namespace Course.Model.Entities
{
    internal class User
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }
        public User(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                return false;
            }
            User other = obj as User;
            return this.UserName.Equals(other.UserName);
        }

        public override string ToString()
        {
            return UserName + " " + Instant.ToString();
        }
    }
}

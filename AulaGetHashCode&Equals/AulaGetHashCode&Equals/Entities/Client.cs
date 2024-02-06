namespace AulaGetHashCode_Equals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client)) // se obj ñ for uma instancia de Client
            {
                return false;    // false = não são iguais 
            }
            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
